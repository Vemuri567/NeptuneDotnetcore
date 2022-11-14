using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using OpenQA.Selenium.Interactions;
using Keys = OpenQA.Selenium.Keys;
using SeleniumExtras.WaitHelpers;

namespace Neptune360UIAutomation
{
    public class CustomerInquiryPage : AbstractTemplatePage
    {

        #region UI Object Repository
        private By titleCustomerInquiry = By.XPath("//h2[text()='Customer Inquiry']");
        private By drpSearch = By.XPath("//span[@class='k-button-icon k-icon k-i-arrow-s']");
        private By drpSearchCustAccount = By.XPath("//kendo-dropdownlist[contains(@class,'k-dropdownlist')]");
        private By drpValueAccountNo = By.XPath("//kendo-list/div/ul/li[1]");
        private By drpValueCustomerName = By.XPath("//kendo-list/div/ul/li[2]");
        private By drpValueMeterId = By.XPath("//kendo-list/div/ul/li[3]");
        private By drpValueAddress = By.XPath("//kendo-list/div/ul/li[4]");
        private By drpMeterNumber = By.XPath("//*[@formcontrolname='meterNumber']");
        private By drpMeterClass = By.XPath("//*[@formcontrolname='meterClass']");
        private By drpMeterSize = By.XPath("//*[@formcontrolname='meterSize']");
        private By drpMeterManufacturer = By.XPath("//*[@formcontrolname='meterManufacturer']");
        private By drpMeterInstallDate = By.XPath("//span[text()='Install Date']/..//input[@class='k-input-inner']");
        // private By drpMeterInstallDate = By.XPath("//sd-meter-form//kendo-datepicker//input");
        private By drpMeterRegInstallDate = By.XPath("//sd-register-form//kendo-datepicker//input");
        private By meterInstallDateTextBox = By.Id("k-8f12f9da-56c8-4a2f-bbe3-baa63e7f818e");
        private By drpRegisterID = By.XPath("//*[@formcontrolname='registerId']");
        private By drpRegisterType = By.XPath("//*[@formcontrolname='registerType']");
        private By drpResisterInstalldate = By.XPath("//*[@formcontrolname='registerInstallDatetime']");
        private By drpUOM = By.XPath("//*[@formcontrolname='registerUom']");
        private By drpNoOfDials = By.XPath("//*[@formcontrolname='numberOfDials']");
        private By drpValueMeterClass = By.XPath("//*[contains(@id,'HPFST')]");
        private By drpLinkedMiu = By.XPath("//*[@formcontrolname='linkedMiu']");
        private By drpMiuInstalldate = By.XPath("//*[@formcontrolname='miuInstallDatetime']");
        private By drpMiuFirmware = By.XPath("//*[@formcontrolname='miuFirmware']");
        private By txtAccountSearch = By.Id("txtAccountSearch");
        private By btnSearch = By.XPath("//span[@id='searchLink']");
        //private By btnSearch = By.Id("searchLink");
        private By customerContentLoader = By.XPath("//div[contains(@class,'customer-detail-content-loader')]");
        private By btnCreateComment1 = By.XPath("//button[text()='Create']");
        private By btnCreateComment = By.XPath("//sd-customerinquiry-comments/div/div[1]/button/span");
        private By btnEditComment = By.XPath("//span[@class='customerinquiry-comments-content-author']//following-sibling::button[@icon='pencil']");
        private By btnDeleteComment = By.XPath("//span[@class='customerinquiry-comments-content-author']//following-sibling::button[@icon='delete']");
        private By createCommentArea = By.XPath("//textarea");
        private By rowValueAccountNo = By.XPath("//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[2]/td[1]");
        private By rowValueAccountName = By.XPath("(//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[1]/td[2])[1]");
        private By rowValueAccountName2 = By.XPath("(//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[1]/td[2])");
        //private By rowValueAccountName = By.XPath("//kendo-grid-list//tr[1]/td[2]");
        private By rowValueAccountNameDailog = By.XPath("//kendo-dialog//kendo-grid-list//tr[1]/td[2]");
        private By rowValueMeterNo = By.XPath("//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[1]/td[3]");
        private By rowValueMIUId = By.XPath("//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[1]/td[4]");
        private By row2ValueMIUId = By.XPath("//kendo-grid-list//tr[2]/td[4]");
        private By rowValueAddress = By.XPath("//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[1]/td[5]");
        private By consumptionData = By.XPath("//sd-customerinquiry-report/div/div[4]/kendo-chart");
        private By btnOk = By.XPath("//button[text()='Ok']");
        private By btnSave = By.XPath("//button[text()='Save']");
        private By btnNo = By.XPath("//button[text()='No']");
        private By btnYes = By.XPath("//button[text()='Yes']");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By btnClear = By.XPath("//button[text()='Clear']");
        private By btnActual = By.XPath("//span[text()='Actual']");
        private By btnEstimated = By.XPath("//span[text()='Estimated']");
        private By lblAccountNo = By.XPath("//sd-customerinquiry-detail//div[2]/div[1]//dd[1]");
        private By lblAccountStatus = By.XPath("//dd/table/tbody/tr[1]/td[2]/span[2]");
        private By lblMeterId = By.XPath("//dd/table/tbody/tr[2]/td[1]/span[2]");
        private By lblMiuID = By.XPath("//dd/table/tbody/tr[1]/td[1]/span[2]");
        private By lblMIUStatus = By.XPath("//dd/table/tbody/tr[1]/td[2]/span[2]");
        private By lblAccountName = By.XPath("//sd-customerinquiry-detail/div/div/div/span");
        private By lblAddress = By.XPath("//sd-customerinquiry-detail/div/div[2]/div[1]/dl/dd[2]");
        private By lblMeterInstallDate = By.XPath("//span[text()='MIU Install Date']/..//following-sibling::span");
        private By lblMiuInstallDate = By.XPath("//dd/table/tbody/tr[3]/td[3]/span[2]");
        private By lblMeterSize = By.XPath("//dd/table/tbody/tr[3]/td[1]/span[2]");
        private By lblUnitMeasure = By.XPath("//span[text()='Unit of Measure']/following-sibling::span");
        private By lblLatestReading = By.XPath("//table/tbody/tr[2]/td[3]/span[2]");
        private By lblMeterClass = By.XPath("//span[text()='Meter Class']/../../following-sibling::div[1]/div[1]/span");
        private By lblStatus = By.XPath("//dd/table/tbody/tr[1]/td[2]/span[2]");
        private By moreMeters = By.XPath("//button[text()='More Meters >>']");
        private By moreMius = By.XPath("//button[text()='More MIUs >>']");
        private By btnEdit = By.Id("btnEdit");
        private By btnEditbutton = By.XPath("//div[@class='padding-bottom']//button[text()='Edit']");
        private By deleteConfirmation = By.XPath("//span[text()='Comment Delete']");
        private By dlgAssertConfig = By.XPath("//span[text()='Asset Configuration']");
        private By dlgChooseMeter = By.XPath("//span[text()='Choose A Meter']");
        private By btnCancelAssertConfig = By.XPath("//button[text()='Cancel']");
        private By btnExport = By.XPath("//button[text()='Export']");
        private By qabtnExport = By.XPath("//span[text()='Export']");

        private By exportExcel = By.XPath("//li[contains(.,'Export Detail - Excel')]");
        private By exportPdf = By.XPath("//li[contains(.,'Export Detail - PDF')]");
        private By lnkMoreMeters = By.XPath("//span[text()='Meter ID']/..//a[contains(text(), 'More Meters')]");
        private By grphConsumption = By.XPath("//div[text()='MONTHLY CONSUMPTION ANALYSIS']");
        private By toastMessage = By.Id("toast-container");
        private By noResultsFound = By.XPath("//span[text()='No Results Found']");
        private By meterInformation = By.XPath("//sd-customerinquiry-detail/div");
        private By assetConfiguration = By.Id("editAssetDialog");
        private By tabMIU = By.XPath("//span[text()='MIU']");
        private By tabMeter = By.XPath("//span[text()='Meter']");
        private By tabRegister = By.XPath("//span[text()='Register']");
        private By tabSoftDisconnect = By.XPath("//span[text()='Soft Disconnect']");
        private By softDiscCheckBox = By.CssSelector(".k-checkbox-label");
        private By miuID = By.XPath("//*[@formcontrolname='miuId']");
        private By commentSection = By.XPath("//sd-customerinquiry-comments/div/div[2]");
        private By errorMessage = By.XPath("//*[@id='editAssetDialog']/div[2]/div/div/div[2]/div");
        private By meterRow1 = By.XPath("//kendo-grid//table/tbody/tr[1]/td[4]");
        private By meterRow2 = By.XPath("//kendo-grid//table/tbody/tr[2]/td[4]");
        private By accList = By.XPath("//kendo-grid-list/div//table/tbody");
        private By assetConfigMeterNo = By.XPath("//*[@formcontrolname='meterNumber']");
        private By assetConfigMeterNo1 = By.XPath("//span[text()='Install Date']//following-sibling::span");
        private By lnkChooseUtilities = By.XPath("//sd-menu/ul/li");
        private By utilitySearch = By.Id("utilitySearchTextBox");
        private By btnChooseUtilitiesOk = By.Id("deactUtilityYesButton");
        private By tblChooseUtilities = By.XPath("//span[text()='Choose Utilities']//../../..//table[@class='k-grid-table']//span");
        private By refreshLink = By.XPath("//i[@class='fa fa-fs fa-refresh customer-detail-content-refreshread ng-star-inserted']");
        private By softDisconnect = By.XPath("//div//span[2]//i");
        private By softDiscStartDate = By.XPath("//label[2]/kendo-datepicker");
        private By softDiscEndDate = By.XPath("//label[3]/kendo-datepicker");

        private By accStatus = By.XPath("//div/div/span/span[contains(.,'Account Status')]");

        private By monthlyChart = By.XPath("//div[6]/img");
        private By installDateCol = By.XPath("//th[contains(.,'Install Date')]");
        private By accStatuscol = By.XPath("//th[contains(.,'Account Status')]");
        private By miuStatusCol = By.XPath("//th[contains(.,'MIU Status')]");
        private By deactivateDateCol = By.XPath("//th[contains(.,'Deactivate Date')]");

        private By accNoHeader = By.XPath("//th[contains(.,'Account Number')]");
        private By accNameHeader = By.XPath("//th[contains(.,'Account Name')]");
        private By meterNoHeader = By.XPath("//th[contains(.,'Meter Number')]");
        private By miuIdHeader = By.XPath("//th[contains(.,'MIU ID')]");
        private By addressHeader = By.XPath("//th[contains(.,'Address')]");
        private By meterType = By.XPath("//tr[2]/td[2]/span[2]");
        private By commDetails = By.XPath("//sd-customerinquiry-comments/div/div[2]/div[1]/div[2]");
        private By addRegister = By.CssSelector(".fa-plus-square");
        private By addRegisterCancel = By.XPath("//div[contains(@id,'kendo-dialog-content')]//button[text()='Cancel']");
        private By addRegisterSave = By.XPath("//div[2]/button[2]");
        private By changeOutDate = By.XPath("//th[text()='Change Out Date']");
        private By addRegFinalRead = By.XPath("//input[@name='registerChangeOutFinalRead']");
        private By addRegBeginningRead = By.XPath("//input[@name='registerChangeOutBeginningRead']");
        private By addRegOldRegID = By.XPath("//input[@name='registerChangeOutOldRegisterId']");
        private By addRegNewRegID = By.XPath("//input[@name='registerChangeOutNewRegisterId']");
        private By changeOutHistoryBtn = By.LinkText("Change Out History");
        private By changeOutAuditLogBtn = By.LinkText("Change Out Audit Log");
        private By changeOutAuditLogPage = By.XPath("//kendo-dialog[2]/div[2]");
        private By typeCol = By.XPath("//th[contains(.,'Type')]");
        private By changeOutDateCol = By.XPath("//th[contains(.,'Change Out Date')]");
        private By finalReadCol = By.XPath("//th[contains(.,'Final Read')]");
        private By beginningReadCol = By.XPath("//th[contains(.,'Beginning Read')]");
        private By oldRegisterCol = By.XPath("//th[contains(.,'Old Register ID')]");
        private By newRegisterCol = By.XPath("//th[contains(.,'New Register ID')]");
        private By userCol = By.XPath("//th[contains(.,'User')]");
        private By timeStampCol = By.XPath("//th[contains(.,'Time Stamp')]");
        private By changeOutHistoryAdd = By.XPath("//button[contains(.,'Add')]");
        private By changeOutHistoryEdit = By.XPath("//kendo-dialog[2]/div[2]//button[contains(.,'Edit')]");
        private By changeOutHistoryDelete = By.XPath("//kendo-dialog[2]/div[2]//button[contains(.,'Delete')]");
        private By changeOutClose = By.XPath("//kendo-dialog[2]//kendo-dialog-titlebar/div[2]/button");
        private By changeOutHistoryRow = By.XPath("//kendo-grid/div/table/tbody/tr[1]/td[1]");
        private By editRegisterChangeOutPage = By.XPath("//span[text()='Edit Register Change Out']");
        private By deleteChangeOutHistoryPage = By.XPath("//div[text()='DELETE CONFIRMATION']");
        private By deleteChangeOutHistoyCancel = By.XPath("//kendo-dialog[3]/div[2]//button[text()='Cancel']");
        private By deleteChangeOutHistoyDelete = By.XPath("//kendo-dialog[3]/div[2]//button[text()='Delete']");
        private By deleteChangeOutConfirmation = By.XPath("//span[contains(.,'Are you sure you want')]");
        private By editRegisterCancel = By.XPath("//kendo-dialog[2]/div[2]//button[text()='Cancel']");
        private By editRegisterSave = By.XPath("//kendo-dialog[2]/div[2]//button[text()='Save']");
        private By editRegisterConfirm = By.XPath("//kendo-dialog[2]/div[2]//button[text()='Confirm']");
        private By moreThan1000Rows = By.XPath("//span[contains(.,'Your search returned 1000 results')]");
        private By map = By.CssSelector(".customerinquiry-map-image");
        // private By commentSection = By.XPath("//sd-customerinquiry-comments/div/div[2]");
        public DataTable executeQuery = new DataTable();
        #endregion


        /// <summary>
        /// Method to Validate Search Account by Meter Id
        /// </summary>
        public void ValidateSearchAccountByMUIdConsumption(string meterId)
        {
            try
            {
                string tblMeterId = "";
                driver.ClickElement(drpSearchCustAccount, "Search Account");
                driver.ClickElement(drpValueMeterId, "MeterId");
                driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
                driver.ClickElement(btnSearch, "Search");


                tblMeterId = driver.GetElementText(rowValueMeterNo);
                driver.ClickElement(rowValueMeterNo, "Meter Id");
                driver.ClickElement(btnOk, "Ok");
                driver.WaitForPageLoad(TimeSpan.FromSeconds(60));
                //driver.sleepTime(40000);

                driver.SwitchToFrameById("ntgMSTRFrame");
                By mapelement = By.XPath("//map//area[4]");// //map/area //img[contains(@usemap,'map')]

                driver.ClickElementWithJavascript(mapelement, "");

                By consumpTable = By.XPath("//*[contains(@id,'_scrollbox')]/div[contains(@id,'mstr')]/table");
                IWebElement consumptionData = driver.FindElement(consumpTable);
                DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);

                for (int i = 1; i < reportsData.Rows.Count; i++)
                {
                    double consumption = double.Parse(reportsData.Rows[i - 1]["Reading"].ToString()) - double.Parse(reportsData.Rows[i]["Reading"].ToString());
                    if (consumption / 100 == double.Parse(reportsData.Rows[i - 1]["Daily Consumption"].ToString()))
                    {
                        testReport.Pass("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> matches consumption value: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> does not match.\n Expected: <mark>" + consumption.ToString() + "</mark> Actual: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("exception" + ex.ToString());
            }
        }
        public void ValidateConsumtionData(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");


            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
            IWebElement chart = driver.FindElement(By.XPath("//*[name()='svg']"));
            string[] charttext = chart.Text.Split('\n');
            IList<IWebElement> pathvarsDaily = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'http://www.qa.neptune360.com/customerinquiry')]//*[name()='path']"));
            int count = 0;
            foreach (IWebElement variabD in pathvarsDaily)
            {
                try
                {
                    count++;
                    if (count == 2)
                    {
                        variabD.Click();
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("variable:" + variabD.ToString() + "  exception:" + e.ToString());
                }

            }
            driver.sleepTime(10000);
            By consumpTable = By.XPath("//div[@class='customerinquiry-report-grid']//table[@class='k-grid-table']");
            //IWebElement consumptionData = driver.FindElement(consumpTable);
            //DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);

            IList<IWebElement> pathvarsHourly = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'http://www.qa.neptune360.com/customerinquiry')]//*[name()='path']"));
            int countH = 0;
            foreach (IWebElement variabH in pathvarsHourly)
            {
                try
                {
                    countH++;
                    if (countH == 2)
                    {
                        variabH.Click();
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("variable:" + variabH.ToString() + "  exception:" + e.ToString());
                }
                // driver.WaitForElement(By.XPath("ntgMSTRFrame"), TimeSpan.FromSeconds(40));

                // driver.SwitchToFrameById("ntgMSTRFrame");
                //driver.CheckElementDisplayed(By.XPath("//sd-customers-reports-iframe/sd-mstr-iframe-component/div/iframe"), "");
                // driver.SwitchToDefaultFrame();

            }
        }
        /// <summary>
        /// Method to Validate Search Select Account
        /// </summary>
        public void ValidateSearchSelectAccountNo(string accountNo)
        {
            string tblAccountNo = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account Number");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblAccountNo = driver.GetElementText(rowValueAccountNo);
            driver.ClickElement(rowValueAccountNo, "Account Number");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            accountNo = driver.GetElementText(lblAccountNo);
            if (tblAccountNo.Contains(accountNo))
                testReport.Pass("Account Information displayed for Account Number: <mark>" + accountNo + "</mark> is Successfull");
            else
                ReporterFactory.LogFailure("Account Information displayed for Account Number: <mark>" + accountNo + "</mark> is not Successfull");
        }

        /// <summary>
        /// Method to Validate Search Account by Meter Id
        /// </summary>
        public void ValidateSearchAccountByMeterId(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            meterId = driver.GetElementText(lblMeterId);
            if (tblMeterId.Contains(meterId))
                testReport.Pass("Account Information displayed for Meter Id: <mark>" + meterId + "</mark> is Successfull");
            else
                ReporterFactory.LogFailure("Account Information displayed for Meter Id: <mark>" + meterId + "</mark> is not Successfull");
        }

        /// <summary>
        /// Method to Validate Search Account by Meter Id
        /// </summary>
        public void ValidateSearchAccountByMUId(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, "1", "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueMeterNo, TimeSpan.FromSeconds(60));

            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            driver.WaitForElement(lblMeterId, TimeSpan.FromSeconds(60));

            driver.WaitForElementNotExists(customerContentLoader, 120);
            //meterId = driver.GetElementText(lblMeterId);
            //if (tblMeterId.Contains(meterId))
            //    testReport.Pass("Account Information displayed for Meter Id: <mark>" + meterId + "</mark> is Successfull");
            //else
            //    ReporterFactory.LogFailure("Account Information displayed for Meter Id: <mark>" + meterId + "</mark> is not Successfull");
            driver.CheckElementDisplayed(lblMeterId, "Meter ID");
        }

        /// <summary>
        /// Method to Validate Partial Search
        /// </summary>
        public void ValidatePartialSearch(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Pass("All Account Informations are Displayed for Meter Id Matching Criteria: <mark>" + meterId);
        }

        /// <summary>
        /// Method to Validate MeterId Partial Search 
        /// </summary>
        public void ValidateMeterIdPartialSearch(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            var searchResults = driver.FindElements(By.XPath("//td[contains(text(),'" + meterId.ToUpper() + "')]"));
            if (searchResults.Count == 0)
            {
                ReporterFactory.LogFailure("No Results Found For: <mark>" + meterId);
            }
            else
            {
                testReport.Pass("Search Results Found for : <mark>" + meterId);
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Customer Name Partial Search 
        /// </summary>
        public void ValidateCustNamePartialSearch(string customerName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Customer Name");
            driver.SendKeysToElementClearFirst(txtAccountSearch, customerName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(60));
            //var searchResults = driver.FindElements(By.XPath("//td[contains(text(),'" + customerName + "')]"));
            //if (searchResults.Count == 0)
            //{
            //    testReport.Pass("Search Results Found for : <mark>" + customerName);
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("No Results Found For: <mark>" + customerName);
            //}

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Address Partial Search 
        /// </summary>
        public void ValidateAddressPartialSearch(string address)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAddress, "Address");
            driver.SendKeysToElementClearFirst(txtAccountSearch, address, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(60));
            var searchResults = driver.FindElements(By.XPath("//td[contains(text(),'" + address.ToUpper() + "')]"));
            if (searchResults.Count == 0)
            {
                ReporterFactory.LogFailure("No Results Found For: <mark>" + address);
            }
            else
            {
                testReport.Pass("Search Results Found for : <mark>" + address);
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Account Partial Search 
        /// </summary>
        public void ValidateAccountPartialSearch(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            var searchResults = driver.FindElements(By.XPath("//td[contains(text(),'" + accNo.ToUpper() + "')]"));
            if (searchResults.Count == 0)
            {
                ReporterFactory.LogFailure("No Results Found For: <mark>" + accNo);
            }
            else
            {
                testReport.Pass("Search Results Found for : <mark>" + accNo);
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Exact MeterID Search 
        /// </summary>
        public void ValidateExactMeterIdSearch(string meterID)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Meter ID");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterID, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            var searchResults = driver.FindElements(By.XPath("//td[contains(text(),'" + meterID.ToUpper() + "')]"));
            if (searchResults.Count == 0)
            {
                ReporterFactory.LogFailure("No Results Found For: <mark>" + meterID);
            }
            else
            {
                driver.CheckElementDisplayed(rowValueMIUId, "Meter ID");
                testReport.Pass("Search Results Found for : <mark>" + meterID);
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Exact Customer Name Search 
        /// </summary>
        public void ValidateExactCustNameSearch(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Meter ID");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            var searchResults = driver.FindElements(By.XPath("//td[contains(text(),'" + custName.ToUpper() + "')]"));
            if (searchResults.Count == 0)
            {
                testReport.Pass("Results Found For: <mark>" + custName);
            }
            else
            {
                driver.CheckElementDisplayed(rowValueAccountName, "Customer Name");
                ReporterFactory.LogFailure("No Results Found For: <mark>" + custName);
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Exact Address Search 
        /// </summary>
        public void ValidateExactAddressSearch(string address)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAddress, "Address");
            driver.SendKeysToElementClearFirst(txtAccountSearch, address, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(rowValueAddress, "Address"))
            {
                testReport.Pass("Search Result Found for <mark>" + address);
            }
            else
            {
                ReporterFactory.LogFailure("No result found for <mark> " + address);
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Exact Account Search 
        /// </summary>
        public void ValidateExactAccountSearch(string account)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, account, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(rowValueAccountNo, "Address"))
            {
                testReport.Pass("Search Result Found for <mark>" + account);
            }
            else
            {
                ReporterFactory.LogFailure("No result found for <mark> " + account);
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Customer Name
        /// </summary>
        public void ValidateCustomerName(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Meter Id");
            driver.ClickElement(btnOk, "OK");
            //driver.WaitForElement(lblAccountName, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblAccountName, "Account Name"))
            {
                testReport.Pass("Account Name displayed for meter Id : " + meterId + " is : <mark>" + driver.GetElementText(lblAccountName));
            }
            else
            {
                ReporterFactory.LogFailure("No results found for meter id : " + meterId);
            }
        }

        /// <summary>
        /// Method to Validate Customer Address
        /// </summary>
        public void ValidateCustomerAddress(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueMIUId, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAddress, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblAddress, "Address"))
            {
                testReport.Pass("Address found for meter ID : " + meterId + " is <mark>" + driver.GetElementText(lblAddress));
            }
            else
            {
                ReporterFactory.LogFailure("No address found for meter Id : " + meterId);
            }
        }
        /// <summary>
        /// Method to Validate Customer Acc Info
        /// </summary>
        public void ValidateSearchView()
        {
            if (driver.CheckElementDisplayed(drpSearchCustAccount, "Search Field") & driver.CheckElementDisplayed(btnSearch, "Maginifier"))
            {
                testReport.Pass("<i><b>Search field and Search Button are available");
            }
            else
            {
                ReporterFactory.LogFailure("Search field and Search Button are not available");
            }
        }
        /// <summary>
        /// Method to Validate Customer Acc Info
        /// </summary>
        public void ValidateCustAccInfo(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, "123", "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account No");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(2000));

            if (driver.CheckElementDisplayed(lblAccountNo, "Account No") && driver.CheckElementDisplayed(lblAccountStatus, "Account Status") &&
                driver.CheckElementDisplayed(lblMeterId, "MeterId") && driver.CheckElementDisplayed(lblMiuID, "MiuID") &&
                driver.CheckElementDisplayed(lblMIUStatus, "MIU Status") && driver.CheckElementDisplayed(lblAccountName, "Account Name") &&
                driver.CheckElementDisplayed(lblAddress, "Address") && driver.CheckElementDisplayed(lblMeterInstallDate, "MeterInstallDate") &&
                driver.CheckElementDisplayed(lblMiuInstallDate, "MiuInstallDate") && driver.CheckElementDisplayed(lblMeterSize, "MeterSize") &&
                driver.CheckElementDisplayed(lblUnitMeasure, "UnitMeasure") && driver.CheckElementDisplayed(lblLatestReading, "LatestReading"))
            {
                testReport.Pass("<i>Account name displayed is :" + driver.GetElementText(lblAccountName) + "Äddress Displayd : " + driver.GetElementText(lblAddress) + "Miu Id : " + driver.GetElementText(lblMiuID) + "Meter Install date: " + driver.GetElementText(lblMiuID) + " Meter Id : " + driver.GetElementText(lblMeterId) + "Unit of measurement : " + driver.GetElementText(lblUnitMeasure) + " are available.");
            }
            else
            {
                ReporterFactory.LogFailure("Search Feild does not exist.");
            }
        }
        public void ValidateAccountContentValidation(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(accNoHeader, "Account No Header");
            driver.CheckElementDisplayed(accNameHeader, "Acc Name Header");
            driver.CheckElementDisplayed(meterNoHeader, "Meter No Header");
            driver.CheckElementDisplayed(miuIdHeader, "Miu ID Header");
            driver.CheckElementDisplayed(addressHeader, "Address Header");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Miu Install Date
        /// </summary>
        public void ValidateMiuInstallDate(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu Id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account No");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(2000));
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Miu Intall Date"))
            {
                testReport.Pass("<i> MIU Install Date is : <b>" + driver.GetElementText(lblMiuInstallDate));
            }
            else
            {
                ReporterFactory.LogFailure("Miu Install date is not present.");
            }
        }
        /// <summary>
        /// Method to Validate Miu Install Date
        /// </summary>
        public void ValidateMeterInstallDate(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu Id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account No");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(2000));
            //if(driver.CheckElementNotDisplayed(lblMeterInstallDate,"Not specified")& driver.CheckElementDisplayed(lblMeterInstallDate,"Meter Install Date"))
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Meter Install Date"))
            {
                testReport.Pass("<i> Meter Install Date is : <b>" + driver.GetElementText(lblMeterInstallDate));
            }
            else
            {
                ReporterFactory.LogFailure("Meter Install date is not present.");
            }
        }

        public void ValidateInstallDateColumn(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu Id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(installDateCol, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(installDateCol, "Install date");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateInstallDateColumnSortDescending(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu Id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(installDateCol, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(installDateCol, "Install date");
            driver.sleepTime(3000);
            driver.ClickElement(installDateCol, "Install date");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateInstallDateColumnSortAscending(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu Id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(installDateCol, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(installDateCol, "Install date");
            driver.sleepTime(3000);
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateModalFeildsDisplay(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu Id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(installDateCol, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(accNoHeader, "Acc No");
            driver.CheckElementDisplayed(accNameHeader, "Acc Name");
            driver.CheckElementDisplayed(accStatuscol, "Acc Status");
            driver.CheckElementDisplayed(meterNoHeader, "Meter No");
            driver.CheckElementDisplayed(miuIdHeader, "Miu ID");
            driver.CheckElementDisplayed(miuStatusCol, "Miu Status");
            driver.CheckElementDisplayed(addressHeader, "Address");
            driver.CheckElementDisplayed(installDateCol, "Install date");
            driver.CheckElementDisplayed(deactivateDateCol, "Deactivate Date");

            driver.sleepTime(3000);
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Miu Install Date
        /// </summary>
        public void ValidateMiuInstallDateNotSpecified(string miuId)
        {
            //driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            //driver.SendKeysToElementAndPressEnter(utilitySearch, "SQA", "Utility");
            //driver.ClickElement(tblChooseUtilities, "Select");
            //driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu Id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account No");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(2000));
            if (driver.GetElementText(lblMiuInstallDate).Equals("Not specified"))
            {
                testReport.Pass("<i>Miu Install Date is : <b>" + driver.GetElementText(lblMiuInstallDate));
            }
            else
            {
                ReporterFactory.LogFailure("Miu Install date is not present.");
            }
        }
        /// <summary>
        /// Method to Validate Miu Install Date
        /// </summary>
        public void ValidateMeterInstallDateNotSpecified(string meterId)
        {
            //driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            //driver.SendKeysToElementAndPressEnter(utilitySearch, "SQA", "Utility");
            //driver.ClickElement(tblChooseUtilities, "Select");
            //driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu Id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account No");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(2000));
            if (driver.GetElementText(lblMeterInstallDate).Equals("Not specified"))
            {
                testReport.Pass("<i>Miu Install Date is : <b>" + driver.GetElementText(lblMeterInstallDate));
            }
            else
            {
                ReporterFactory.LogFailure("Miu Install date is : " + driver.GetElementText(lblMeterInstallDate));
            }
        }

        /// <summary>
        /// Method to Validate Edit asset configuration dialgue and save
        /// </summary>
        public void ValidateEditAssetConfigurationDialogue(string meterClass, string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account Name");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountName, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            //driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(2000));
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            ////driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(btnSave, "Save");
            //driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            // driver.Navigate().Refresh();
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account Name");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountName, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            //driver.CheckElementDisplayed(drpMeterClass, "Meter Class");

            //if (driver.GetElementText(drpMeterClass).Equals(meterClass))
            //{
            //    testReport.Pass("<i>Edit is saved as : <b>"+meterClass);
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i>Edit is not saved. ");
            //}
            driver.ClickElement(btnCancel, "Cancel Button");
        }

        /// <summary>
        /// Method to Validate More Mius Link
        /// </summary>
        public void ValidateMoreMiusLink(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account Name");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountName, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");

            driver.WaitForElement(moreMius, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(moreMius, "More MIUs >"))
            {
                testReport.Pass("<i><b>More MIUs > </b>link is present");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>More Mius > link is not present");
            }
        }

        ///// <summary>
        ///// Method to Validate LatestReading
        ///// </summary>
        //public void ValidateLatestReading(string custName)
        //{
        //    driver.ClickElement(drpSearchCustAccount, "Search Account");
        //    driver.ClickElement(drpValueCustomerName, "Account Name");
        //    driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
        //    driver.ClickElement(btnSearch, "Search");
        //    driver.WaitForElement(rowValueAccountName, System.TimeSpan.FromSeconds(20));
        //    driver.ClickElement(rowValueAccountName, "Account Name");
        //    driver.ClickElement(btnOk, "OK");

        //    driver.WaitForElement(lblLatestReading, System.TimeSpan.FromSeconds(20));
        //    if (driver.CheckElementDisplayed(lblLatestReading, "Latest reading "))
        //    {
        //        testReport.Pass("<i><b>Latest reading </b> is : "+driver.GetElementText(lblLatestReading));
        //    }
        //    else
        //    {
        //        ReporterFactory.LogFailure("<i><b>Latest Reading is not available");
        //    }
        //}

        /// <summary>
        /// Method to Validate Customer Meter Id
        /// </summary>
        public void ValidateCustomerMeterID(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMeterId, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblAccountName, "Account Name"))
            {
                testReport.Pass("Meter Id found for Meter ID :" + meterId + " is : <mark>" + driver.GetElementText(lblAccountName));
            }
            else
            {
                ReporterFactory.LogFailure("No Acc Name found for Meter Id :" + meterId);
            }
        }

        /// <summary>
        /// Method to Validate Customer Status
        /// </summary>
        public void ValidateCustomerStatus(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblStatus, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblStatus, "Account Name"))
            {
                testReport.Pass("Status for meter ID : " + meterId + " is <mark>: " + driver.GetElementText(lblStatus));
            }
            else
            {
                ReporterFactory.LogFailure("No Status found for Meter Id :" + meterId);
            }
        }

        /// <summary>
        /// Method to Validate MIUId
        /// </summary>
        public void ValidateMIUId(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblMiuID, "Account Name"))
            {
                testReport.Pass("MIU Id for meter ID : " + meterId + " is <mark>: " + driver.GetElementText(lblMiuID));
            }
            else
            {
                ReporterFactory.LogFailure("No Status found for Meter Id :" + meterId);
            }
        }

        /// <summary>
        /// Method to Validate MIU Install Date
        /// </summary>
        public void ValidateMIUInstallDate(string accountNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMeterInstallDate, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Install Date"))
            {
                testReport.Pass("Meter Install Date for  Account no  : " + accountNo + " is <mark>: " + driver.GetElementText(lblMeterInstallDate));
            }
            else
            {
                ReporterFactory.LogFailure("No Status found for  Account no  :" + accountNo);
            }
        }

        /// <summary>
        /// Method to Validate Meter Size
        /// </summary>
        public void ValidateMeterSize(string accountNo)
        {
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountName2, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName2, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMeterSize, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblMeterSize, "Meter Size"))
            {
                testReport.Pass("Meter Size for Account no : " + accountNo + " is <mark>: " + driver.GetElementText(lblMeterSize));
            }
            else
            {
                ReporterFactory.LogFailure("No Status found for Account no :" + accountNo);
            }
        }

        /// <summary>
        /// Method to Validate Latest Reading
        /// </summary>
        public void ValidateLatestReading(string accountNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuInstallDate, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblLatestReading, "Install Date"))
            {
                testReport.Pass("Latest Reading for Account no : " + accountNo + " is <mark>: " + driver.GetElementText(lblLatestReading));
            }
            else
            {
                ReporterFactory.LogFailure("No Reading found for Account no :" + accountNo);
            }
        }
        public void ValidateRefreshReadsDisplayed(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu ID");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(refreshLink, System.TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(refreshLink, "Refresh Link");
        }
        public void ValidateRefreshReadsReEnabled(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu ID");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(refreshLink, System.TimeSpan.FromSeconds(40));
            driver.CheckElementDisplayed(refreshLink, "Refresh Link");
            driver.sleepTime(10000);
            driver.CheckElementDisplayed(refreshLink, "Refresh Link");
        }
        public void ValidateRefreshReadsSuccessToast(string miuId)
        {
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.sleepTime(6000);
            if (!driver.FindElement(By.XPath("//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[2]/td[1]")).Displayed == true)
            {
                driver.Navigate().Refresh();
                driver.ClickElement(drpSearch, "Search Account");
                driver.ClickElement(drpValueMeterId, "Account");
                driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
                driver.ClickElement(btnSearch, "Search");
            }
            else
            {
                driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            }
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(refreshLink, System.TimeSpan.FromSeconds(40));
            driver.ClickElement(refreshLink, "Refresh Link");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(toastMessage, "Success Toast");
        }
        public void ValidateRefreshReadsNotDisplayed(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Miu ID");
            driver.SendKeysToElement(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuInstallDate, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDoesnotExists(refreshLink, "Refresh Link");
        }

        /// <summary>
        /// Method to Validate More meters list
        /// </summary>
        public void ValidateListOfMoreMeters(string accountNo)
        {
            // driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            //driver.SendKeysToElementAndPressEnter(utilitySearch, "SQA", "Utility");
            //  driver.ClickElement(tblChooseUtilities, "Select");
            // driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Meter No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(moreMeters, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(moreMeters, "More meters");
            if (driver.CheckElementDisplayed(meterRow1, "Meter Row 1"))
            {
                if (driver.CheckElementDisplayed(meterRow2, "Meter Row 2"))
                {
                    testReport.Pass("<i><mark>2nd Meter row is in date sort order");
                }
                testReport.Pass("<i><mark>1st Meter row is in date sort order");
            }
            else
            {
                ReporterFactory.LogFailure("No Reading found for Account no :" + accountNo);
            }
            driver.ClickElement(btnCancel, "Cancel Button");
        }

        /// <summary>
        /// Method to Validate Select meter from more meter
        /// </summary>
        public void ValidateSelectMeterFromMoreMeters(string accountNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(moreMeters, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(moreMeters, "More meters");
            driver.ClickElement(meterRow1, "Select 1st Meter");
            driver.ClickElement(btnOk, "OK Button");
            if (driver.CheckElementDisplayed(meterInformation, "Meter Information "))
            {
                testReport.Pass("<i><mark>Meter Information is displayed for selected meter. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><mark>Meter Information is not displayed for selected meter. ");
            }

        }

        /// <summary>
        /// Method to Validate Acc No sort order
        /// </summary>
        public void ValidateAccNoSortOrder(string accountNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            //driver.ClickElement(btnOk, "OK");

            if (driver.CheckElementDisplayed(accList, "List Of All Accounts "))
            {
                testReport.Pass("<i><mark>Accounts Displayed in sort order ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><mark>Accounts Not Displayed in sort order  ");
            }
            driver.ClickElement(btnCancel, "Button Cancel");
        }


        public void ValidateMeterTabUIDisplay(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.CheckElementDisplayed(drpMeterSize, "Meter Class");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateRegisterTabUOMDisplay(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabRegister, "RegisterTab");
            driver.CheckElementDisplayed(drpUOM, "UOM");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDefaultUOMDisplay(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblUnitMeasure, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(lblUnitMeasure, "UNit OF Measure");
            driver.GetElementText(lblUnitMeasure);
        }
        public void ValidateMeterSizeUOMDisplay(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblUnitMeasure, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size" + driver.GetElementText(lblMeterSize).ToString());
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit OF Measure" + driver.GetElementText(lblUnitMeasure).ToString());

        }

        /// <summary>
        /// Method to Validate Edit Meter Install Date Register Type
        /// </summary>
        public void ValidateMeterInstallDateRegisterType(string miuId, string meterInstallDate, string registerType)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.FindElement(drpMeterInstallDate).Click();
            driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpRegisterType, "Register Type");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + registerType + "')]"), "Register Type");
            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(15000);
            // driver.Navigate().Refresh();
            driver.sleepTime(5000);
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Meter Install date"))
            {
                testReport.Pass("<i>Meter Intall Date Edit is Successful : <b>" + meterInstallDate);
            }
            else
            {
                ReporterFactory.LogFailure("<i>Meter install date is not successful as : " + meterInstallDate + " Date is : " + driver.GetElementText(lblMeterInstallDate));
            }

        }

        /// <summary>
        /// Method to Validate Edit Meter Install Date Register Intall date
        /// </summary>
        public void ValidateMeterInstallDateRegisterIntallDate(string miuId, string meterInstallDate, string registerIntallDate)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            // driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.FindElement(drpResisterInstalldate).Click();
            driver.FindElement(drpResisterInstalldate).Click();
            driver.sleepTime(1000);
            SimulateSendKeys(registerIntallDate);
            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(8000);
            // driver.Navigate().Refresh();
            driver.sleepTime(3000);
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            try
            {
                driver.ClickElement(rowValueAccountName, "Account Name");
            }
            catch
            {
                driver.ClickElement(rowValueAccountName2, "Account Name");
            }

            driver.ClickElement(btnOk, "OK");
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Meter Install date"))
            {
                testReport.Pass("<i>Meter Intall Date Edit is Successful : <b>" + meterInstallDate);
            }
            else
            {
                ReporterFactory.LogFailure("<i>Meter install date is not successful as : " + meterInstallDate + " Date is : " + driver.GetElementText(lblMeterInstallDate));
            }

        }

        /// <summary>
        /// Method to Validate Edit Meter Install Date UOM
        /// </summary>
        public void ValidateMeterInstallDateUOM(string miuId, string meterInstallDate, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
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
                }
            }

            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(8000);
            // driver.Navigate().Refresh();
            driver.sleepTime(3000);
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNameDailog, "Account Name");
            driver.ClickElement(btnOk, "OK");
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Meter Install date"))
            {
                testReport.Pass("<i>Meter Intall Date Edit is Successful : <b>" + meterInstallDate);
            }
            else
            {
                ReporterFactory.LogFailure("<i>Meter install date is not successful as : " + meterInstallDate + " Date is : " + driver.GetElementText(lblMeterInstallDate));
            }
        }

        /// <summary>
        /// Method to Validate Alphanumeric Acc Search
        /// </summary>
        public void ValidateAccSearchAlphanumeric(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(rowValueMIUId, "Miu Id"))
            {
                driver.ClickElement(rowValueMIUId, "Miu Id");
                testReport.Pass("<i>Miu Id : " + miuId + " is Alphanumeric. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Miu Id : " + miuId + " is not Alphanumeric. ");
            }
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(1500);
        }

        /// <summary>
        /// Method to Validate Alphanumeric Acc Search Miu Id
        /// </summary>
        public void ValidateAccSearchAlphanumericMiuId(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.sleepTime(5000);
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(rowValueMeterNo, "Meter Number "))
            {
                testReport.Pass("<i>Meter Number Comulmn Exists. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><i>Meter Number Comulmn does not Exists.");
            }
            driver.ClickElement(rowValueMeterNo, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(1500);
        }
        /// <summary>
        /// Method to Validate more meters Alphanumeric Acc Search Miu Id
        /// </summary>
        public void ValidateMoreMetersAlphanumericMiuId(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Miu Id");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.WaitForElement(moreMeters, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(moreMeters, "More meters link");
            if (driver.CheckElementDisplayed(rowValueMeterNo, "Meter Number "))
            {
                driver.ClickElement(rowValueMeterNo, "Meter Number ");
                testReport.Pass("<i>Meter Number Comulmn Exists. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><i>Meter Number Comulmn does not Exists.");
            }
            driver.ClickElement(btnCancel, "Cancel Button");
            driver.sleepTime(15000);
        }

        /// <summary>
        /// Method to Validate Alphanumeric meter id
        /// </summary>
        public void ValidateAlphanumericMeterId(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");

            if (driver.CheckElementDisplayed(rowValueMeterNo, "Meter Number "))
            {
                testReport.Pass("<i>Alphanumeric Meter Number Exists. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Alphanumeric Meter Number does Not Exists. ");
            }
            driver.ClickElement(btnCancel, "Cancel Button");
            driver.sleepTime(15000);
        }

        /// <summary>
        /// Method to Validate meter not available for deactive status
        /// </summary>
        public void ValidateMeterNotAvailableDeactiveStatus(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            string status = driver.FindElement(By.XPath("//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[1]")).GetAttribute("class");
            if (!status.Contains("ng-star-inserted k-state-selected"))
            {
                testReport.Pass("<i>meter ids are in deactive status<b>");
            }
            else
            {
                ReporterFactory.LogFailure("Meter ids are in active state ");
            }
            /*if (driver.CheckElementDoesnotExists(rowValueMIUId, "Miu Id"))
            {
                testReport.Pass("<i>Meter not available for : <b>" + meterId);
            }
            else
            {
                ReporterFactory.LogFailure("Meter available ");
            }*/
            driver.ClickElement(btnCancel, "Cancel Button");
        }

        /// <summary>
        /// Method to Validate Alphanumeric meter feild displayed
        /// </summary>
        public void ValidateAlphanumericMeterNoFeild(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");
            driver.ClickElement(btnOk, "Ok Button");
            driver.WaitForElement(moreMeters, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            if (driver.CheckElementDisplayed(assetConfigMeterNo, "Meter Number"))
            {
                testReport.Pass("<i>Alphanumeric Meter Number Exists. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Alphanumeric Meter Number does Not Exists. ");
            }
            driver.ClickElement(btnCancel, "Cancel Button");
            driver.sleepTime(15000);
        }

        /// <summary>
        /// Method to Validate Meter import date available  for deactive status
        /// </summary>
        public void ValidateMeterImportDateForDeactiveStatus(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, "1", "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");
            driver.ClickElement(btnOk, "Ok Button");
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Meter Install Date"))
            {
                testReport.Pass("<i> Meter Install date is displayed for meter no : <b>" + driver.GetElementText(lblMeterId));
            }
            else
            {
                ReporterFactory.LogFailure("Meter Install date is not available");
            }
        }
        public void ValidateMoreThan1000Rows(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(moreThan1000Rows, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(moreThan1000Rows, "more Than 1000 Rows Message");
            driver.ClickElement(btnCancel, "Cancel");

        }




        /// <summary>
        /// Method to Validate initial Meter import date available  
        /// </summary>
        public void ValidateInitialMeterImportDate(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, "1", "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");
            driver.ClickElement(btnOk, "Ok Button");
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Meter Install Date"))
            {
                testReport.Pass("<i> Meter Install date is displayed for meter no : <b>" + driver.GetElementText(lblMeterId));
            }
            else
            {
                ReporterFactory.LogFailure("Meter Install date is not available");
            }
        }

        /// <summary>
        /// Method to Validate account start date available
        /// </summary>
        public void ValidateAccStartDate(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");
            driver.ClickElement(btnOk, "Ok Button");
            driver.sleepTime(15000);
            driver.ClickElement(moreMeters, "More meters");
            driver.WaitForElement(rowValueMIUId, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(rowValueMIUId, "Start Date "))
            {
                testReport.Pass("<i>Start date is : <b>" + driver.GetElementText(rowValueMIUId));
            }
            else
            {
                ReporterFactory.LogFailure("Date is not available");
            }
            driver.ClickElement(btnCancel, "Cancel Button");
        }
        /// <summary>
        /// Method to Validate account end date available
        /// </summary>
        public void ValidateAccEndDate(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");
            driver.ClickElement(btnOk, "Ok Button");
            driver.sleepTime(15000);
            driver.ClickElement(moreMeters, "More meters");
            driver.WaitForElement(rowValueMIUId, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(rowValueMIUId, "Start Date "))
            {
                testReport.Pass("<i>End date is : <b>" + driver.GetElementText(rowValueMIUId));
            }
            else
            {
                ReporterFactory.LogFailure("Date is not available");
            }
            driver.ClickElement(btnCancel, "Cancel Button");
        }
        public void ValidateConsumptionData(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");
            driver.ClickElement(btnOk, "Ok Button");
            driver.sleepTime(15000);
            driver.WaitForElement(consumptionData, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(consumptionData, "Consumption");
        }
        public void ValidateConsumptionExportToExcel(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");
            driver.ClickElement(btnOk, "Ok Button");
            driver.sleepTime(15000);
            driver.WaitForElement(qabtnExport, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(qabtnExport, "Export");
            driver.CheckElementDisplayed(exportExcel, "Export to Excel");
        }
        public void ValidateConsumptionExportToPDF(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Number");
            driver.ClickElement(btnOk, "Ok Button");
            driver.sleepTime(15000);
            driver.WaitForElement(qabtnExport, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(qabtnExport, "Export");
            driver.CheckElementDisplayed(exportPdf, "Export to PDF");
        }


        /// <summary>
        /// Method to Validate Edit Meter Install No of Dials
        /// </summary>
        public void ValidateMeterInstallNoOfDials(string miuId, string meterInstallDate, string noOfDials)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            // driver.FindElement(drpMeterInstallDate).Click();
            // driver.sleepTime(1000);
            // SimulateSendKeys(meterInstallDate);
            // driver.ClickElement(tabRegister, "Register Tab");
            //driver.ClickElement(drpNoOfDials, "No of dials");
            //driver.ClickElement(By.XPath("//li[contains(@id,'" + "-" + noOfDials + "')]"), "No of dials");
            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(8000);
            // driver.Navigate().Refresh();
            // driver.ClickElement(drpSearch, "Search Account");
            //driver.ClickElement(drpValueMeterId, "Account");
            //driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            // driver.ClickElement(btnSearch, "Search");
            //driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            //driver.ClickElement(rowValueAccountName, "Account Name");
            //driver.ClickElement(btnOk, "OK");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Install Date']//following-sibling::span")));

            driver.CheckElementDisplayed(assetConfigMeterNo1, "Meter Install date");
        }

        /// <summary>
        /// Method to Validate Edit Meter Install No of Dials
        /// </summary>
        public void ValidateMeterInstallDateMultipleEdits(string miuId, string meterClass, string meterSize, string meterManufacturer, string meterInstallDate)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(drpMeterManufacturer, "Meter Manufacturer drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterManufacturer + "')]"), "Select Meter Manufacturer");

            ////driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Class Size value");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(8000);
            // driver.Navigate().Refresh();
            driver.sleepTime(3000);
            // driver.Navigate().Refresh();
            driver.sleepTime(3000);
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNameDailog, "Account Name");
            driver.ClickElement(btnOk, "OK");
            if (driver.CheckElementDisplayed(lblMeterInstallDate, "Meter Install date"))
            {
                testReport.Pass("<i>Meter Intall Date Edit is Successful : <b>" + meterInstallDate);
            }
            else
            {
                ReporterFactory.LogFailure("<i>Meter install date is not successful as : " + meterInstallDate + " Date is : " + driver.GetElementText(lblMeterInstallDate));
            }
        }
        /// <summary>
        /// Method to Validate Register multiple Edits
        /// </summary>
        public void ValidatRegisterMultipleEdits(string miuId, string registerType, string registerInstallDate, string uom, string noOfDials)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpRegisterType, "Meter Register Type");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + registerType + "')]"), "Register Type");
            //driver.FindElement(drpResisterInstalldate).SendKeys(Keys.Clear+registerInstallDate);
            driver.FindElement(drpResisterInstalldate).Click();
            driver.FindElement(drpResisterInstalldate).Click();
            driver.sleepTime(1000);
            SimulateSendKeys(registerInstallDate);
            //SimulateSendKeys(registerInstallDate);
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'(" + uom + "')]"), "Select UOM");
            driver.ClickElement(drpNoOfDials, "No of dials");
            driver.ClickElement(By.XPath("//li[contains(@id,'" + "-" + noOfDials + "')]"), "No of dials");
            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(8000);
            // driver.Navigate().Refresh();
            driver.sleepTime(3000);
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNameDailog, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same as : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("<i>Miu Id is not same as : <b>" + miuId);
            }
        }

        /// <summary>
        /// Method to Validate Register multiple Edits
        /// </summary>
        public void ValidatMeterInfoEditRegisterMultipleEdit(string miuId, string meterClass, string meterSize, string meterManufacturer, string meterInstallDate, string registerType, string registerInstallDate, string uom, string noOfDials)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            //driver.ClickElement(drpMeterClass, "Meter Class Drop Down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Class Size value");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(drpMeterManufacturer, "Meter Manufacturer drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterManufacturer + "')]"), "Select Meter Manufacturer");
            driver.ClickElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input"), "datePicker");
            driver.ClickElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input"), "datePicker");
            driver.FindElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input")).SendKeys(Keys.Control + "A");
            driver.FindElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input")).SendKeys(meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpRegisterType, "Meter Register Type");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + registerType + "')]"), "Meter Register");
            driver.FindElement(drpResisterInstalldate).Click();
            driver.FindElement(drpResisterInstalldate).Click();
            SimulateSendKeys(registerInstallDate);
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + uom + "')]"), "Select UOM");
            driver.ClickElement(drpNoOfDials, "No of dials");
            driver.ClickElement(By.XPath("//li[contains(@id,'" + "-" + noOfDials + "')]"), "No of dials");
            driver.ClickElement(btnSave, "Button Save");
        }

        /// <summary>
        /// Method to Validate Latest Reading
        /// </summary>
        public void ValidateUnitOfMeasure(string accountNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            //driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblUnitMeasure, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure"))
            {
                testReport.Pass("Unit of Measure for Account no : " + accountNo + " is:  <mark>" + driver.GetElementText(lblUnitMeasure));
            }
            else
            {
                ReporterFactory.LogFailure("No Reading found for Account no :" + accountNo);
            }
        }

        /// <summary>
        /// Method to Validate Search Account Details
        /// </summary>
        public void ValidateSearchAccountDetails(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(60));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountName, TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblAccountName, "Account Name"))
            {
                testReport.Pass("Account Information for acc name : " + custName + "is :<mark>" + lblAccountName);
            }
            else
            {
                ReporterFactory.LogFailure("No result");
            }
        }

        /// <summary>
        /// Method to Validate Meter Info
        /// </summary>
        public void ValidateMeterInfromation(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            if (driver.CheckElementDisplayed(meterInformation, "Meter Information"))
            {
                testReport.Pass("Meter Information is displayed for acc name : <mark>" + custName);
            }
            else
            {
                ReporterFactory.LogFailure("No result found for acc name: <mark>" + custName);
            }
        }

        /// <summary>
        /// Method to Validate Meter Info EDit
        /// </summary>
        public void ValidateMeterInfromationEdit(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            if (driver.CheckElementDisplayed(btnEdit, "Edit Button"))
            {
                testReport.Pass("Edit Button is displayed for acc name : <mark>" + custName);
            }
            else
            {
                ReporterFactory.LogFailure("No edit button found for acc name: <mark>" + custName);
            }
        }

        /// <summary>
        /// Method to Validate Asset Configuration
        /// </summary>
        public void ValidateAssetConfiguration(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            //driver.WaitForElement(btnActual,System.TimeSpan.FromSeconds(20));
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            if (driver.CheckElementDisplayed(assetConfiguration, "Asset Configuration"))
            {
                testReport.Pass("Asset Configuration is displayed for acc name : <mark>" + custName);
                driver.ClickElement(btnCancel, "Cancel");
            }
            else
            {
                ReporterFactory.LogFailure("No Asset Configuration found for acc name: <mark>" + custName);
            }
        }

        /// <summary>
        /// Method to Validate MIU Tab
        /// </summary>
        public void ValidateMIUTab(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            //driver.WaitForElement(btnActual,System.TimeSpan.FromSeconds(20));
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            if (driver.CheckElementDisplayed(tabMIU, "MIU Tab"))
            {
                testReport.Pass("MIU Tab is displayed for acc name : <mark>" + custName);
                driver.ClickElement(btnCancel, "Cancel");
            }
            else
            {
                ReporterFactory.LogFailure("No MIU Tab found for acc name: <mark>" + custName);
            }
        }

        /// <summary>
        /// Method to Validate MIU Tab
        /// </summary>
        public void ValidateMeterTab(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            //driver.WaitForElement(grphConsumption, System.TimeSpan.FromSeconds(20));
            //driver.CheckElementDisplayed(grphConsumption, "");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            if (driver.CheckElementDisplayed(tabMeter, "Meter Tab"))
            {
                testReport.Pass("Meter Tab is displayed for acc name : <mark>" + custName);
                driver.ClickElement(btnCancel, "Cancel");
            }
            else
            {
                ReporterFactory.LogFailure("No Meter Tab found for acc name: <mark>" + custName);
            }
        }

        public void ValidateSoftDisconnectTab(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateSoftDisconnectSaveButtonAccess(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.CheckElementDisplayed(btnSave, "Save");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateSoftDisconnectEndDateMandatory(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.sleepTime(15000);
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.sleepTime(2000);
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.CheckElementDisplayed(softDiscEndDate, "End Date");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateSoftDisconnectUncheckedCancelBtn(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.CheckElementDisplayed(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.sleepTime(2000);
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateSoftDisconnectUncheckedEndDate(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.CheckElementDisplayed(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.sleepTime(2000);
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.CheckElementDisplayed(softDiscEndDate, "End Date");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateSoftDisconnectUncheckedSaveBtn(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.sleepTime(2000);
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.CheckElementDisplayed(btnSave, "Save");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateSoftDisconnectClearBtn(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.sleepTime(2000);
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Check Box");
            driver.ClickElement(btnClear, "Clear");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateSoftDisconnectContents(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect CheckBox");
            driver.CheckElementDisplayed(softDiscStartDate, "Start Date");
            driver.CheckElementDisplayed(softDiscEndDate, "End Date");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateSoftDisconnectStartDate(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.CheckElementDisplayed(softDiscStartDate, "Start Date");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateSoftDisconnectEndDate(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "SoftDisconnect Tab");
            driver.ClickElement(softDiscCheckBox, "Soft Disconnect Option");
            driver.CheckElementDisplayed(softDiscEndDate, "End Date");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate MIU Tab
        /// </summary>
        public void ValidateRegisterTab(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            //driver.WaitElementStale(btnEdit);
            //driver.CheckElementDisplayed(grphConsumption, "");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.sleepTime(3000);
            if (driver.CheckElementDisplayed(tabRegister, "Register Tab"))
            {
                testReport.Pass("Register Tab is displayed for acc name : <mark>" + custName);
                driver.ClickElement(btnCancel, "Cancel");
            }
            else
            {
                ReporterFactory.LogFailure("No Register Tab found for acc name: <mark>" + custName);
            }

            // driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter Contents
        /// </summary>
        public void ValidateMeterContents(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            if (driver.CheckElementDisplayed(drpMeterNumber, "Meter Number") & driver.CheckElementDisplayed(drpMeterSize, "Meter Size") & driver.CheckElementDisplayed(drpMeterManufacturer, "Meter Manufacture"))
            {
                testReport.Pass("Meter number is :" + driver.GetElementText(drpMeterNumber).ToString());
                testReport.Pass("<mark>Meter Class Dropdown </mark> is displayed for acc name : <mark>" + custName);
                testReport.Pass("<mark>Meter Size Dropdown </mark>is displayed for acc name : <mark>" + custName);
                testReport.Pass("<mark>Meter Manufacturer dropdown </mark> is diplayed for acc name : <mark>" + custName);
            }
            else
            {
                ReporterFactory.LogFailure("No dropdown found for acc name: <mark>" + custName);
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Register Contents
        /// </summary>
        public void ValidateRegisterContents(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabRegister, "Register Tab");
            if (driver.CheckElementDisplayed(drpRegisterID, "Register ID") & driver.CheckElementDisplayed(drpRegisterType, "Register Type") & driver.CheckElementDisplayed(drpResisterInstalldate, "Install Date") & driver.CheckElementDisplayed(drpUOM, "UOM Details") & driver.CheckElementDisplayed(drpNoOfDials, "No of Dials"))
            {
                testReport.Pass("<mark>Register ID, Register Type, Register Install Date, Register UOM Details, No of Dials </mark> are displayed for acc no :" + custName);

            }
            else
            {
                ReporterFactory.LogFailure("No dropdown found for acc name: <mark>" + custName);
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Edit Cancel
        /// </summary>
        public void ValidateEditCancel(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            //driver.ClickElement(drpMeterClass, "Meter Class Drop Down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Class Size value");
            driver.ClickElement(btnCancel, "Cancel");
            //if (driver.CheckElementDisplayed(lblMeterClass, "Meter Class"))
            //{
            //    testReport.Pass("<mark><i>Meter Class </mark>value not changed for acc name : <b>" + custName);
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("No dropdown found for acc name: <mark>" + custName);
            //}
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
        }

        /// <summary>
        /// Method to Validate Miu Id Non Editable
        /// </summary>
        public void ValidateMiuIdNonEditable(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMIU, "MIU Tab");

            if (driver.CheckElementDisplayed(miuID, "MIU Id"))
            {
                testReport.Pass("MIU Id is Non Editable ");
            }
            else
            {
                ReporterFactory.LogFailure("Editable <mark>");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate MIU Id Editable
        /// </summary>
        public void ValidateMiuEditable(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMIU, "MIU Tab");

            if (driver.CheckElementDisplayed(drpLinkedMiu, "Linked MIU") & driver.CheckElementDisplayed(drpMiuInstalldate, "MIU Install Date") & driver.CheckElementDisplayed(drpMiuFirmware, "MIU Firmware"))
            {
                testReport.Pass("Linked MIU, MIU Install Date, MIu Firmware tabs are Editable ");
            }
            else
            {
                ReporterFactory.LogFailure("Editable <mark>");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Register Tab Editable
        /// </summary>
        public void ValidateRegisterTabEditable(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabRegister, "Register Tab");

            if (driver.CheckElementDisplayed(drpRegisterID, "Register ID") & driver.CheckElementDisplayed(drpRegisterType, "Regiseter Type") & driver.CheckElementDisplayed(drpResisterInstalldate, "Register Install Date") & driver.CheckElementDisplayed(drpUOM, "Regsiter UOM") & driver.CheckElementDisplayed(drpNoOfDials, "No of Dials"))
            {
                testReport.Pass("Register ID, Register Type, Register Install Date, Register UOM, Register no of dials tabs are Editable ");
            }
            else
            {
                ReporterFactory.LogFailure("Editable <mark>");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Register Tab Editable
        /// </summary>
        public void ValidateMeterNumNonEditable(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            if (driver.CheckElementDisplayed(drpMeterNumber, "Meter Number"))
            {
                testReport.Pass("<mark>Meter Number is Non Editable ");
            }
            else
            {
                ReporterFactory.LogFailure("Editable <mark>");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter Information MIU Editable Fields
        /// </summary>
        public void ValidateMeterInfoWithMIUEditableField(string custName, string meterClass, string meterSize, string metermanufacturer, string meterInstallDate)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.CheckElementDisplayed(drpMeterNumber, "Meter Number");
            testReport.Pass("Meter Number is non Editable");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'"+meterClass+"')]"), "Select Meter Class");
            //if(driver.CheckElementDisplayed(drpMeterClass,""))
            //testReport.Pass("Meter Class is Editable ");            
            //else
            //ReporterFactory.LogFailure("Meter Class is uneditable");            
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterSize + "')]"), "Select Meter Size value");
            if (driver.CheckElementDisplayed(drpMeterSize, ""))
                testReport.Pass("Meter Size is editable");
            else
                ReporterFactory.LogFailure("Meter Size is uneditable");
            driver.ClickElement(drpMeterManufacturer, "Meter Manufacturer drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + metermanufacturer + "')]"), "Select Meter Manufacturer");
            if (driver.CheckElementDisplayed(drpMeterManufacturer, "Meter Manufacturer"))
                testReport.Pass("Meter Manufacturer Field is Editable");
            else
                ReporterFactory.LogFailure("Meter Manufacturer Field is Non Editable");
            driver.ClickElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input"), "datePicker");
            driver.ClickElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input"), "datePicker");
            driver.FindElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input")).SendKeys(Keys.Control + "A");
            driver.FindElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input")).SendKeys(meterInstallDate);
            //driver.ClickElement(drpMeterInstallDate, "");
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(btnCancel, "Cancel");
        }


        /// <summary>
        /// Method to Validate Meter Information MIU Editable Fields
        /// </summary>
        public void ValidateMeterInfoWithoutMIUEditableField(string custName, string meterClass, string meterSize, string metermanufacturer, string meterInstallDate)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            //if (driver.CheckElementDisplayed(drpMeterClass, ""))
            //    testReport.Pass("Meter Class is Editable ");
            //else
            //    ReporterFactory.LogFailure("Meter Class is uneditable");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            if (driver.CheckElementDisplayed(drpMeterSize, ""))
                testReport.Pass("Meter Size is editable");
            else
                ReporterFactory.LogFailure("Meter Size is uneditable");
            driver.ClickElement(drpMeterManufacturer, "Meter Manufacturer drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + metermanufacturer + "')]"), "Select Meter Manufacturer");
            if (driver.CheckElementDisplayed(drpMeterManufacturer, "Meter Manufacturer"))
                testReport.Pass("Meter Manufacturer Field is Editable");
            else
                ReporterFactory.LogFailure("Meter Manufacturer Field is Non Editable");
            //driver.ClickElement(drpMeterInstallDate, "");
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input"), "datePicker");
            driver.ClickElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input"), "datePicker");
            driver.FindElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input")).SendKeys(Keys.Control + "A");
            driver.FindElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input")).SendKeys(meterInstallDate);
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate MIU Status on meter information
        /// </summary>
        public void ValidateMIUStatusOnAccount(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            //driver.sleepTime(15000);
            driver.WaitForElement(lblMIUStatus, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblMIUStatus, "MIU Status"))
            {
                testReport.Pass("MIU Status is displayed as: <mark> " + driver.GetElementText(lblMIUStatus));
            }
            else
            {
                ReporterFactory.LogFailure("MIU Status is not Diplayed");
            }
        }
        /// <summary>
        /// Method to Validate Meter Status on meter information
        /// </summary>
        public void ValidateMeterStatusOnAccount(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account No");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            //driver.sleepTime(15000);
            driver.WaitForElement(lblMIUStatus, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblMIUStatus, "Meter Status"))
            {
                testReport.Pass("Meter Status is displayed as: <mark> " + driver.GetElementText(lblMIUStatus));
            }
            else
            {
                ReporterFactory.LogFailure("Meter Status is not Diplayed");
            }
        }

        /// <summary>
        /// Method to Validate Cubic meter Error HPT 5/8
        /// </summary>
        public void ValidateMeterErrorHPT_5_8_Meter(string custName, string meterClass, string meterSize, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + uom + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Cubic meter Error HPT 5/8
        /// </summary>
        public void ValidateMeterErrorHPT_5_8_Feet(string miuId, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error HPT 5/8 Gallons
        /// </summary>
        public void ValidateMeterErrorHPT_5_8_Gallons(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error HPT 3/4 Cubic Feet
        /// </summary>
        public void ValidateMeterErrorHPT_3_4_CFT(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error HPT 3/4 Gallon
        /// </summary>
        public void ValidateMeterErrorHPT_3_4_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error HPT 1 Cubic Meter
        /// </summary>
        public void ValidateMeterErrorHPT_1_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error HPT 1 Cubic Feet
        /// </summary>
        public void ValidateMeterErrorHPT_1_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error HPT 1 Gallons
        /// </summary>
        public void ValidateMeterErrorHPT_1_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 4 Cubic meters
        /// </summary>
        public void ValidateMeterErrorT10_4_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error TP-10 Cubic meters
        /// </summary>
        public void ValidateMeterErrorTP10_3_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 Cubic feet
        /// </summary>
        public void ValidateMeterErrorT10_3_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 3 Gallon
        /// </summary>
        public void ValidateMeterErrorT10_3_Gallon(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 6 Cubic meter error
        public void ValidateMeterErrorT10_6_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 6 Cubic Feet error
        public void ValidateMeterErrorT10_6_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 6 Gallons error
        public void ValidateMeterErrorT10_6_GAL(string custName, string meterClass, string meterSize, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + uom + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 8 Cubic Meter error
        public void ValidateMeterErrorT10_8_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')][2]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 8 Cubic Feet error
        public void ValidateMeterErrorT10_8_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')][2]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 8 Gallons error
        public void ValidateMeterErrorT10_8_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')][2]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 10 Cubic meter error
        public void ValidateMeterErrorT10_10_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 10 Cubic feet error
        public void ValidateMeterErrorT10_10_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 10 Gallons error
        public void ValidateMeterErrorT10_10_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 12 Cubic Meter error
        public void ValidateMeterErrorT10_12_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 12 Cubic feet error
        public void ValidateMeterErrorT10_12_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 12 Gallons
        public void ValidateMeterErrorT10_12_Gallons(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");

            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
            {
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            }
            else
            {
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 12 Cubic Meter
        public void ValidateMeterErrorT10_12_Cubic_Meter(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
                testReport.Pass("Error Message is Displayed:<mark>" + driver.GetElementText(errorMessage));
            else
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 12 Cubic Feet
        public void ValidateMeterErrorT10_12_Cubic_Feet(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
                testReport.Pass("Error Message is Displayed :<mark>" + driver.GetElementText(errorMessage));
            else
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 16 Gallons
        public void ValidateMeterErrorT10_16_Gallon(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
                testReport.Pass("Error Message is Displayed :<mark>" + driver.GetElementText(errorMessage));
            else
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 20 Cubic Meter
        public void ValidateMeterErrorT10_20_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
                testReport.Pass("Error Message is Displayed :<mark>" + driver.GetElementText(errorMessage));
            else
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Error T-10 20 Cubic Feet
        public void ValidateMeterErrorT10_20_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
                testReport.Pass("Error Message is Displayed :<mark>" + driver.GetElementText(errorMessage));
            else
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Error T-10 20 Gallons
        public void ValidateMeterErrorT10_20_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
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
                if (tag[i].Contains(UOM))
                {
                    driver.FindElement(By.XPath("//kendo-popup//span[text()='" + tag[i] + "']")).Click();
                    break;
                }
            }
            if (driver.CheckElementDisplayed(errorMessage, "Error Message"))
                testReport.Pass("Error Message is Displayed :<mark>" + driver.GetElementText(errorMessage));
            else
                ReporterFactory.LogFailure("Error Message is Not Displayed");
            driver.ClickElement(btnCancel, "Cancel");
        }



        /// <summary>
        /// Method to Validate More Meters
        /// </summary>
        public void ValidatMoreMeters(string accountNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.CheckElementDisplayed(moreMeters, "");
            driver.ClickElement(moreMeters, "More Meters");
            //driver.WaitForElement(rowValueAccountName, System.TimeSpan.FromSeconds(10));
            //if (driver.CheckElementDisplayed(rowValueAccountName, "Meter ID"))
            //{
            //    driver.ClickElement(rowValueAccountName, "Meter ID");
            //    testReport.Pass("More Meter details are available for Account No : <mark>" + accountNo);
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("No Meter datails found for Account no :" + accountNo);
            //}
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate More Meters
        /// </summary>
        public void ValidatAccountStatus(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(accStatus, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(accStatus, "Account Status");

        }
        public void ValidatScreenTitleTop()
        {
            driver.CheckElementDisplayed(titleCustomerInquiry, "");
        }
        public void ValidatSearchByField()
        {
            driver.CheckElementDisplayed(txtAccountSearch, "Search By Field");
        }
        public void ValidatAccDataDisplayed(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountName, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(lblAccountName, "Acc Name");
        }

        public void ValidatLogicalDeleteComm(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            // driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnCreateComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDoesnotExists(By.Id("Logical"), "Logical Delete Comment");
        }


        public void ValidatAddComments(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            // driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnCreateComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(btnCreateComment, "Create");
        }
        public void ValidatCannotAddComments(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.CheckElementDoesnotExists(btnCreateComment, "Add Comment");
        }
        public void ValidatAddCommentsAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnCreateComment, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnCreateComment, "Create");
            driver.CheckElementDisplayed(createCommentArea, "Comment Area");
        }
        public void ValidatAddCommentsCancel(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnCreateComment, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnCreateComment, "Create");
            driver.CheckElementDisplayed(By.XPath("//div[@class='customerinquiry-comments-comment-actionbar']//button[2]"), "Comment Cancel");
        }
        public void ValidatAddCommentsCancelAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnCreateComment, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnCreateComment, "Create");
            driver.ClickElement(By.XPath("//div[@class='customerinquiry-comments-comment-actionbar']//button[2]"), "Comment Cancel");
        }
        public void ValidatAddCommentsSaveDisplays(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnCreateComment, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnCreateComment, "Create");
            driver.sleepTime(5000);
            driver.ClickElement(By.XPath("//div[@class='customerinquiry-comments-comment-actionbar']//button[1]"), "Comment Save");
        }

        public void ValidatAddCommentsSuccessToast(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnCreateComment, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnCreateComment, "Create");
            driver.SendKeysToElementClearFirst(createCommentArea, "Create", "");
            driver.ClickElement(By.XPath("//div[@class='customerinquiry-comments-comment-actionbar']//button[1]"), "Comment Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(toastMessage, "Succes Toast Message");
        }
        public void ValidatEditCommentsIconDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            //driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(btnEditComment, "Edit");
        }
        public void ValidatViewComments(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(5000);
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(btnEditComment, "Edit");
        }
        public void ValidatViewMapCommentsDisabled(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(map, TimeSpan.FromSeconds(30));
            driver.CheckElementDoesnotExists(commentSection, "Comment Section");
            driver.CheckElementDisplayed(map, "Map");
        }
        public void ValidatViewCommentDetails(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(5000);
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(commDetails, driver.GetElementText(commDetails));
            driver.GetElementText(commDetails).ToString();
        }
        public void ValidatEditCommentsDisabled(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(5000);
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.CheckElementDoesnotExists(btnEditComment, "Delete");
            //driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));

        }

        public void ValidateAddRegister(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountName2, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName2, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(5000);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(addRegister, "Add Register");
            driver.ClickElement(addRegisterCancel, "Cancel");
            driver.ClickElement(By.XPath("//button[text()='Cancel']"), "Cancel");

        }

        public void ValidateAddRegisterDetails(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.CheckElementDisplayed(addRegister, "Add Register");
            driver.ClickElement(addRegister, "Add Register");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(addRegFinalRead, "Final Read");
            driver.CheckElementDisplayed(addRegBeginningRead, "Beginning Read");
            driver.CheckElementDisplayed(addRegOldRegID, "Old Register ID");
            driver.CheckElementDisplayed(addRegNewRegID, "New Register ID");
            driver.ClickElement(addRegisterCancel, "Cancel");
            driver.ClickElement(By.XPath("//button[text()='Cancel']"), "Cancel");
        }

        public void ValidateAddRegisterCancelBtnDisplays(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.CheckElementDisplayed(addRegister, "Add Register");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.CheckElementDisplayed(addRegister, "Add Register");
            driver.ClickElement(btnEditbutton, "Change Out History");
            driver.ClickElement(addRegisterCancel, "Cancel");
            driver.ClickElement(By.XPath("//button[text()='Cancel']"), "Cancel");
        }

        public void ValidateAddRegisterSaveBtnDisplays(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(addRegister, "Add Register");
            driver.CheckElementDisplayed(addRegisterSave, "Save");
            driver.ClickElement(addRegisterCancel, "Cancel");
            driver.ClickElement(By.XPath("//button[text()='Cancel']"), "Cancel");
        }
        public void ValidateAddRegisterSaveBtnAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(addRegister, "Add Register");
            driver.SendKeysToElement(changeOutDate, "12/02/21", "Date");
            driver.ClickElement(addRegisterSave, "Save");
            driver.ClickElement(By.XPath("//button[text()='Confirm']"), "confirm");
            driver.ClickElement(By.XPath("//button[text()='Cancel']"), "Cancel");
        }

        public void ValidateChangeOutHistoryBtnDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.CheckElementDisplayed(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateChangeOutHistoryAddBtnDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.CheckElementDisplayed(changeOutHistoryAdd, "Add");
            driver.ClickElement(changeOutClose, "Close");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateChangeOutHistoryEditBtnDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.CheckElementDisplayed(changeOutHistoryEdit, "Edit");
            driver.ClickElement(changeOutClose, "Close");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateChangeOutHistoryEditBtnEnabled(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row 1");
            driver.IsElementEnabled(changeOutHistoryEdit, "Edit");
            driver.ClickElement(changeOutClose, "Close");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateChangeOutHistoryEditBtnAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row 1");
            driver.ClickElement(changeOutHistoryEdit, "Edit");
            driver.CheckElementDisplayed(editRegisterChangeOutPage, "Edit Register Page");
            driver.ClickElement(editRegisterCancel, "cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateChangeOutHistoryDeleteBtnAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row 1");
            driver.ClickElement(changeOutHistoryDelete, "Delete");
            driver.CheckElementDisplayed(deleteChangeOutHistoryPage, "Delete Change Out History Page");
            //driver.ClickElement(deleteChangeOutHistoyCancel, "cancel");
            driver.ClickElement(changeOutClose, "");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateChangeOutHistoryDeleteBtnConfirmAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row 1");
            driver.ClickElement(changeOutHistoryDelete, "Delete");
            driver.CheckElementDisplayed(deleteChangeOutHistoryPage, "Delete Change Out History Page");
            driver.CheckElementDisplayed(deleteChangeOutHistoyDelete, "Delete");
            driver.ClickElement(deleteChangeOutHistoyCancel, "Cancel");
            driver.ClickElement(changeOutClose, "");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateChangeOutHistoryDeleteConfirmDialog(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row 1");
            driver.ClickElement(changeOutHistoryDelete, "Delete");
            driver.CheckElementDisplayed(deleteChangeOutHistoryPage, "Delete Change Out History Page");
            driver.CheckElementDisplayed(deleteChangeOutConfirmation, "Delete Confirmation Dialog");
            driver.ClickElement(deleteChangeOutHistoyCancel, "Cancel");
            driver.ClickElement(changeOutClose, "");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateChangeOutHistoryDeleteConfirmation(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row 1");
            driver.ClickElement(changeOutHistoryDelete, "Delete");
            driver.CheckElementDisplayed(deleteChangeOutHistoryPage, "Delete Change Out History Page");
            driver.ClickElement(deleteChangeOutHistoyDelete, "Delete Confirmation ");
            driver.ClickElement(deleteChangeOutHistoyCancel, "Cancel");
            driver.ClickElement(changeOutClose, "");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateChangeOutHistoryEditRegisterSave(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row 1");
            driver.ClickElement(changeOutHistoryEdit, "Edit");
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
            driver.ClickElement(By.XPath("//span[text()='Change Out Date']/..//button"), "date");
            driver.ClickElement(By.XPath("//span[text()='Change Out Date']/..//kendo-dateinput//input"), "date");
            driver.SendKeysToElement(By.XPath("//span[text()='Change Out Date']/..//kendo-dateinput//input"), Keys.Control + "A", "date");
            driver.SendKeysToElement(By.XPath("//span[text()='Change Out Date']/..//kendo-dateinput//input"), "08/11/2022", "date");
            driver.SendKeysToElement(addRegNewRegID, "2", "New Register ID");
            driver.ClickElement(editRegisterSave, "Save");
            driver.ClickElement(editRegisterConfirm, "Confirm");
            driver.ClickElement(changeOutAuditLogBtn, "Change Out Audot Log");
            driver.CheckElementDisplayed(changeOutAuditLogPage, "changeOutAuditLogPage");
            driver.ClickElement(changeOutClose, "Close");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateChangeOutHistoryInstallDateBehavior(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            string s = driver.GetElementText(changeOutHistoryRow);
            testReport.Info("Change Out Date is : " + s);
            driver.ClickElement(changeOutClose, "Close");
            testReport.Info("Register Install Date : " + driver.GetElementText(drpResisterInstalldate));
            driver.ClickElement(btnCancel, "");
        }

        public void ValidateChangeOutHistoryEditFinalRead(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row");
            driver.ClickElement(changeOutHistoryEdit, "Edit");

            driver.SendKeysToElementClearFirst(addRegFinalRead, "1", "Final Read");
            driver.ClickElement(editRegisterCancel, "Cancel");
            driver.ClickElement(btnCancel, "");
        }

        public void ValidateChangeOutHistoryEditConfirmation(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row");
            driver.ClickElement(changeOutHistoryEdit, "Edit");

            driver.SendKeysToElementClearFirst(addRegFinalRead, "1000000", "Final Read");
            driver.ClickElement(editRegisterSave, "Save");
            driver.CheckElementDisplayed(editRegisterConfirm, "Confirmation Dialog");
            driver.ClickElement(editRegisterCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateChangeOutDateDisabled(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row");
            driver.ClickElement(changeOutHistoryEdit, "Edit");

            driver.CheckElementDisplayed(changeOutDate, "Change OUt Date");
            driver.ClickElement(editRegisterCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateChangeOutDateInvalidDate(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change out History");
            driver.ClickElement(changeOutHistoryAdd, "Add");
            driver.ClickElement(editRegisterSave, "Save");

            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info(driver.GetElementText(toastMessage));
            driver.ClickElement(editRegisterCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCommentSection(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(commentSection, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(commentSection, "Comment Section");

        }


        public void ValidateChangeOutHistoryEditChangeOutDate(string miuId)

        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.ClickElement(changeOutHistoryRow, "Row");
            driver.CheckElementDisplayed(changeOutDate, "Change Out Date");
            driver.ClickElement(btnEditbutton, "Edit");
            driver.ClickElement(editRegisterCancel, "Cancel");
            driver.ClickElement(btnCancel, "");
        }
        public void ValidateChangeOutHistoryDeleteBtnDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutHistoryBtn, "Change Out History");
            driver.CheckElementDisplayed(changeOutHistoryDelete, "Delete");
            driver.ClickElement(changeOutClose, "Close");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateChangeOutAuditLogBtnDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.CheckElementDisplayed(changeOutAuditLogBtn, "Change Out Audit Log");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateChangeOutAuditLogPageDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutAuditLogBtn, "Change Out Audit Log");
            driver.CheckElementDisplayed(changeOutAuditLogPage, "changeOutAuditLogPage");
            driver.ClickElement(changeOutClose, "Close");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateChangeOutAuditLogColumns(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(changeOutAuditLogBtn, "Change Out Audit Log");
            driver.CheckElementDisplayed(typeCol, "Type");
            driver.CheckElementDisplayed(changeOutDateCol, "Date");
            driver.CheckElementDisplayed(oldRegisterCol, "Old Register Id");
            driver.CheckElementDisplayed(newRegisterCol, "New Register Id");
            driver.CheckElementDisplayed(userCol, "User");
            driver.CheckElementDisplayed(timeStampCol, "Time Stamp");
            driver.ClickElement(changeOutClose, "Close");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateAddRegisterDefaultDate(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.sleepTime(5000);
            driver.ClickElement(addRegister, "Add Register");

            driver.CheckElementDisplayed(changeOutDate, "Change Out Date");
            driver.ClickElement(addRegisterCancel, "Cancel");
            driver.ClickElement(By.XPath("//button[text()='Cancel']"), "Cancel");
        }

        public void ValidatEditCommentsIconAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            //driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            //Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            //driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(btnEditComment, "Edit");
            driver.ClickElement(btnEditComment, "Edit");
        }
        public void ValidatEditCommentsButtonDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            //driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            //driver.CheckElementDisplayed(btnEditComment, "Edit");
            driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnEditComment, "Edit");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(By.XPath("//div[contains(@class,'customerinquiry-comments-comment-actionbar')]//button[1]"), "Comment Save");
            driver.CheckElementDisplayed(By.XPath("//div[contains(@class,'customerinquiry-comments-comment-actionbar')]//button[2]"), "Cancel");
        }
        public void ValidatEditCommentsCancelButtonAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.ClickElement(btnEditComment, "Edit");
            driver.CheckElementDisplayed(By.XPath("//div[contains(@class,'customerinquiry-comments-comment-actionbar')]//button[1]"), "Comment Save");
            driver.CheckElementDisplayed(By.XPath("//div[contains(@class,'customerinquiry-comments-comment-actionbar')]//button[2]"), "Cancel");
        }
        public void ValidatEditCommentsSaveButtonAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.ClickElement(btnEditComment, "Edit");
            driver.ClickElement(By.XPath("//div[contains(@class,'customerinquiry-comments-comment-actionbar')]//button[1]"), "Comment Save");
        }
        public void ValidatDeleteCommentsIconDisplay(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("(//span[@class='customerinquiry-comments-content-author'])[1]"))).Build().Perform();
            driver.WaitForElement(btnDeleteComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(btnDeleteComment, "Delete");
        }
        public void ValidatDeleteCommentsIconAccess(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.WaitForElement(btnDeleteComment, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnDeleteComment, "Delete");
            driver.ClickElement(btnNo, "");
        }
        public void ValidatDeleteCommentsDisabled(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.CheckElementDoesnotExists(btnDeleteComment, "Delete");
        }
        public void ValidatDeleteCommentsConfirmation(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.WaitForElement(btnDeleteComment, TimeSpan.FromMinutes(1));
            //       driver.WaitForElement(btnDeleteComment, TimeSpan.FromMinutes(1)); 
            //Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("(//span[@class='customerinquiry-comments-content-author'])[1]"))).Build().Perform();
            driver.WaitForElement(btnDeleteComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(btnDeleteComment, "Delete");
            driver.ClickElement(btnDeleteComment, "Delete");
            driver.CheckElementDisplayed(deleteConfirmation, "Confirmation");
            driver.ClickElement(btnNo, "");
        }

        public void ValidatDeleteCommentsConfirmationYes(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.WaitForElement(btnDeleteComment, TimeSpan.FromMinutes(1));
            //Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("(//span[@class='customerinquiry-comments-content-author'])[1]"))).Build().Perform();
            driver.WaitForElement(btnDeleteComment, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(btnDeleteComment, "Delete");
            driver.ClickElement(btnDeleteComment, "Delete");
            driver.CheckElementDisplayed(deleteConfirmation, "Confirmation");
            driver.ClickElement(btnYes, "");
        }
        public void ValidatDeleteCommentsConfirmationSuccessToast(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.WaitForElement(btnDeleteComment, TimeSpan.FromMinutes(1));
            //Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("(//span[@class='customerinquiry-comments-content-author'])[1]"))).Build().Perform();
            driver.ClickElement(btnDeleteComment, "Delete");
            driver.CheckElementDisplayed(deleteConfirmation, "Confirmation");
            driver.ClickElement(btnYes, "");
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage).ToString());
        }
        public void ValidatDeleteIconNotDisplayed(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.CheckElementDoesnotExists(btnDeleteComment, "Delete");
        }
        public void ValidatEditCommentsDetailsSave(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.XPath("//span[@class='customerinquiry-comments-content-author']"))).Build().Perform();
            driver.WaitForElement(btnEditComment, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnEditComment, "Edit");
            driver.SendKeysToElementClearFirst(createCommentArea, "Edit", "Edit");
            driver.ClickElement(By.XPath("//div[contains(@class,'customerinquiry-comments-comment-actionbar')]//button[1]"), "Comment Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage).ToString());
        }


        /// <summary>
        /// Method to Validate More Meters
        /// </summary>
        public void ValidatAccountStatusActive(string miuId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblAccountStatus, "Account Status "))
            {
                testReport.Pass("<i>Account Status Displayed for MiuId: " + miuId + " should be <b>Active</b></i> Output is : <mark><b>" + driver.GetElementText(lblAccountStatus).Equals("Active"));
            }
            else
            {
                ReporterFactory.LogFailure("Account Status not Displayed for Miu Id: <mark>" + miuId);
            }

        }
        /// <summary>
        /// Method to Validate More Meters
        /// </summary>
        public void ValidatAccountStatusInactive(string miuId)
        {
            /* driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
             driver.SendKeysToElementAndPressEnter(utilitySearch, "SQA", "Utility");
             driver.ClickElement(tblChooseUtilities, "Select");
             driver.ClickElement(btnChooseUtilitiesOk, "OK");*/
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(lblAccountStatus, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblAccountStatus, "Account Status");
            if (driver.GetElementText(lblAccountStatus).Equals("Inactive"))
                testReport.Pass("<i><b>Account Status is Inactive");
            else
                ReporterFactory.LogFailure("<i><b>Account Status is Active");
        }

        /// <summary>
        /// Method to Validate HPT 1 1/2 Cubic meter save
        /// /// </summary>
        public void ValidateMeterSaveHPT_1_1_2_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            ////driver.ClickElement(drpMeterClass, "Meter Class drop down");
            ////driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            //driver.Navigate().Refresh();
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            ////driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) && driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 1 1/2 Cubic Feet save
        /// /// </summary>
        public void ValidateMeterSaveHPT_1_1_2_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            ////driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 1 1/2 Gallon saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_1_1_2_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            ////driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }


        /// <summary>
        /// Method to Validate HPT 2 Cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_2_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            ////driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 2 Cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_2_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')][2]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 2 Gallon saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_2_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 3 Cubic Meter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_3_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 3 Cubic Feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_3_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 3 Gallons saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_3_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 4 Cubic MEter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_4_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')][2]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 4 Cubic Feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_4_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 4 Gallon saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_4_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[7]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)) & driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 6 cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_6_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[8]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate HPT 6 cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_6_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[8]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 6 gallons saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_6_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[8]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("Asset Configuration has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate HPT 8 cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_8_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[9]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 8 cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_8_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[9]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b><u>Asset Configuration</b></u> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate HPT 8 Gallons saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_8_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[9]"), "Select Meter Size value");//contains(@id,'-" + meterSize + "')
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b><u>Asset Configuration</b></u> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate HPT 10 Cubic Meter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_10_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b><u>Asset Configuration</b></u> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate HPT 10 Cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_10_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b><u>Asset Configuration</b></u> has been Updated" + driver.GetElementText(lblMeterSize) + driver.GetElementText(lblUnitMeasure));
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved" + driver.GetElementText(lblMeterSize) + driver.GetElementText(lblUnitMeasure));
            }
        }

        /// <summary>
        /// Method to Validate HPT 10 Cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_12_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate HPT 10 Cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_12_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate HPT 12 Gallon saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_12_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 16 cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_16_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate HPT 16 cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_16_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 16 gallon saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_16_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }

        }
        /// <summary>
        /// Method to Validate HPT 20 cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_20_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }

        }
        /// <summary>
        /// Method to Validate HPT 20 cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_20_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }

        }
        /// <summary>
        /// Method to Validate T10 5/8 cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveT10_5_10_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate T10 5/8 cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveT10_5_10_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate T10 5/8 Gallon saved
        /// /// </summary>
        public void ValidateMeterSaveT10_5_10_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 3/4 Cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveT10_3_4_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate T10 3/4 Cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveT10_3_4_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate T10 3/4 Gallon saved
        /// /// </summary>
        public void ValidateMeterSaveT10_3_4_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 1 cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveT10_1_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 1 cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveT10_1_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 1 gallon saved
        /// /// </summary>
        public void ValidateMeterSaveT10_1_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 1 1/2 cubic meter saved
        /// /// </summary>
        public void ValidateMeterSaveT10_1_1_2_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 1 1/2 cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveT10_1_1_2_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 1 1/2 gallon saved
        /// /// </summary>
        public void ValidateMeterSaveT10_1_1_2_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 2 cucib meter saved
        /// /// </summary>
        public void ValidateMeterSaveT10_2_CM3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 2 gallon saved
        /// /// </summary>
        public void ValidateMeterSaveT10_2_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')][2]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 2 cucib feet saved
        /// /// </summary>
        public void ValidateMeterSaveT10_2_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 4 cubic feet saved
        /// /// </summary>
        public void ValidateMeterSaveT10_4_CF3(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[7]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }
        /// <summary>
        /// Method to Validate T10 4 gallon saved
        /// /// </summary>
        public void ValidateMeterSaveT10_4_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//div/ul/li[7]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }

        /// <summary>
        /// Method to Validate Meter class displays
        /// /// </summary>
        public void ValidateMeterClassDisplays(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //if (driver.CheckElementDisplayed(drpMeterClass,"Meter Class"))
            //{
            //    testReport.Pass("<i><b>Meter Class</b> is displayed");
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i><b>Meter Class </b>is not displayed");
            //}
            driver.ClickElement(btnCancel, "Cancel");

        }
        /// <summary>
        /// Method to Validate Meter class displays HPT
        /// /// </summary>
        public void ValidateMeterClassDisplaysHPT(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter class");
            //if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            //{
            //    testReport.Pass("<i><b>Meter Class </b> displayed is : "+meterClass);

            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i><b>Meter Class HPT</b>is not displayed");
            //}
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays T10
        /// /// </summary>
        public void ValidateMeterClassDisplaysT10(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter class");
            //if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            //{
            //    testReport.Pass("<i><b>Meter Class </b> displayed is : " + meterClass);
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i><b>Meter Class HPT</b>is not displayed");
            //}

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays Mach 10
        /// /// </summary>
        public void ValidateMeterClassDisplaysMach10(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter class");
            //if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            //{
            //    testReport.Pass("<i><b>Meter Class </b> displayed is : " + meterClass);
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i><b>Meter Class HPT</b>is not displayed");
            //}
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays TFL
        /// /// </summary>
        public void ValidateMeterClassDisplaysTFL(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter class");
            //if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            //{
            //    testReport.Pass("<i><b>Meter Class </b> displayed is : <b> " + meterClass);
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i><b>Meter Class is not displayed");
            //}
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays FPFST
        /// /// </summary>
        public void ValidateMeterClassDisplaysHPFST(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class displayed is :<b> " + meterClass);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays FHP PIII
        /// /// </summary>
        public void ValidateMeterClassDisplaysHPPIII(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter class");
            //if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            //{
            //    testReport.Pass("<i>Meter Class displayed is :<b> " + meterClass);
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i><b>Meter Class </b>is not displayed");
            //}

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays RFS
        /// /// </summary>
        public void ValidateMeterClassDisplaysRFS(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter class");
            //if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            //{
            //    testReport.Pass("<i>Meter Class "+meterClass+" is not displayed ");
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            //}

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays T8
        /// /// </summary>
        public void ValidateMeterClassDisplaysT8(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter class");
            //if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            //{
            //    testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            //}

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter class displays TT
        /// /// </summary>
        public void ValidateMeterClassDisplaysTT(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays P III
        /// /// </summary>
        public void ValidateMeterClassDisplaysPIII(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays smag
        /// /// </summary>
        public void ValidateMeterClassDisplaysSmag(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter class displays S Ultra
        /// /// </summary>
        public void ValidateMeterClassDisplaysSUltra(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays PD
        /// /// </summary>
        public void ValidateMeterClassDisplaysPD(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays Leak spy
        /// /// </summary>
        public void ValidateMeterClassDisplaysLeakSpy(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class");
            driver.ClickElement(btnCancel, "Cancel");

        }
        /// <summary>
        /// Method to Validate Meter class displays Permalog
        /// /// </summary>
        public void ValidateMeterClassDisplaysPermalog(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");

            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays Pressure
        /// /// </summary>
        public void ValidateMeterClassDisplaysPressure(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");

            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter class displays s Fluidic
        /// /// </summary>
        public void ValidateMeterClassDisplaysSFluidic(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");

            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }


        /// <summary>
        /// Method to Validate Meter class displays sub t10
        /// /// </summary>
        public void ValidateMeterClassDisplaysSubT10(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter class displays backflow
        /// /// </summary>
        public void ValidateMeterClassDisplaysBackflow(string custName, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterClass, "Meter class");
            if (driver.CheckElementDoesnotExists(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class"))
            {
                testReport.Pass("<i>Meter Class " + meterClass + " is not displayed ");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }


        /// <summary>
        /// Method to Validate Meter Size displays 1 1/2
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList1_1_2(string custName, string meterSize)
        {
            //columnHeader accountStatusColumnIndex = driver.Findelement(By.Xpath(//th[text()='Account Status']).GetAttribute("aria-colindex");
            //var AcocountStatusValues = driver.FindElement(By.XPath("//td[@aria-colindex='"+accountStatusColumnIndex+"']);
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(60));

            driver.WaitForElement(btnOk, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(btnEdit, System.TimeSpan.FromSeconds(60));

            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");

            driver.ClickElement(drpMeterSize, "Meter Size");
            driver.CheckElementDisplayed(By.XPath("//kendo-popup//ul//li[@role='option']//span[contains(text(),'" + meterSize + "')]"), "metersize");


            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter Size displays 2
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_2(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')][2]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter Size displays 3
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_3(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter Size displays 4
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_4(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Class </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter Size displays 6
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_6(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            driver.sleepTime(1000);
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter Size displays 8
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_8(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            driver.sleepTime(1000);
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");

            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter Size displays 10
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_10(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter Size displays 12
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_12(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter Size displays 16
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_16(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Meter Size displays 20
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_20(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter Size displays 5/8
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_5_8(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateMeterSizeCoreValue5_8(string custName, string meterSize)
        {
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.sleepTime(5000);
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMeterSize, TimeSpan.FromSeconds(20000));
            driver.CheckElementDisplayed(lblMeterSize, driver.GetElementText(lblMeterSize));
            if (driver.GetElementText(lblMeterSize).Contains(meterSize))
            {
                testReport.Pass("Meter Size Vale is 5/8");
            }
            else
            {
                testReport.Fail("Meter Size value is : " + driver.GetElementText(lblMeterSize));
                Assert.Fail("Meter Size value is : " + driver.GetElementText(lblMeterSize) + " " + "But expected metersize is" + meterSize);
            }
        }

        /// <summary>
        /// Method to Validate Meter Size displays 3/4
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_3_4(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Meter Size displays 1
        /// /// </summary>
        public void ValidateMeterSizeDisplaysList_1(string custName, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            if (driver.CheckElementDisplayed(By.XPath("//*[contains(@id,'" + meterSize + "')]"), "Meter Size"))
            {
                testReport.Pass("<i>Meter Size displayed is :<b> " + meterSize);
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Meter Size </b>is not displayed");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate Default Unit Of Measure is Gallon
        /// /// </summary>
        public void ValidateDefaultUOMGallon(string custName, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(5000);
            //driver.WaitForPageLoad(System.TimeSpan.FromSeconds(20));
            if (driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(uom)))
            {
                testReport.Pass("Unit of measure is : " + uom);
                driver.CheckElementDisplayed(lblUnitMeasure, "");
            }
            else
            {
                ReporterFactory.LogFailure("Unit of measure is not :" + uom);
            }
        }

        public void ValidateMeterType(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(5000);
            driver.WaitForElement(meterType, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(meterType, "Meter Type");
        }
        /// <summary>
        /// Method to Validate Edit Meter Class and save access
        /// /// </summary>
        public void ValidateEditMeterClassSave(string miuId, string meterClass)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            //driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            //driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            // driver.ClickElement(btnEdit, "Edit Button");
            // driver.ClickElement(tabMeter, "Meter Tab");
            //driver.ClickElement(drpMeterClass, "Meter Class");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class");
            //driver.ClickElement(btnSave, "Save");
            //driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            //driver.sleepTime(5000);
            driver.CheckElementDisplayed(lblMiuID, "Miu ID");
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }
        /// <summary>
        /// Method to Validate Edit Meter Size and save access
        /// /// </summary>
        public void ValidateEditMeterSizeSave(string miuId, string meterSize)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            //driver.ClickElement(By.XPath("//kendo-popup//span[contains(text(),'" + meterSize + "')]"),"select meter size");
            driver.ClickElement(By.XPath("//kendo-popup//span[contains(text(),'" + meterSize + "')]"), "select meter size");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(lblMiuID, "Miu ID");
            driver.WaitForElement(drpSearchCustAccount, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter Manufacturer and save access
        /// /// </summary>
        public void ValidateEditMeterManufacturerSave(string miuId, string meterManufacturer)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            driver.ClickElement(drpMeterManufacturer, "Meter Manufacturer");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterManufacturer + "')]"), "Meter Manufacturer");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            //driver.CheckElementDisplayed(lblMiuID, "Miu ID");
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }
        /// <summary>
        /// Method to Validate Edit Meter Register Type and save access
        /// /// </summary>
        public void ValidateEditMeterRegisterTypeSave(string miuId, string meterRegister)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpRegisterType, "Meter Register Type");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterRegister + "')]"), "Meter Register");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter UOM and save access
        /// /// </summary>
        public void ValidateEditMeterUOMSave(string miuId, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Meter/MIU id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(rowValueMIUId, System.TimeSpan.FromSeconds(60));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "Meter Register Type");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + uom + "')]"), "Unit Of measurement");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            // driver.Navigate().Refresh();
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Meter/MIU id");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter No of dials and save access
        /// /// </summary>
        public void ValidateEditMeterNoOfDials(string miuId, string noOfDials)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpNoOfDials, "No of dials");
            driver.ClickElement(By.XPath("//li[contains(@id,'" + "-" + noOfDials + "')]"), "No of dials");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            // driver.Navigate().Refresh();
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter Class Register Type
        /// /// </summary>
        public void ValidateEditMeterClassRegisterType(string miuId, string meterClass, string registerType)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            //driver.ClickElement(tabMeter, "Meter Tab");
            //driver.ClickElement(drpMeterClass, "Meter Class");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpRegisterType, "Register Type");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + registerType + "')]"), "Register Type");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            // driver.Navigate().Refresh();
            // driver.Navigate().Refresh();
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.GetElementText(lblMiuID).Equals(miuId))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }
        /// <summary>
        /// Method to Validate Edit Meter Size Register UOM
        /// /// </summary>
        public void ValidateEditMeterSizeRegisterUOM(string miuId, string meterSize, string registerUOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            driver.ClickElement(drpMeterSize, "Meter Size");
            driver.ClickElement(By.XPath("//kendo-popup//span[contains(text(),'" + meterSize + "')]"), "select meter size");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "Register Type");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + registerUOM + "')]"), "Register UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(15000);
            /*driver.Navigate().Refresh();
            driver.sleepTime(5000);
            driver.Navigate().Refresh();
            driver.sleepTime(5000);
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);*/
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter Class No of Dials
        /// /// </summary>
        public void ValidateEditMeterClassNoOfDials(string miuId, string meterClass, string noOfDials)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            //driver.ClickElement(drpMeterClass, "Meter Class");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Meter Class");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpNoOfDials, "No of dials");
            driver.ClickElement(By.XPath("//li[contains(@id,'" + "-" + noOfDials + "')]"), "No of dials");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter manufacturer and register type
        /// /// </summary>
        public void ValidateEditMeterManufacturerRegisterType(string miuId, string meterManufacturer, string registerType)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            driver.ClickElement(drpMeterManufacturer, "Meter Class");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterManufacturer + "')]"), "Meter Manufacturer");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpRegisterType, "Register Type");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + registerType + "')]"), "Register Type");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter manufacturer and register install date
        /// /// </summary>
        public void ValidateEditMeterManufacturerRegisterInstallDate(string miuId, string meterManufacturer, string registerInstallDate)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            driver.ClickElement(drpMeterManufacturer, "Meter Class");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterManufacturer + "')]"), "Meter Manufacturer");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.FindElement(drpResisterInstalldate).Click();
            driver.FindElement(drpResisterInstalldate).Click();
            SimulateSendKeys(registerInstallDate);
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.GetElementText(lblMiuID).Equals(miuId))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }
        /// <summary>
        /// Method to Validate Edit Meter manufacturer and register uom
        /// /// </summary>
        public void ValidateEditMeterManufacturerRegisterUOM(string miuId, string meterManufacturer, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            driver.ClickElement(drpMeterManufacturer, "Meter Class");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterManufacturer + "')]"), "Meter Manufacturer");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "Unit Of Measurement");
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
                }
            }
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(5000);
            // driver.Navigate().Refresh();
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter manufacturer and no of dials
        /// /// </summary>
        public void ValidateEditMeterManufacturerNoOfDials(string miuId, string meterManufacturer, string noOfDials)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            driver.ClickElement(drpMeterManufacturer, "Meter Class");
            driver.ClickElement(By.XPath("//*[contains(@id,'" + meterManufacturer + "')]"), "Meter Manufacturer");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpNoOfDials, "No of dials");
            driver.ClickElement(By.XPath("//li[contains(@id,'" + "-" + noOfDials + "')]"), "No of dials");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(7000);

            driver.ClickElement(drpSearch, "Search Account");
            if (driver.VerifyDoesnotExists(drpValueMeterId, "serach"))
            {
                // driver.Navigate().Refresh();
                driver.sleepTime(5000);

            }
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }
        /// <summary>
        /// Method to Validate unit of measurement as cubic feet
        /// /// </summary>
        public void ValidateUnitOfMeasureCF3(string accNo, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            //driver.ClickElement(tabMeter, "MeterTab");
            //driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.sleepTime(1000);
            driver.ClickElement(drpUOM, "UOM");
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
                }
            }
            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(8000);
            //driver.Navigate().Refresh();
            //driver.sleepTime(3000);
            /*driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account Number ");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblAccountNo, System.TimeSpan.FromSeconds(20));*/
            if (driver.GetElementText(lblUnitMeasure).Contains(uom))
            {
                testReport.Pass("<i>Unit of Measurement is  : <b>" + uom);
            }
            else
            {
                ReporterFactory.LogFailure("Unit of measuremnt is : " + driver.GetElementText(lblUnitMeasure));
            }








        }
        /// <summary>
        /// Method to Validate unit of measurement as cubic meter
        /// /// </summary>
        public void ValidateUnitOfMeasureCM3(string accNo, string uom)
        {
            driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.sleepTime(5000);
            if (!driver.CheckElementDisplayed(By.XPath("//kendo-grid[@id='accountsGrid']//kendo-grid-list//tr[2]/td[1]"), "rowno1"))
            {
                driver.Navigate().Refresh();
                driver.ClickElement(drpSearch, "Search Account");
                driver.ClickElement(drpValueAccountNo, "Account");
                driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
                driver.ClickElement(btnSearch, "Search");
                driver.sleepTime(5000);
            }
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");


            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            //driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");

            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "Unit Of Measurement");
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
                }
            }

            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(15000);
            //driver.Navigate().Refresh();
            /*driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account Number ");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblAccountNo, System.TimeSpan.FromSeconds(20));*/
            if (driver.GetElementText(lblUnitMeasure).Contains(uom))
            {
                testReport.Pass("<i>Unit of Measurement is  : <b>" + uom);
            }
            else
            {
                ReporterFactory.LogFailure("Unit of measuremnt is : " + driver.GetElementText(lblUnitMeasure));
            }
        }
        /// <summary>
        /// Method to Validate unit of measurement as gallons
        /// /// </summary>
        public void ValidateUnitOfMeasureGAL(string accNo, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            //driver.ClickElement(tabMeter, "MeterTab");
            //driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
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

            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(15000);
            /*driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account Number ");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblAccountNo, System.TimeSpan.FromSeconds(20));*/
            if (driver.GetElementText(lblUnitMeasure).Contains(uom))
            {
                testReport.Pass("<i>Unit of Measurement is  : <b>" + uom);
            }
            else
            {
                ReporterFactory.LogFailure("Unit of measuremnt is : " + driver.GetElementText(lblUnitMeasure));
            }
        }
        /// <summary>
        /// Method to Validate unit of measurement as liters
        /// /// </summary>
        public void ValidateUnitOfMeasureLiters(string accNo, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            //driver.ClickElement(tabMeter, "MeterTab");
            //driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
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

            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(15000);
            /*driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account Number ");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblAccountNo, System.TimeSpan.FromSeconds(20));*/
            if (driver.GetElementText(lblUnitMeasure).Contains(uom))
            {
                testReport.Pass("<i>Unit of Measurement is  : <b>" + uom);
            }
            else
            {
                ReporterFactory.LogFailure("Unit of measuremnt is : " + driver.GetElementText(lblUnitMeasure));
            }
        }
        /// <summary>
        /// Method to Validate unit of measurement as gallons
        /// /// </summary>
        public void ValidateUnitOfMeasureIPG(string accNo, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            //driver.ClickElement(tabMeter, "MeterTab");
            //driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
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
            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(15000);
            /*driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account Number ");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblAccountNo, System.TimeSpan.FromSeconds(20));*/
            if (driver.GetElementText(lblUnitMeasure).Contains(uom))
            {
                testReport.Pass("<i>Unit of Measurement is  : <b>" + uom);
            }
            else
            {
                ReporterFactory.LogFailure("Unit of measuremnt is : " + driver.GetElementText(lblUnitMeasure));
            }
        }
        /// <summary>
        /// Method to Validate multiple unit of measurement
        /// /// </summary>
        public void ValidateMultipleUnitOfMeasure(string accNo, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            //driver.ClickElement(tabMeter, "MeterTab");
            //driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
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

            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(15000);
            /*driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account Number ");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblAccountNo, System.TimeSpan.FromSeconds(20));*/
            if (driver.GetElementText(lblUnitMeasure).Contains(uom))
            {
                testReport.Pass("<i>Unit of Measurement is  : <b>" + uom);
            }
            else
            {
                ReporterFactory.LogFailure("Unit of measuremnt is : " + driver.GetElementText(lblUnitMeasure));
            }
        }
        /// <summary>
        /// Method to Validate defalut unit of measurement
        /// /// </summary>
        public void ValidateDefaultUnitOfMeasure(string accNo, string uom)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.sleepTime(8000);
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            //driver.ClickElement(tabMeter, "MeterTab");
            //driver.FindElement(drpMeterInstallDate).SendKeys(Keys.Clear + meterInstallDate);
            //driver.FindElement(drpMeterInstallDate).Click();
            //driver.sleepTime(1000);
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
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

            driver.ClickElement(btnSave, "Save Button");
            driver.sleepTime(15000);
            /*driver.ClickElement(drpSearch, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account Number ");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(15000);
            driver.WaitForElement(lblAccountNo, System.TimeSpan.FromSeconds(20));*/
            if (driver.GetElementText(lblUnitMeasure).Contains(uom))
            {
                testReport.Pass("<i>Unit of Measurement is  : <b>" + uom);
            }
            else
            {
                ReporterFactory.LogFailure("Unit of measuremnt is : " + driver.GetElementText(lblUnitMeasure));
            }
        }

        /// <summary>
        /// Method to Validate Edit Meter Install Date and save access
        /// /// </summary>
        public void ValidateEditMeterInstallDate(string miuId, string meterInstallDate)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(60));
            driver.WaitForElement(rowValueMIUId, System.TimeSpan.FromSeconds(60));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.WaitElementExistsAndVisible(btnEdit);
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "Meter Tab");
            //driver.ClickElement(drpMeterInstallDate, "Meter Install Date");
            //driver.ClickElement(drpMeterInstallDate, "Meter Install Date");
            //SimulateSendKeys(meterInstallDate);
            driver.ClickElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input"), "datePicker");
            driver.ClickElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input"), "datePicker");
            driver.FindElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input")).SendKeys(Keys.Control + "A");
            driver.FindElement(By.XPath("//span[text()='Install Date']/..//kendo-dateinput//input")).SendKeys(meterInstallDate);
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(9000);
            // driver.Navigate().Refresh();
            driver.sleepTime(5000);
            if (driver.VerifyDoesnotExists(lblMiuID, "muid"))
            {
                // driver.Navigate().Refresh();
            }
            driver.WaitForElement(lblMiuID, System.TimeSpan.FromSeconds(60));

            driver.CheckElementDisplayed(lblMiuID, "Miu ID");
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            if (driver.CheckElementDisplayed(lblMiuID, "Miu Id"))
            {
                testReport.Pass("<i>Miu Id is same : <b>" + miuId);
            }
            else
            {
                ReporterFactory.LogFailure("Miu Id does not matches");
            }
        }
        /// <summary>
        /// Method to Validate Edit Register Install Date and save access
        /// /// </summary>
        public void ValidateEditRegisterInstallDate(string miuId, string registerInstallDate)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, miuId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.WaitElementExistsAndVisible(btnEdit);
            driver.CheckElementDisplayed(lblMiuID, "Miu Id ");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.FindElement(drpResisterInstalldate).Click();
            driver.FindElement(drpResisterInstalldate).Click();
            SimulateSendKeys(registerInstallDate);
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(toastMessage, ""))
            {
                testReport.Pass("Register Edit Date Saved");
            }
            else
            {
                ReporterFactory.LogFailure("Edit not  Saved");
            }
        }

        /// <summary>
        /// Method to Validate HPT 20 gallon saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_20_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }


        /// <summary>
        /// Method to Validate HPT 10 Gallon saved
        /// /// </summary>
        public void ValidateMeterSaveHPT_10_GAL(string custName, string meterClass, string meterSize, string UOM)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabMeter, "MeterTab");
            //driver.ClickElement(drpMeterClass, "Meter Class drop down");
            //driver.ClickElement(By.XPath("//*[contains(@id,'" + meterClass + "')]"), "Select Meter Class");
            driver.ClickElement(drpMeterSize, "Meter Size drop down");
            driver.ClickElement(By.XPath("//*[contains(@id,'-" + meterSize + "')]"), "Select Meter Size value");
            driver.ClickElement(tabRegister, "Register Tab");
            driver.ClickElement(drpUOM, "UOM");
            driver.ClickElement(By.XPath("//*[contains(text(),'" + UOM + "')]"), "Select UOM");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, System.TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            //driver.CheckElementDisplayed(lblMeterClass, "Meter Class");
            driver.CheckElementDisplayed(lblMeterSize, "Meter Size");
            driver.CheckElementDisplayed(lblUnitMeasure, "Unit Of Measure");
            if (driver.GetElementText(lblMeterSize).Contains(meterSize) & driver.GetElementText(lblUnitMeasure).Equals(ConvertUOM(UOM)))
            {
                testReport.Pass("<i><b>Asset Configuration</b> has been Updated");
            }
            else
            {
                ReporterFactory.LogFailure("<i><b>Asset Configuration </b>has not been Saved");
            }
        }






        /// <summary>
        /// Method to Validate Latest Reading and Date
        /// </summary>
        public void ValidateLatestReadingAndDate(string accountNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "MIU ID");
            driver.ClickElement(btnOk, "OK");
            //driver.sleepTime(20000);
            driver.WaitForElement(lblMeterInstallDate, System.TimeSpan.FromSeconds(20));
            if (driver.CheckElementDisplayed(lblLatestReading, "Latest Reading") & driver.CheckElementDisplayed(lblMeterInstallDate, "Install Date"))
            {
                testReport.Pass("Latest Reading for Account no : " + accountNo + " is <mark>: " + driver.GetElementText(lblLatestReading));
                testReport.Pass("Install Date for Account No : " + accountNo + " is :<mark> " + driver.GetElementText(lblMeterInstallDate));
            }
            else
            {
                ReporterFactory.LogFailure("No Reading found for Account no :" + accountNo);
            }
        }


        /// <summary>
        /// Method to Validate Selecting Accoount From Search Results
        /// </summary>
        public void ValidateSelectingAccFromSearchResults(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            driver.WaitForElement(lblAccountNo, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(lblAccountNo, "Account No");
            testReport.Pass("All Account Informations are Displayed for Meter Id Matching Criteria: <mark>" + lblAccountNo);
        }

        /// <summary>
        /// Method to Validate Search Field Blank
        /// </summary>
        public void ValidateSearchFieldBlank(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.ClickElement(btnSearch, "Search");
            //driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Search Field Blank");
            testReport.Pass("Search Field Can not be blank: <mark>" + toastMessage);
        }

        /// <summary>
        /// Method to Validate Search Field Blank Customer Name
        /// </summary>
        public void ValidateSearchFieldBlankCustName()
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Customer Name");
            driver.ClickElement(btnSearch, "Search");
            driver.CheckElementDisplayed(toastMessage, "Search Field Blank");
            testReport.Pass("Search Field Can not be blank: <mark>" + toastMessage);
        }

        /// <summary>
        /// Method to Validate Search Field Blank
        /// </summary>
        public void ValidateSearchFieldBlankAddress()
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAddress, "Address");
            driver.ClickElement(btnSearch, "Search");
            driver.CheckElementDisplayed(toastMessage, "Search Field Blank");
            testReport.Pass("Search Field Can not be blank: <mark>" + toastMessage);
        }

        /// <summary>
        /// Method to Validate Search Account Number Blank
        /// </summary>
        public void ValidateSearchFieldBlankAccNo()
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Address");
            driver.ClickElement(btnSearch, "Search");
            driver.CheckElementDisplayed(toastMessage, "Search Field Blank");
            testReport.Pass("Search Field Can not be blank: <mark>" + toastMessage);
        }


        /// <summary>
        /// Method to Validate Account Search Exact Match
        /// </summary>
        public void ValidateAccSearchExactMatch(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            testReport.Pass("Search Results found for Exact Search Account Match <mark>" + meterId);
        }

        /// <summary>
        /// Method to Validate Account Search By Meter ID
        /// </summary>
        public void ValidateAccSearchByMeterId(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueMIUId, "Meter Id");
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(btnOk, "Ok");
            testReport.Pass("Search Results found for Meter ID <mark>" + meterId + "is matching with account number <mark>" + tblMeterId);
        }

        /// <summary>
        /// Method to Validate Account Search By Account No
        /// </summary>
        public void ValidateAccSearchByAccNo(string accountNo)
        {

            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account Number");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountNo, "Account Number");
            driver.ClickElement(btnOk, "Ok");
            testReport.Pass("Search Results found for Account No: <mark>" + accountNo);
        }

        /// <summary>
        /// Method to Validate Account Search By Customer Name
        /// </summary>
        public void ValidateAccSearchByCustomerName(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Customer Name");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountName, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            testReport.Pass("Search Results found for Customer Name: <mark>" + custName);
        }

        /// <summary>
        /// Method to Validate Account Search By Customer Name
        /// </summary>
        public void ValidateAccSearchByAddress(string custAddress)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAddress, "Customer Address");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custAddress, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAddress, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAddress, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            testReport.Pass("Search Results found for Customer Address: <mark>" + custAddress);
        }

        /// <summary>
        /// Method to Validate Account Search By Invalid Meter ID
        /// </summary>
        public void ValidateNoResultsFoundInvalidMID(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(noResultsFound, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(noResultsFound, "No Results Found");
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Pass("No Results found for Invalid Meter ID: <mark>" + meterId);
        }

        /// <summary>
        /// Method to Validate Account Search for invalid acc no
        /// </summary>
        public void ValidateNoResultsFoundforInvalidAccNo(string accNo)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account Number");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(noResultsFound, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(noResultsFound, "No Results Found");
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Pass("No Results found for Invalid Account No: <mark>" + accNo);
        }


        /// <summary>
        /// Method to Validate Account Search for invalid customer name
        /// </summary>
        public void ValidateNoResultsFoundforCustName(string custName)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Customer Name");
            driver.SendKeysToElementClearFirst(txtAccountSearch, custName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(noResultsFound, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(noResultsFound, "No Results Found");
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Pass("No Results found for Invalid Account No: <mark>" + custName);
        }

        /// <summary>
        /// Method to Validate Account Search for invalid address
        /// </summary>
        public void ValidateNoResultsFoundforInvalidAdd(string address)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAddress, "Address");
            driver.SendKeysToElementClearFirst(txtAccountSearch, address, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            //driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.WaitForElement(noResultsFound, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(noResultsFound, "No Results Found");
            driver.ClickElement(btnCancel, "Cancel");
            testReport.Pass("No Results found for Invalid Address: <mark>" + address);
        }


        /// <summary>
        /// Method to Validate Search Account No results found
        /// </summary>
        public void ValidateSearchAccountNoResultsFound(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(btnCancel, System.TimeSpan.FromSeconds(30));

            driver.ClickElement(btnCancel, "Cancel");
            testReport.Pass("Account Information is not Displayed for Meter Id: <mark>" + meterId);
        }

        /// <summary>
        /// Method to Validate Search Account by Mutiple Criteria
        /// </summary>
        public void ValidateSearchAccountByMultipleCriteria(string meterId)
        {
            string tblMeterId = "";
            string tblAccountNo = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueMeterNo, TimeSpan.FromSeconds(60));
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueAccountNo, "Account No");
            tblAccountNo = driver.GetElementText(rowValueAccountNo);
            driver.ClickElement(btnOk, "Ok");
            driver.WaitForElement(drpSearchCustAccount, TimeSpan.FromSeconds(60));

            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAccountNo, "Account Number");
            driver.SendKeysToElementClearFirst(txtAccountSearch, tblAccountNo, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.sleepTime(10000);
            driver.WaitForElement(rowValueMeterNo, TimeSpan.FromSeconds(60));

            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            driver.WaitForElement(lblMeterId, TimeSpan.FromSeconds(60));

            meterId = driver.GetElementText(lblMeterId);
            if (tblAccountNo.Contains(tblAccountNo))
                testReport.Pass("Account Information displayed for Meter Id: <mark>" + tblAccountNo + "</mark> is Successfull");
            else if (tblMeterId.Contains(tblMeterId))
                testReport.Pass("Account Information displayed for Meter Id: <mark>" + tblMeterId + "</mark> is Successfull");
            else
                ReporterFactory.LogFailure("Account Information displayed for Meter Id and Account No: <mark>" + tblAccountNo + meterId + "</mark> is not Successfull");
        }

        /// <summary>
        /// Method to Validate Search Account by Customer Name
        /// </summary>
        public void ValidateSearchAccountByCustomerName(string accountName)
        {
            string tblAccountName = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Customer Name");
            driver.SendKeysToElementClearFirst(txtAccountSearch, accountName, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblAccountName = driver.GetElementText(rowValueAccountName);
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            accountName = driver.GetElementText(lblAccountName);
            if (tblAccountName.Contains(accountName))
                testReport.Pass("Account Information displayed for Customer Name: <mark>" + accountName + "</mark> is Successfull");
            else
                ReporterFactory.LogFailure("Account Information displayed for Customer Name: <mark>" + accountName + "</mark> is not Successfull");
        }

        /// <summary>
        /// Method to Validate Search Account by Address
        /// </summary>
        public void ValidateSearchAccountByAddress(string address)
        {
            string tblAddress = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueAddress, "Address");
            driver.SendKeysToElementClearFirst(txtAccountSearch, address, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblAddress = driver.GetElementText(rowValueAddress);
            driver.ClickElement(rowValueAddress, "Address");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            address = driver.GetElementText(lblAddress);
            if (tblAddress.Contains(address))
                testReport.Pass("Account Information displayed for Customer Name: <mark>" + address + "</mark> is Successfull");
            else
                ReporterFactory.LogFailure("Account Information displayed for Customer Name: <mark>" + address + "</mark> is not Successfull");
        }

        /// <summary>
        /// Method to Validate Edit Assert Configuration
        /// </summary>
        public void ValidateEditAssertConfig()
        {
            driver.IsElementEnabled(btnEdit, "Edit");
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementExists(dlgAssertConfig, "Assert Configuration");
            driver.ClickElement(btnCancelAssertConfig, "Cancel");
        }

        /// <summary>
        /// Method to Valdiate Edit Assert Config Button Does Not Exists
        /// </summary>
        public void ValidateEditAssertConfigBtnDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Select Meter
        /// </summary>
        public void ValidateSelectMeter()
        {
            driver.CheckElementDisplayed(lnkMoreMeters, "More Meters");
            driver.ClickElement(lnkMoreMeters, "More Meters");
            driver.CheckElementExists(dlgChooseMeter, "Choose Meter");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Consumption_Chart_Accounts_Display
        /// </summary>
        public void ValidateConsumptionChartAccountsDisplay(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            //driver.WaitForElement(By.XPath("ntgMSTRFrame"), TimeSpan.FromSeconds(50));
            driver.sleepTime(10000);
            //driver.SwitchToFrameByIndex(2);
            //driver.WaitForElement(monthlyChart, TimeSpan.FromMinutes(1));
            driver.ClickElement(monthlyChart, "Monthly Chart");
            // driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate MIU Contents
        /// </summary>
        public void ValidateMIUContents(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(tabMIU, "MIU Tab");
            driver.CheckElementDisplayed(miuID, "MIU ID");
            driver.CheckElementDisplayed(drpLinkedMiu, "Linked MIU");
            driver.CheckElementDisplayed(drpMiuInstalldate, "MIU Install Date");
            driver.CheckElementDisplayed(drpMiuFirmware, "MIU Firmware");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Mini Map
        /// </summary>
        public void ValidateMiniMap(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.sleepTime(5000);
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.WaitForElement(By.XPath("//img[@class='customerinquiry-map-image']"), TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(By.XPath("//img[@class='customerinquiry-map-image']"), "Mini Map");
        }

        public void ValidateSoftDisconnect(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.CheckElementDisplayed(tabSoftDisconnect, "Soft Disconnect");
            driver.ClickElement(tabSoftDisconnect, "Soft Disconnect");
            By cancel = By.XPath("//button[text()='Cancel']");
            driver.ClickElement(cancel, "Cancel");
        }
        public void ValidateSoftDisconnectTurnOn(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "Soft Disconnect");
            driver.ClickElement(softDiscCheckBox, "Checkbox");
            By save = By.XPath("//button[text()='Save']");
            driver.ClickElement(save, "Save");
            //driver.sleepTime(7000);
            driver.WaitForElement(toastMessage, TimeSpan.FromMinutes(2));
            driver.CheckElementDisplayed(toastMessage, "");
        }
        public void ValidateSoftDisconnectTurnOnComment(string meterId)
        {
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueCustomerName, "Account");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            driver.WaitForElement(rowValueAccountNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(rowValueAccountName, "Account Name");
            driver.ClickElement(btnOk, "OK");
            driver.sleepTime(15000);
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(tabSoftDisconnect, "Soft Disconnect");
            driver.ClickElement(softDiscCheckBox, "Checkbox");
            driver.ClickElement(By.XPath("//button[text()='Save']"), "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromMinutes(2));
            driver.CheckElementDisplayed(toastMessage, "");
            driver.CheckElementDisplayed(commentSection, "Comment Section");
        }
        /// <summary>
        /// Method to Validate View Dashboard
        /// </summary>
        public void ValidateViewDashboard()
        {
            driver.sleepTime(20000);
            driver.WaitForPageLoad(System.TimeSpan.FromSeconds(10));
            //driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromMinutes(2);
            driver.SwitchToFrameById("ntgMSTRFrame");
            //driver.WaitForElement(grphConsumption, System.TimeSpan.FromMinutes(1));
            //driver.CheckElementExists(grphConsumption, "Consumption Graph");
            driver.SwitchToDefaultFrame();
        }


        public void ValidateHourlyReadingActual(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(10000);
            driver.WaitForElement(btnEstimated, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(btnActual, "Actual");

            driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
            IWebElement chart = driver.FindElement(By.XPath("//*[name()='svg']"));
            string[] charttext = chart.Text.Split('\n');
            IList<IWebElement> pathvarsDaily = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'http://www.qa.neptune360.com/customerinquiry')]//*[name()='path']"));
            int count = 0;
            foreach (IWebElement variabD in pathvarsDaily)
            {
                try
                {
                    count++;
                    if (count == 2)
                    {
                        variabD.Click();
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("variable:" + variabD.ToString() + "  exception:" + e.ToString());
                }

            }
            driver.sleepTime(10000);
            By consumpTable = By.XPath("//div[@class='customerinquiry-report-grid']//table[@class='k-grid-table']");
            //IWebElement consumptionData = driver.FindElement(consumpTable);
            //DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);

            IList<IWebElement> pathvarsHourly = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'http://www.qa.neptune360.com/customerinquiry')]//*[name()='path']"));
            int countH = 0;
            foreach (IWebElement variabH in pathvarsHourly)
            {
                try
                {
                    countH++;
                    if (countH == 2)
                    {
                        variabH.Click();
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("variable:" + variabH.ToString() + "  exception:" + e.ToString());
                }

            }
            driver.sleepTime(10000);

        }

        public void ValidateHourlyReadingEstimated(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(5000);
            driver.WaitForElement(btnEstimated, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEstimated, "Estimated");
            driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
            IWebElement chart = driver.FindElement(By.XPath("//*[name()='svg']"));
            string[] charttext = chart.Text.Split('\n');
            IList<IWebElement> pathvarsDaily = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'http://www.qa.neptune360.com/customerinquiry')]//*[name()='path']"));
            int count = 0;
            foreach (IWebElement variab in pathvarsDaily)
            {
                try
                {
                    count++;
                    if (count == 2)
                    {
                        variab.Click();
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("variable:" + variab.ToString() + "  exception:" + e.ToString());
                }

            }
            driver.sleepTime(20000);
            By consumpTable = By.XPath("//div[contains(@class,'customerinquiry-report-grid')]//table[@class='k-grid-table']");
            IWebElement consumptionData = driver.FindElement(consumpTable);
            DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);
            IList<IWebElement> pathvarsHourly = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'http://www.qa.neptune360.com/customerinquiry')]//*[name()='path']"));
            int countH = 0;
            foreach (IWebElement variab in pathvarsHourly)
            {
                try
                {
                    countH++;
                    if (countH == 2)
                    {
                        variab.Click();
                        System.Threading.Thread.Sleep(2000);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("variable:" + variab.ToString() + "  exception:" + e.ToString());
                }

            }
            driver.sleepTime(1000);

        }


        public void ValidateMonthlyReadingActual(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");

            driver.WaitForElement(btnEstimated, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnActual, "Actual");
            driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
            driver.CheckElementDisplayed(By.XPath("//*[name()='svg']"), "Monthly Reading Actual");
        }

        public void ValidateMonthlyReadingActualBtn(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");
            driver.sleepTime(5000);
            driver.WaitForElement(btnEstimated, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnActual, "Actual");
            driver.CheckElementDisplayed(btnActual, "Actual");
            driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
            driver.CheckElementDisplayed(By.XPath("//*[name()='svg']"), "Monthly Reading Actual");
        }

        public void ValidateMonthlyReadingEstimatedBtn(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");

            driver.WaitForElement(btnEstimated, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEstimated, "Estimated");
            driver.CheckElementDisplayed(btnActual, "Actual");
        }


        public void ValidateMonthlyReadingEstimated(string meterId)
        {
            string tblMeterId = "";
            driver.ClickElement(drpSearchCustAccount, "Search Account");
            driver.ClickElement(drpValueMeterId, "MeterId");
            driver.SendKeysToElementClearFirst(txtAccountSearch, meterId, "Account Search");
            driver.ClickElement(btnSearch, "Search");
            tblMeterId = driver.GetElementText(rowValueMeterNo);
            driver.ClickElement(rowValueMeterNo, "Meter Id");
            driver.ClickElement(btnOk, "Ok");

            driver.WaitForElement(btnEstimated, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEstimated, "Estimated");
            driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
            driver.ClickElement(btnEstimated, "Estimated");
            driver.CheckElementDisplayed(By.XPath("//*[name()='svg']"), "Monthly Reading Estimated");

        }
        /// <summary>
        /// Convert Unit of Measure 
        /// </summary>
        /// <param name="UOM"></param>
        /// <returns></returns>
        public string ConvertUOM(string UOM)
        {
            switch (UOM)
            {
                case "M3":
                    UOM = "Cubic Meters";
                    break;
                case "FT3":
                    UOM = "Cubic Feet";
                    break;
                case "GAL":
                    UOM = "Gallons";
                    break;
                case "IPG":
                    UOM = "Imperial Gallons";
                    break;
                case "LTR":
                    UOM = "Liters";
                    break;
            }
            return UOM;
        }


        public void DailyConsumption(string query)
        {
            try
            {
                driver.sleepTime(20000);
                driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
                IWebElement chart = driver.FindElement(By.XPath("//*[name()='svg']"));
                string[] charttext = chart.Text.Split('\n');
                IList<IWebElement> pathvars = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'neptune360.com/customerinquiry')]//*[name()='path']"));
                int count = 0;
                foreach (IWebElement variab in pathvars)
                {
                    try
                    {
                        count++;
                        if (count == 2)
                        {
                            variab.Click();
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("variable:" + variab.ToString() + "  exception:" + e.ToString());
                    }

                }
                driver.sleepTime(20000);
                By consumpTable = By.XPath("//div[@class='customerinquiry-report-container ng-star-inserted']");
                IWebElement consumptionData = driver.FindElement(consumpTable);
                DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);

                executeQuery = driver.ExecutePostgreSQL(query);
                double multiplier = Convert.ToDouble(executeQuery.Rows[0][0]);
                for (int i = 1; i < reportsData.Rows.Count; i++)
                {
                    string previousReading = reportsData.Rows[i - 1]["Reading"].ToString();
                    string nextReading = reportsData.Rows[i]["Reading"].ToString();

                    if (previousReading == "" || nextReading == "")
                    {
                        continue;
                    }
                    double consumption = double.Parse(reportsData.Rows[i - 1]["Reading"].ToString()) - double.Parse(reportsData.Rows[i]["Reading"].ToString());
                    if ((consumption * multiplier).ToString("0.000") == (reportsData.Rows[i - 1]["Daily Consumption"].ToString()))
                    {
                        ReporterFactory.TestReport.Pass("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> matches consumption value: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");
                    }
                    else
                    {
                        ReporterFactory.LogFailure("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> does not match.\n Expected: <mark>" + consumption.ToString() + "</mark> Actual: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");

                    }
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error while validating the Consumption Data. Exception Details: " + ex.ToString());
            }

        }

        public void DailyConsumptionL900(string query)
        {
            try
            {
                driver.sleepTime(20000);
                driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
                IWebElement chart = driver.FindElement(By.XPath("//*[name()='svg']"));
                string[] charttext = chart.Text.Split('\n');
                IList<IWebElement> pathvars = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'neptune360.com/customerinquiry')]//*[name()='path']"));
                int count = 0;
                foreach (IWebElement variab in pathvars)
                {
                    try
                    {
                        count++;
                        if (count == 2)
                        {
                            variab.Click();
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("variable:" + variab.ToString() + "  exception:" + e.ToString());
                    }

                }
                driver.sleepTime(20000);
                By consumpTable = By.XPath("//div[@class='customerinquiry-report-container ng-star-inserted']//table[@class='k-grid-table']");
                driver.WaitForElement(consumpTable, TimeSpan.FromSeconds(60));
                IWebElement consumptionData = driver.FindElement(consumpTable);
                DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);

                executeQuery = driver.ExecutePostgreSQL(query);
                double multiplier = Convert.ToDouble(executeQuery.Rows[0][0]);

                for (int i = 1; i < reportsData.Rows.Count; i++)
                {
                    string previousReading = reportsData.Rows[i - 1]["Reading"].ToString();
                    string nextReading = reportsData.Rows[i]["Reading"].ToString();

                    if (previousReading == "" || nextReading == "")
                    {
                        continue;
                    }
                    else
                    {

                        double consumption = double.Parse(previousReading) - double.Parse(nextReading);
                        if ((consumption * multiplier).ToString("0.000") == (reportsData.Rows[i - 1]["Daily Consumption"].ToString()))
                        {
                            ReporterFactory.TestReport.Pass("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> matches consumption value: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> does not match.\n Expected: <mark>" + consumption.ToString() + "</mark> Actual: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error while validating the Consumption Data. Exception Details: " + ex.ToString());
            }
        }

        public void DailyConsumptionR900(string query)
        {
            try
            {
                driver.sleepTime(20000);
                driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
                IWebElement chart = driver.FindElement(By.XPath("//*[name()='svg']"));
                string[] charttext = chart.Text.Split('\n');
                IList<IWebElement> pathvars = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'neptune360.com/customerinquiry')]//*[name()='path']"));
                int count = 0;
                foreach (IWebElement variab in pathvars)
                {
                    try
                    {
                        count++;
                        if (count == 2)
                        {
                            variab.Click();
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("variable:" + variab.ToString() + "  exception:" + e.ToString());
                    }

                }
                driver.sleepTime(20000);
                By consumpTable = By.XPath("//div[@class='customerinquiry-report-grid']//table[@class='k-grid-table']");
                IWebElement consumptionData = driver.FindElement(consumpTable);
                DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);

                executeQuery = driver.ExecutePostgreSQL(query);
                double multiplier = Convert.ToDouble(executeQuery.Rows[0][0]);

                for (int i = 1; i < reportsData.Rows.Count; i++)
                {
                    string previousReading = reportsData.Rows[i - 1]["Reading"].ToString();
                    string nextReading = reportsData.Rows[i]["Reading"].ToString();

                    if (previousReading == "" || nextReading == "")
                    {
                        continue;
                    }
                    else
                    {

                        double consumption = double.Parse(previousReading) - double.Parse(nextReading);
                        double actualConsump = double.Parse(reportsData.Rows[i - 1]["Daily Consumption"].ToString());
                        if ((consumption * multiplier).ToString("0.000") == actualConsump.ToString("0.000"))
                        {
                            ReporterFactory.TestReport.Pass("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> matches consumption value: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> does not match.\n Expected: <mark>" + consumption.ToString() + "</mark> Actual: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error while validating the Consumption Data. Exception Details: " + ex.ToString());
            }
        }


        public void DailyConsumptionR450(string query)
        {
            try
            {


                driver.sleepTime(20000);
                driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
                IWebElement chart = driver.FindElement(By.XPath("//*[name()='svg']"));
                string[] charttext = chart.Text.Split('\n');
                IList<IWebElement> pathvars = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'neptune360.com/customerinquiry')]//*[name()='path']"));
                int count = 0;
                foreach (IWebElement variab in pathvars)
                {
                    try
                    {
                        count++;
                        if (count == 2)
                        {
                            variab.Click();
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("variable:" + variab.ToString() + "  exception:" + e.ToString());
                    }

                }
                driver.sleepTime(20000);
                By consumpTable = By.XPath("//div[@class='customerinquiry-report-grid']//table[@class='k-grid-table']");
                IWebElement consumptionData = driver.FindElement(consumpTable);
                DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);

                executeQuery = driver.ExecutePostgreSQL(query);
                double multiplier = Convert.ToDouble(executeQuery.Rows[0][0]);

                for (int i = 1; i < reportsData.Rows.Count; i++)
                {
                    string previousReading = reportsData.Rows[i - 1]["Reading"].ToString();
                    string nextReading = reportsData.Rows[i]["Reading"].ToString();

                    if (previousReading == "" || nextReading == "")
                    {
                        continue;
                    }
                    else
                    {

                        double consumption = double.Parse(previousReading) - double.Parse(nextReading);
                        if ((consumption * multiplier).ToString("0.000") == (reportsData.Rows[i - 1]["Daily Consumption"].ToString()))
                        {
                            ReporterFactory.TestReport.Pass("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> matches consumption value: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> does not match.\n Expected: <mark>" + consumption.ToString() + "</mark> Actual: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error while validating the Consumption Data. Exception Details: " + ex.ToString());
            }
        }


        public void DailyConsumptionCMIUType(string query)
        {
            try
            {


                driver.sleepTime(20000);
                driver.WaitForElement(By.XPath("//*[name()='svg']"), TimeSpan.FromSeconds(60));
                IWebElement chart = driver.FindElement(By.XPath("//*[name()='svg']"));
                string[] charttext = chart.Text.Split('\n');
                IList<IWebElement> pathvars = chart.FindElements(By.XPath("//*[name()='g' and contains(@clip-path,'neptune360.com/customerinquiry')]//*[name()='path']"));
                int count = 0;
                foreach (IWebElement variab in pathvars)
                {
                    try
                    {
                        count++;
                        if (count == 2)
                        {
                            variab.Click();
                            System.Threading.Thread.Sleep(2000);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("variable:" + variab.ToString() + "  exception:" + e.ToString());
                    }

                }
                driver.sleepTime(20000);
                By consumpTable = By.XPath("//div[@class='customerinquiry-report-grid ng-star-inserted']//table[@class='k-grid-table']");
                IWebElement consumptionData = driver.FindElement(consumpTable);
                DataTable reportsData = driver.ConvertConsumptionWebTableToData(consumptionData);

                //  executeQuery = driver.ExecutePostgreSQL(query);
                double multiplier = Convert.ToDouble(executeQuery.Rows[0][0]);

                for (int i = 1; i < reportsData.Rows.Count; i++)
                {
                    string previousReading = reportsData.Rows[i - 1]["Reading"].ToString();
                    string nextReading = reportsData.Rows[i]["Reading"].ToString();

                    if (previousReading == "" || nextReading == "")
                    {
                        continue;
                    }
                    else
                    {

                        double consumption = double.Parse(previousReading) - double.Parse(nextReading);
                        if ((consumption * multiplier).ToString("0.000") == (reportsData.Rows[i - 1]["Daily Consumption"].ToString()))
                        {
                            ReporterFactory.TestReport.Pass("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> matches consumption value: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");
                        }
                        else
                        {
                            ReporterFactory.LogFailure("Consumption Data for date: <mark>" + reportsData.Rows[i - 1]["Date"].ToString() + "</mark> does not match.\n Expected: <mark>" + consumption.ToString() + "</mark> Actual: <mark>" + reportsData.Rows[i - 1]["Daily Consumption"].ToString() + "</mark>");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Error while validating the Consumption Data. Exception Details: " + ex.ToString());
            }
        }


    }
}
