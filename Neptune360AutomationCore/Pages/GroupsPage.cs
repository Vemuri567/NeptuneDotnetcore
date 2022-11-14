using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace Neptune360UIAutomation
{
    public class GroupsPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By groupManagement = By.XPath("//span[text()='GROUP MANAGEMENT']");
        private By groups = By.XPath("//span[text()='GROUPS']");
        private By selectGroup = By.XPath("//div/div[1]/div[3]/ul/li[1]");
        private By btnCreate = By.XPath("//button[text()='Create']");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By btnEdit = By.XPath("//button[text()='Edit']");
        private By btnAdd = By.XPath("//button[text()='Add']");
        private By btnReseConfirm = By.XPath("//button[text()='Reset']");
        private By btnAddtoGroup = By.XPath("//button[text()='Add to Group']");
        private By btnDelete = By.XPath("//button[text()='Delete']");
        private By btnOK = By.XPath("//button[text()='Ok']");
        private By deleteConfirm = By.XPath("//kendo-dialog-actions/button[1]");
        private By header = By.XPath("//h2");
        private By toastMessage = By.Id("toast-container");
        private By btnFinish = By.XPath("//button[text()='Finish']");
        private By description = By.XPath("//textarea[@name='description']");
        private By btnAddEndpoint = By.XPath("//button[contains(.,'Endpoints')]");
        private By removeEndpoint = By.CssSelector(".removeendpoint-button.k-button");
        private By grpName = By.Name("name");
        private By updatedDate = By.XPath("//span[contains(.,'Last Updated:')]");
        private By deleteGrpConfimpopup = By.XPath("//div[text()='DELETE GROUP?']");
        private By addToGroup = By.XPath("//div[text()='ADD TO GROUP?']");
        private By deleteCancel= By.XPath("//button[text()='Cancel']");
        private By deleteConfirmation = By.XPath("//span[contains(.,'Are you sure you want to delete this Group?')]");
        private By btndeleteDialogdelete = By.XPath("//div[2]/kendo-dialog-actions/button[1]");
        private By groupsDisplay = By.XPath("//app-advance-search-results/div/div[1]/ul");
        private By groupsList = By.XPath("//sd-list-groups/div/div/div[1]");
        private By endpoints = By.XPath("//span[contains(.,'# Endpoints: ')]");
        private By drpDowngroupNamesort = By.XPath("//span[contains(.,'Group Name')]");
        private By groupListmeterNumber = By.XPath("//span[contains(.,'Meter Number')]");
        private By groupListAccNumber = By.XPath("//span[contains(.,'Account Number')]");
        private By groupNameSort = By.XPath("//kendo-list/div/ul/li[1]");
        private By endpointSort = By.XPath("//kendo-list/div/ul/li[3]");
        private By lastUpdatedSort = By.XPath("//kendo-list/div/ul/li[2]");
        private By searchGroupTextBox = By.Id("txtGroupsSearch");
        private By searchGroupEndpoint = By.Id("txtEndpointsSearch");
        private By groupDescription = By.XPath("//div[3]/div/span[2]");
        private By endpointList = By.XPath("//sd-list-groups//div[2]/app-data-stack");
        private By sortedEndpoints = By.XPath("//app-advance-search-results/div/div[1]/ul/li[3]/div");
        private By sortedAccountNumber = By.XPath("//span[contains(text(),'Account Number:')]");
        private By drpdownEndpoint = By.XPath("//span[contains(text(),'Sort By:')]/..//kendo-dropdownlist//span[text()='Account Name']");
        private By endpointxpath = By.XPath("//button[text()=' Endpoints']");
        private By accNameEndpoint = By.XPath("//li[contains(.,'Account Name')]");
        private By accNoEndpoint = By.XPath("//kendo-list/div/ul/li[2]");
        private By addressEndpoint = By.XPath("//kendo-list/div/ul/li[3]");
        private By miuidEndpoint = By.XPath("//kendo-list/div/ul/li[4]");
        private By meterNoEndpoint = By.XPath("//kendo-list/div/ul/li[5]");
        private By metersizeEndpoint = By.XPath("//kendo-list/div/ul/li[6]");
        private By classificationEndpoint = By.XPath("//kendo-list/div/ul/li[7]");
        private By searchgroupxpath = By.XPath("//input[@name='txtGroupsSearch']");
        private By endpointNextPage = By.XPath("//app-data-stack//div[contains(@class,'page-padding')]//a[contains(text(),'>')][1]");
        private By endpointpages = By.XPath("//a[@class='page-selected']");
        private By drpdownmultiSelect = By.XPath("//span[text()='Multi Select']");
        private By selectAll = By.XPath("//li[contains(.,'Select All')]");
        private By deselectAll = By.XPath("//li[contains(.,'Deselect All')]");
        private By selectPage = By.XPath("//li[contains(.,'Select Page')]");
        private By select1st = By.CssSelector("li:nth-child(1) input");
        private By select2nd = By.CssSelector("li:nth-child(2) input");
        private By selectedGroups = By.XPath("//div/app-data-stack//div[contains(@class,'button-grp-format ntg-font-size-h6')]");
        private By endpointClassificationValue = By.XPath("//div[4]/ul/li[1]/div/div[4]/span[6]");
        private By btnClassification = By.XPath("//button[text()='Classification']");
        private By drpdownClassification = By.XPath("//kendo-dialog-titlebar/..//kendo-dropdownlist//span[@class='k-input-value-text']");
        private By classificationInput = By.XPath("//kendo-list/div/ul/li[3]");
        private By classificationConsum = By.XPath("//kendo-list/div/ul/li[2]");
        private By classificationNonConsum = By.XPath("//kendo-list/div/ul/li[4]");
        private By classificationOutput = By.XPath("//kendo-list/div/ul/li[5]");
        private By sortOrderProcessing = By.XPath("//div[2]/app-data-stack/div[1]/div/div[2]/i");

        private By noEndpoint = By.XPath("//div[text()='Group has no Endpoints']");
        private By lnkChooseUtilities = By.XPath("//sd-menu/ul/li");
        private By utilitySearch = By.Id("utilitySearchTextBox");
        private By btnChooseUtilitiesOk = By.Id("deactUtilityYesButton");
        private By tblChooseUtilities = By.XPath("//span[text()='Choose Utilities']//../../..//table[@class='k-grid-table']//span");
        private By noGroupExist = By.XPath("//div[text()='No Groups exist yet']");
        private By removeEndpointDialog = By.XPath("//div[text()='REMOVE FROM GROUP?']");
        private By searchEndpoints = By.Id("txtEndpointsSearch");
        private By accNoTxtBox = By.Id("account_number");
        private By accNameTxtBox = By.Id("account_name");
        private By addressTxtBox = By.Id("address");
        private By cityTxtBox = By.Id("city");
        private By zipTxtBox = By.Id("zip");
        private By miuIdTxtBox = By.Id("miu_id");
        private By miuStatus = By.Name("miuStatuses");
        private By meterIDTxtBox = By.Id("meter_num");
        private By meterSize = By.XPath("//kendo-multiselect//kendo-searchbar/input");
        private By meterInstallDatefrom = By.Name("meter_install_date_from");
        private By miuStatusActive = By.Name("miuStatuses");
        private By btnAdvanceSearch = By.Name("search");
        private By btnReset = By.Name("reset");
        private By advanceSeachEndpoint = By.XPath("//app-advance-search-results/div/div[1]/ul");
        private By searchEndpointNextPage = By.XPath("//div[contains(@class,'pag-btns')]//a[contains(text(),'2')]");
        private By searchEndpointPreviousPage = By.XPath("//div[contains(@class,'pag-btns')]//a[contains(text(),'1')]");
        private By searchEndpointLastPage = By.XPath("//a[contains(text(),'>>')]");
        private By endpointListone = By.XPath("//app-advance-search-results/div/div[1]/ul/li[3]/div/div[1]/input");
        private By drpDownselectGroup = By.XPath("//span/kendo-dropdownlist/span//span");
        private By selectgroupDateTime = By.XPath("//kendo-list/div/ul/li[2]");
        private By groupSearchDrpdown = By.XPath("//li[2]/div/div[2]/kendo-dropdownlist/span/span[1]");
        private By routesDrpdown = By.XPath("//li[3]/div/div[2]/kendo-dropdownlist/span/span[1]");
        private By cctestGroup = By.XPath("//kendo-list/div/ul/li[4]");
        private By drpDownMultiSelectEndpoint = By.XPath("//div/div[1]/kendo-dropdownlist/span/span[1]");
        private By multiSelectALl = By.XPath("//li[contains(.,'Select All')]");

        private By select1stgrp = By.XPath("//ul/li[3]/div/div[1]/input");
        private By select2ndGroup = By.XPath("//div/div[1]/div[3]/ul/li[2]");
        private By lftNavSearchEndpoint = By.XPath("//span[text()='SEARCH ENDPOINTS']");
        private By drpDownsort = By.XPath("//span[contains(text(),'Sort By:')]/..//kendo-dropdownlist//span[text()='Account Name']");
        private By drpDownAccName = By.XPath("//kendo-list/div/ul/li[1]");
        private By drpDownAccNo = By.XPath("//kendo-list/div/ul/li[2]");
        private By drpDownAddress = By.XPath("//kendo-list/div/ul/li[3]");
        private By drpDownmiuId = By.XPath("//kendo-list/div/ul/li[4]");
        private By drpDownmeterId = By.XPath("//kendo-list/div/ul/li[5]");
        private By drpDownmeterSize = By.XPath("//kendo-list/div/ul/li[6]");
        private By resetDialog = By.XPath("//div[text()='RESET SEARCH']");
        #endregion

        /// <summary>
        /// Method to Validate Group Select
        /// </summary>
        public void ValidateGroupSelect()
        {
            driver.ClickElement(selectGroup, "Select Group");
        }

        /// <summary>
        /// Method to Validate Create Button
        /// </summary>
        public void ValidateCreateButton()
        {
            driver.CheckElementDisplayed(btnCreate, "Create");
        }

        public void ValidateCreateButtonClick()
        {
            driver.ClickElement(btnCreate, "Create");
            if(driver.GetElementText(header).Equals("Create Group"))
            {
                testReport.Pass("<i>Title displayed is : " + driver.GetElementText(header));
            }
            else
            {
                ReporterFactory.LogFailure("Title displayed is : " + driver.GetElementText(header));
            }
        }

        public void ValidateGroupNameMaxLength(string grpname)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            testReport.Pass("Group Name accepts max length of 50 characters");
        }
        public void ValidateEditGroupNameMaxLength(string grpname)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            testReport.Pass("Group Name accepts max length of 50 characters");
        }

        public void ValidateEditGroupUnchanged()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnFinish, "Finish");
            testReport.Pass("Group Name accepts max length of 50 characters");
        }
        public void ValidateEditGroupNameChanged(string gName)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(grpName, gName, "Group Name");
            driver.sleepTime(3000);
            driver.ClickElement(btnFinish, "Finish");
            if(driver.CheckElementDisplayed(By.XPath("//span[contains(.,'" + gName + "')]"), ""))
            {
                testReport.Pass("New Group is not created and only the existing Group is updated");
            }
            else
            {
                ReporterFactory.LogFailure("New Group is created and only the existing Group is updated");
            }
        }

        public void ValidateEditGroupDateUpdated(string gName)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(grpName, gName+1, "Group Name");
            driver.sleepTime(3000);
            driver.ClickElement(btnFinish, "Finish");
            driver.ClickElement( By.XPath("//span[contains(.,'" + gName + "')]"), "");
            driver.CheckElementDisplayed(updatedDate, "Updated Date");
            driver.GetElementText(updatedDate);
        }

        public void ValidateEditGroupAddEndpointLastDate(string gName)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(grpName, gName+5, "Group Name");
            driver.sleepTime(3000);
            driver.ClickElement(btnAddEndpoint, "Endpoint");
            driver.CheckElementDisplayed(header, "Search Endpoint");
            driver.CheckElementDisplayed(groupsDisplay,"Groups Display");
        }
        public void ValidateGroupsList()
        {
            driver.CheckElementDisplayed(groupsList, "Groups List");
        }
        public void ValidateAccountsList()
        {
            driver.CheckElementDisplayed(groupsDisplay, "Groups Display");
        }
        public void ValidateGroupsPorperties(string gName)
        {
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'" + gName + "')]"), "Group Name");
            driver.CheckElementDisplayed(updatedDate,"Date");
            driver.CheckElementDisplayed(endpoints, "Endpoints");
        }

        public void ValidateGroupsSortOrder()
        {
            driver.CheckElementDisplayed(drpDowngroupNamesort, "Sort Order");
        }

        public void ValidateGroupsSortOrderValues()
        {
            driver.ClickElement(drpDowngroupNamesort, "Sort Order Dropdown");
            driver.CheckElementDisplayed(drpDownAccName, "Group Name");
            driver.CheckElementDisplayed(drpDownAccNo, "Last Updated");
            driver.CheckElementDisplayed(drpDownAddress, "Endpoints");
        }
        public void ValidateSortOrderInProcessing(string group)
        {
            //driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            driver.SendKeysToElement(By.XPath("//input[@id='account_number']"), "1", "AccountNo");
            driver.ClickElement(drpDownsort, "Dropdown");
            driver.ClickElement(drpDownAccNo, "Account Number");
            //driver.WaitForElement(sortOrderProcessing, TimeSpan.FromSeconds(5));
            //driver.CheckElementDisplayed(sortOrderProcessing, "Sort Order Prosessing");
        }

        public void ValidateGroupNameSorting()
        {
            driver.ClickElement(drpDowngroupNamesort, "Sort Order");
            driver.ClickElement(groupNameSort, "Group Name");
        }
        public void ValidateGroupNamePartialSearch()
        {
            driver.SendKeysToElement(searchGroupTextBox, "Test","Group Name");
            driver.sleepTime(5000);
        }
        public void ValidateGroupNameExactSearch(string groupName)
        {
            driver.SendKeysToElement(searchGroupTextBox, groupName, "Group Name");
            driver.sleepTime(5000);
        }

        public void ValidateGroupNameEndpointSearch(string groupName)
        {
            driver.SendKeysToElementAndPressEnter(searchGroupEndpoint, groupName, "Group Name");
            driver.WaitForElement(select1st, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(select1st, "Endpoint");
        }

        public void ValidateGroupNameScrollBar()
        {
            driver.MouseHoverByJavaScript(updatedDate, "");
            driver.ScrollToPageTop();
            driver.sleepTime(5000);
        }

        public void ValidateSelectGroup(string grpname)
        {
            driver.ClickElement(By.XPath("//span[contains(.,'" + grpname + "')]"), "");
        }
        public void ValidateGroupDescription(string grpname)
        {
            driver.ClickElement(By.XPath("//span[contains(.,'" + grpname + "')]"), "");
            driver.CheckElementDisplayed(groupDescription, "Group Description");
        }
        public void ValidateEndpointList()
        {
            driver.WaitForElement(endpointList, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(endpointList, "Endpoint List");
        }

        public void ValidateRemoveEndpoint(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint"))
            {
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            }
            driver.ClickElement(select1st, "Endpoint List");
            driver.CheckElementDisplayed(removeEndpoint, "Remove Endpoint");
        }
        public void ValidateMultipleEndpointRemove(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            //driver.ClickElement(By.XPath("//span[@class='k-input-value-text']"), "selectdpoints");
            //driver.sleepTime(3000);
            //driver.ClickElement(By.XPath("//span[text()='# Endpoints']"), "clickoption");
           // driver.sleepTime(3000);
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint"))
            {
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            }
            driver.ClickElement(select1st, "Select 1st");
            driver.ClickElement(select2nd, "Select 2nd");
            driver.IsElementEnabled(removeEndpoint, "Remove Endpoint");
        }
        public void ValidateAllEndpointRemove(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint"))
            {
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            }
            driver.ClickElement(drpdownmultiSelect, "Dropdown");
            driver.ClickElement(selectAll, "Select All");
            driver.IsElementEnabled(removeEndpoint, "Remove Endpoint");
        }
        public void ValidateRemoveEndpointConfirmationDialog(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint"))
            {
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            }
            driver.ClickElement(select1st, "Select 1st");
            driver.ClickElement(removeEndpoint, "Remove Endpoint");
            driver.CheckElementDisplayed(removeEndpointDialog, "Confirmation message is displayed");
            driver.ClickElement(btnCancel, "");
        }

        public void ValidateRemoveEndpointSuccessToast(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint"))
            {
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            }
            driver.ClickElement(select1st, "Select 1st");
            driver.ClickElement(removeEndpoint, "Remove Endpoint");
            driver.ClickElement(deleteConfirm, "Delete");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Success");
        }

        public void ValidateRemoveEndpointLastUpdatedDate(string group)
        {

            driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint"))
            {
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            }
            driver.ClickElement(select1st, "Select 1st");
            driver.ClickElement(removeEndpoint, "Remove Endpoint");
            driver.ClickElement(deleteConfirm, "Delete");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Success");
            driver.sleepTime(14000);
            driver.CheckElementDisplayed(updatedDate, "Current Date is displayed"+ driver.GetElementText(updatedDate).ToString());
        }

        public void ValidateEndpointDefaultValue(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint"))
            {
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, group, "searchGroup");
            }
            driver.ClickElement(select1st, "Select 1st");
            driver.CheckElementDisplayed(endpointClassificationValue, "Default Value is : " +driver.GetElementText(endpointClassificationValue));
        }
        public void ValidateClassificationValues(string group)
        {
            driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            driver.ClickElement(select1st, "Select 1st");
            driver.ClickElement(btnClassification, "Classification");
            driver.ClickElement(drpdownClassification, "Dropdown");
            driver.CheckElementDisplayed(classificationInput, "Input");
            driver.CheckElementDisplayed(classificationConsum, "Consumption");
            driver.CheckElementDisplayed(classificationNonConsum, "Non-Consumption");
            driver.CheckElementDisplayed(classificationOutput, "Output");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditClassification(string group)
        {
            driver.ClickElement(By.XPath("//span[contains(.,'" + group + "')]"), "");
            
            driver.ClickElement(select1st, "Select 1st");
            driver.ClickElement(btnClassification, "Classification");
            driver.ClickElement(drpdownClassification, "Dropdown");
            driver.ClickElement(classificationInput, "Input");
            driver.ClickElement(btnOK, "OK");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Success");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(endpointClassificationValue, "Default Value is : " + driver.GetElementText(endpointClassificationValue));
        }
        public void ValidateBatchEditClassification(string group)
        {
            driver.ClickElement(By.XPath("//span[text()='"+ group+"']"), "");
            driver.ClickElement(select1st, "Select 1st"); 
            driver.ClickElement(select2nd, "Select 2nd");
            driver.ClickElement(btnClassification, "Classification");
            driver.ClickElement(drpdownClassification, "Dropdown");
            driver.ClickElement(classificationInput, "Input");
            driver.ClickElement(btnOK, "OK");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Success");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(endpointClassificationValue, "Default Value is : " + driver.GetElementText(endpointClassificationValue));
        }

        public void ValidateSearchEndpoints()
        {
            driver.CheckElementDisplayed(header, "Search Endpoints");
            if(driver.GetElementText(header).Contains("Search Endpoints"))
            {
                testReport.Pass("Access to an Advanced Search that allows searching/filtering via multiple fields is displayed");
            }
        }

        public void ValidateAccNoTextBoxDisplay()
        {
            driver.CheckElementDisplayed(accNoTxtBox, "Account Number Text Box");
        }
        public void ValidateAccNameTextBoxDisplay()
        {
            driver.CheckElementDisplayed(accNameTxtBox, "Account Name Text Box");
        }
        public void ValidateAddressTextBoxDisplay()
        {
            driver.CheckElementDisplayed(addressTxtBox, "Address Text Box");
        }
        public void ValidateCityTextBoxDisplay()
        {
            driver.CheckElementDisplayed(cityTxtBox, "City Text Box");
        }
        public void ValidateZipTextBoxDisplay()
        {
            driver.CheckElementDisplayed(zipTxtBox, "Zip Text Box");
        }
        public void ValidateMIUIdTextBoxDisplay()
        {
            driver.CheckElementDisplayed(miuIdTxtBox, "MIU ID Text Box");
        }
        public void ValidateMIUStatusDisplay()
        {
            driver.CheckElementDisplayed(miuStatus, "MIU Status Text Box");
        }
        public void ValidateMeterIDDisplay()
        {
            driver.CheckElementDisplayed(meterIDTxtBox, "Meter ID ");
        }
        public void ValidateMeterSizeDisplay()
        {
            driver.CheckElementDisplayed(meterSize, "Meter Size ");
        }
        public void ValidateMeterSizeValues()
        {
            driver.ClickElement(meterSize, "Meter Size ");
        }
        public void ValidateMeterInstallDateDisplay()
        {
            driver.CheckElementDisplayed(meterInstallDatefrom, "Meter Install Date From ");
        }
        public void ValidateAddToGroupDisplay()
        {
            driver.CheckElementDisplayed(btnAddtoGroup, "Add To Group");
        }

        public void ValidateAddToGroupEnabled()
        {
            driver.ClickElement(endpointListone, "Endpoint");
            
            driver.ClickElement(drpDownselectGroup, "DropDown");
            driver.ClickElement(selectgroupDateTime, "Date Time");
            driver.IsElementEnabled(btnAddtoGroup, "Add To Group");
        }
        public void ValidateAddToGroupConfirmationMessage()
        {
            driver.ClickElement(endpointListone, "Endpoint");
            driver.ClickElement(drpDownselectGroup, "DropDown");
            driver.ClickElement(cctestGroup, "CC Test Group");
            driver.ClickElement(btnAddtoGroup, "Add To Group");
            driver.CheckElementDisplayed(addToGroup, "Add To Group?");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateAddToGroupSingleGroup()
        {
            driver.ClickElement(endpointListone, "Endpoint");
            driver.ClickElement(drpDownselectGroup, "DropDown");
            driver.ClickElement(cctestGroup, "CC Test Group");
        }

        public void ValidateAddToGroupConfirmationToastMessage()
        {
            driver.ClickElement(endpointListone, "Endpoint");
            driver.ClickElement(drpDownselectGroup, "DropDown");
            driver.ClickElement(cctestGroup, "CC Test Group");
            driver.ClickElement(btnAddtoGroup, "Add To Group");
            driver.CheckElementDisplayed(addToGroup, "Add To Group?");
            driver.ClickElement(btnAdd, "Add");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage).ToString());
        }
        public void ValidateAddToGroupRetained()
        {
            driver.ClickElement(endpointListone, "Endpoint");
            driver.ClickElement(drpDownselectGroup, "DropDown");
            driver.ClickElement(cctestGroup, "CC Test Group");
            driver.ClickElement(btnAddtoGroup, "Add To Group");
            driver.CheckElementDisplayed(addToGroup, "Add To Group?");
            driver.ClickElement(btnAdd, "Add");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage).ToString());
            driver.CheckElementDisplayed(endpointListone, "Endpoint Retained");
        }

        public void ValidateGroupManagementNotDisplayed()
        {
            driver.CheckElementDoesnotExists(groups, "Groups");
            driver.CheckElementDoesnotExists(groupManagement, "Group Management");
        }
        public void ValidateAddEndpointNotDisplayed()
        {
            driver.sleepTime(3000);
            driver.CheckElementDoesnotExists(btnAddEndpoint, "Add Endpoint");
        }

        public void ValidateRemoveEndpointNotDisplayed()
        {
            driver.sleepTime(3000);
            driver.CheckElementDoesnotExists(removeEndpoint, "Remove Endpoint");
        }
        public void ValidateClassificationNotDisplayed()
        {
            driver.sleepTime(3000);
            driver.CheckElementDoesnotExists(btnClassification, "Classification"); ;
        }
        public void ValidateSearchEndPointsNotDisplayed()
        {
            driver.ClickElement(groups, "Groups");
            driver.ClickElement(groupManagement, "Group Management");
            driver.CheckElementDoesnotExists(lftNavSearchEndpoint, "Search Endpoint");
        }

        public void ValidateDeleteButtonNotDisplayed()
        {
            driver.sleepTime(3000);
            driver.CheckElementDoesnotExists(btnDelete, "Delete");
        }

        public void ValidateCreateButtonNotDisplayed()
        {
            driver.sleepTime(3000);
            driver.CheckElementDoesnotExists(btnCreate, "Create");
        }

        public void ValidateEditButtonNotDisplayed()
        {
            driver.sleepTime(3000);
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }
        public void ValidateAddToGroupDefaultValue()
        {
            driver.SendKeysToElement(accNoTxtBox, "1", "Acc No");
            driver.ClickElement(btnAdvanceSearch, "Search");

            driver.ClickElement(endpointListone, "Endpoint");
            driver.ClickElement(drpDownselectGroup, "DropDown");
            driver.ClickElement(cctestGroup, "CC Test Group");
            driver.ClickElement(btnAddtoGroup, "Add To Group");
            driver.CheckElementDisplayed(addToGroup, "Add To Group?");
            driver.ClickElement(btnAdd, "Add");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage).ToString());

           driver.ClickElement(groupManagement, "Group Management");
            driver.CheckElementDisplayed(updatedDate, "Date");
        }

        public void ValidateEndpointsSortbyAccName()
        {
            //driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            driver.ClickElement(drpdownEndpoint, "Dropdown");
            driver.ClickElement(drpDownAccName, "Account Name");
            IReadOnlyList<IWebElement> noofaccs=driver.FindElements(sortedAccountNumber);
            int initialno = 0;
            for(int i = 0; i <= noofaccs.Count; i++)
            {
                string text=(noofaccs[0].Text).Trim();
                 string[] subtext=text.Split(':');
                String numbersOnly = Regex.Replace(subtext[1], @"[^\d]", String.Empty);
                int accno = Int32.Parse(numbersOnly);
                if (!(accno > initialno))
                {
                    ReporterFactory.LogFailure("account nos are not sorted");
                }
            }
           // driver.CheckElementDisplayed(sortedEndpoints, "Sorted Endpoints");
        }

        public void ValidateEndpointsSortbyAccName(string group)
        {
            driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            driver.ClickElement(drpDownsort, "Dropdown");
            driver.ClickElement(drpDownAccName, "Account Name");
            IReadOnlyList<IWebElement> noofaccs = driver.FindElements(sortedAccountNumber);
            int initialno = 0;
            for (int i = 0; i <= noofaccs.Count; i++)
            {
                string text = (noofaccs[0].Text).Trim();
                string[] subtext = text.Split(':');
                String numbersOnly = Regex.Replace(subtext[1], @"[^\d]", String.Empty);
                int accno = Int32.Parse(numbersOnly);
                if (!(accno > initialno))
                {
                    ReporterFactory.LogFailure("account nos are not sorted");
                }
            }
            // driver.CheckElementDisplayed(sortedEndpoints, "Sorted Endpoints");
        }

        public void ValidateEndpointsSortbyAccNumber(string group)
        {
            driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            driver.ClickElement(drpdownEndpoint, "Dropdown");
            driver.ClickElement(drpDownAccNo, "Account Name");
            IReadOnlyList<IWebElement> noofaccs = driver.FindElements(sortedAccountNumber);
            int initialno = 0;
            for (int i = 0; i <= noofaccs.Count; i++)
            {
                string text = (noofaccs[0].Text).Trim();
                string[] subtext = text.Split(':');
                String numbersOnly = Regex.Replace(subtext[1], @"[^\d]", String.Empty);
                int accno = Int32.Parse(numbersOnly);
                if (!(accno > initialno))
                {
                    ReporterFactory.LogFailure("account nos are not sorted");
                }
            }
        }
        public void ValidateEndpointsSortDropdowndisplays(string group)
        {
            driver.SendKeysToElement(By.CssSelector("#account_number"),group,"Accountno");
            driver.ClickElement(By.XPath("//input[@name='search']"), "searchbutton");
            //driver.ClickElement(drpDownsort, "Dropdown");
            //driver.ClickElement(drpDownAccNo, "Account Number");
            //driver.CheckElementDisplayed(sortedEndpoints, "Sorted Endpoints");
            driver.CheckElementDisplayed(drpDownsort, "Sort Dropdown");
            driver.CheckElementDisplayed(drpDownMultiSelectEndpoint, "multiselectoption");
        }
        public void ValidateEndpointsSortbyAddress()
        {
            driver.ClickElement(drpDownsort, "Dropdown");
            driver.ClickElement(drpDownAddress, "Address");
            driver.CheckElementDisplayed(sortedEndpoints, "Sorted Endpoints");
        }
        public void ValidateEndpointsSortbyMiuId()
        {
            driver.ClickElement(drpDownsort, "Dropdown");
            driver.ClickElement(drpDownmiuId, "MIU Id");
            driver.CheckElementDisplayed(sortedEndpoints, "Sorted Endpoints");
        }
        public void ValidateEndpointsSortbyMeterId()
        {
            driver.ClickElement(drpDownsort, "Dropdown");
            driver.ClickElement(drpDownmeterId, "Meter Id");
            driver.CheckElementDisplayed(sortedEndpoints, "Sorted Endpoints");
        }
        public void ValidateEndpointsSortbyMeterSize()
        {
            driver.ClickElement(drpDownsort, "Dropdown");
            driver.ClickElement(drpDownmeterSize, "Meter Size");
            driver.CheckElementDisplayed(sortedEndpoints, "Sorted Endpoints");
        }
        public void ValidateEndpointsSelectOptionDisplays()
        {
            driver.ClickElement(drpDownMultiSelectEndpoint, "Dropdown");
            driver.CheckElementDisplayed(selectAll, "Select All");
            driver.CheckElementDisplayed(deselectAll, "Deselect All");
            driver.CheckElementDisplayed(selectPage, "Select Page");
        }
        public void ValidateEndpointsSelectAll()
        {
            driver.ClickElement(drpDownMultiSelectEndpoint, "Dropdown");
            driver.ClickElement(selectAll, "Select All");
            //driver.CheckElementDisplayed(deselectAll, "Deselect All");
            //driver.CheckElementDisplayed(selectPage, "Select Page");
        }
        public void ValidateEndpointsDeselectAll()
        {
            driver.ClickElement(drpDownMultiSelectEndpoint, "Dropdown");
            //driver.ClickElement(selectAll, "Select All");
            driver.CheckElementDisplayed(deselectAll, "Deselect All");
            //driver.CheckElementDisplayed(selectPage, "Select Page");
        }
        public void ValidateEndpointsSelectPage()
        {
            driver.ClickElement(drpDownMultiSelectEndpoint, "Dropdown");
            driver.CheckElementDisplayed(selectPage, "Select Page");
        }
        public void ValidateEndpointsSelectionRetainedAllPage()
        {
            driver.ClickElement(endpointListone, "Endpoint"); 
            driver.ClickElement(searchEndpointNextPage, "Next Page");
            driver.ClickElement(searchEndpointPreviousPage, "Previous Page");
            driver.CheckElementDisplayed(endpointListone, "Retained Selected Endpoints");
        }


        public void ValidateAddToGroupDefaultValueSelectAnotherGroup()
        {
            driver.SendKeysToElement(accNoTxtBox, "1", "Acc No");
            driver.ClickElement(btnAdvanceSearch, "Search");

            driver.ClickElement(endpointListone, "Endpoint");
            driver.ClickElement(drpDownselectGroup, "DropDown");
            driver.ClickElement(cctestGroup, "CC Test Group");
            driver.ClickElement(btnAddtoGroup, "Add To Group");
            driver.CheckElementDisplayed(addToGroup, "Add To Group?");
            driver.ClickElement(btnAdd, "Add");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage).ToString());

            driver.ClickElement(groupManagement, "Group Management");
            driver.ClickElement(select2ndGroup, "Another Group");
        }

        public void ValidateSelectAllAddToGroupEnabled()
        {
            driver.ClickElement(drpDownMultiSelectEndpoint, "Dropdown");
            driver.ClickElement(multiSelectALl, "Select All");
            driver.ClickElement(drpDownselectGroup, "DropDown");
            driver.ClickElement(cctestGroup, "CC Test Group"); 
            driver.IsElementEnabled(btnAddtoGroup, "Add To Group");
        }
        public void ValidateSelectDropdownEnabled()
        {
            driver.ClickElement(select1stgrp, "Select ");
            driver.CheckElementDisplayed(drpDownselectGroup, "DropDown");
        }

        public void ValidateAdvanceSearchButtonDisplay()
        {
            driver.CheckElementDisplayed(btnAdvanceSearch, "Advance Search Button");
        }
        public void ValidateAdvanceSearchButtonAccess()
        {
            driver.SendKeysToElement(accNoTxtBox, "1", "Acc No");
            driver.ClickElement(btnAdvanceSearch, "Advance Search Button");
            driver.WaitForElement(advanceSeachEndpoint,TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
        }
        public void ValidateAccNameSortOrder()
        {
            driver.SendKeysToElement(accNameTxtBox, "A", "Acc Name");
            driver.ClickElement(btnAdvanceSearch, "Advance Search Button");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            testReport.Pass("Search results matching the Account Name  entered are displayed");
        }
        public void ValidateAddressSortOrder()
        {
            driver.SendKeysToElement(addressTxtBox, "A", "Address");
            driver.ClickElement(btnAdvanceSearch, "Advance Search Button");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            testReport.Pass("Search results matching the Account Name  entered are displayed");
        }

        public void ValidateMIUidSortOrder()
        {
            driver.SendKeysToElement(miuIdTxtBox, "2", "MIU ID");
            driver.ClickElement(btnAdvanceSearch, "Advance Search Button");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            testReport.Pass("Search results matching the Account Name  entered are displayed");
        }
        public void ValidateMeterIdSortOrder()
        {
            driver.SendKeysToElement(meterIDTxtBox, "2", "Meter ID");
            driver.ClickElement(btnAdvanceSearch, "Advance Search Button");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            testReport.Pass("Search results matching the Account Name  entered are displayed");
        }

        public void ValidateEndpointsAssociatedOneGroup()
        {
            driver.ClickElement(groupSearchDrpdown,"Dropdown");
            driver.ClickElement(cctestGroup, "Select Group");
            driver.ClickElement(btnAdvanceSearch, "Advance Search Button");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            testReport.Pass("Search results matching the Account Name  entered are displayed");
        }

        public void ValidateRoutesDropdownDisplays()
        {
            driver.CheckElementDisplayed(routesDrpdown, "Routes Dropdown");
        }
        public void ValidateRoutesDropdownValues()
        {
            driver.WaitForElement(routesDrpdown, TimeSpan.FromSeconds(35));
            driver.ClickElement(routesDrpdown, "Routes Dropdown");
            driver.Navigate().Refresh();
        }
        public void ValidateRoutesDropdownSelected()
        {
            driver.ClickElement(routesDrpdown, "Routes Dropdown");
            driver.ClickElement(cctestGroup, "Select");
        }
        public void ValidateRoutesDropdownSelectedSearchResults()
        {
            driver.ClickElement(routesDrpdown, "Routes Dropdown");
            driver.ClickElement(cctestGroup, "Select");
            driver.ClickElement(btnAdvanceSearch, "Search ");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            testReport.Pass("Search results matching the criteria  entered are displayed");
        }
        public void ValidateRoutesDropdownSelectedSearchResultsOtherCriteria()
        {
            driver.ClickElement(routesDrpdown, "Routes Dropdown");
            driver.ClickElement(cctestGroup, "Select");
            driver.ClickElement(btnAdvanceSearch, "Search ");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            driver.SendKeysToElement(accNoTxtBox, "1", "Acc No");
            driver.ClickElement(btnAdvanceSearch, "Search");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
        }

        public void ValidateResetButtonDisplayed()
        {
            driver.CheckElementDisplayed(btnReset, "Reset");
        }
        public void ValidateResetButtonConfirmationDialog()
        {
            driver.ClickElement(btnReset, "Reset");
            driver.CheckElementDisplayed(resetDialog, "Reset Dialog box");
            driver.ClickElement(btnCancel, "");
        }
        public void ValidateResetButtonFieldsCleared()
        {
            driver.ClickElement(routesDrpdown, "Routes Dropdown");
            driver.ClickElement(cctestGroup, "Select");
            driver.ClickElement(btnAdvanceSearch, "Search");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.ClickElement(btnReset, "Reset");
            driver.CheckElementDisplayed(resetDialog, "Reset Dialog box");
            driver.ClickElement( btnReseConfirm, "Reset");
        }
        public void ValidateResetButtonSelectedFieldsCleared()
        {
            driver.ClickElement(endpointListone, "Endpoint");
            driver.ClickElement(btnReset, "Reset");
            driver.CheckElementDisplayed(resetDialog, "Reset Dialog box");
            driver.ClickElement(btnReseConfirm, "Reset");
        }
        public void ValidateMeterSizeSortOrder()
        {
            driver.ClickElement(meterSize, "Meter Size Drop Down");
            driver.ClickElement(By.XPath("//kendo-list/div/ul/li[3]")," Size");
            driver.ClickElement(btnAdvanceSearch, "Advance Search Button");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            testReport.Pass("Search results matching the Account Name  entered are displayed");
        }

        public void ValidateDefaultSortOrder ()
        {
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromMinutes(1));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "Endpoint List");
            testReport.Pass("Search results are sorted alphabetically by Account Name by default");
        }
        public void ValidateClassificationBtnEnable(string group)
        {
            driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            driver.ClickElement(select1st, "Select 1st");
            driver.IsElementEnabled(btnClassification, "Classification");
        }
        public void ValidateClassificationBtnDisable(string group)
        {
            driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            //driver.ClickElement(select1st, "Select 1st");
            driver.IsElementDisabled(btnClassification, "Classification");
        }

        public void ValidateEndpointProperties()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            driver.CheckElementDisplayed(accNameEndpoint, "Acc Name");
            driver.CheckElementDisplayed(accNoEndpoint, "Acc No");
            driver.CheckElementDisplayed(meterNoEndpoint, "Meter No");
            driver.CheckElementDisplayed(addressEndpoint, "Address");
            driver.CheckElementDisplayed(metersizeEndpoint, "Meter Size");
            //driver.CheckElementDisplayed(classificationEndpoint, "Classification");
            driver.CheckElementDisplayed(miuidEndpoint, "Miu ID");
        }
        public void ValidateDefaultEndpointSortorder()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.CheckElementDisplayed(drpdownEndpoint, "Endpoint Dropdown");
            if (driver.GetElementText(drpdownEndpoint).Contains("Account Name"))
            {
                testReport.Pass("By default, the list of Endpoints are sorted by Account Name");
            }
            else
            {
                ReporterFactory.LogFailure("By default, the list of Endpoints are not sorted by Account Name");
            }
        }

        public void ValidateEndpointSortorderAccNo()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            driver.ClickElement(accNoEndpoint, "Account Number");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(drpdownEndpoint, "Displayed is: "+driver.GetElementText(drpdownEndpoint));
        }
        public void ValidateEndpointSortorderAddress()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            driver.ClickElement(addressEndpoint, "Address");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(drpdownEndpoint, "Displayed is: " + driver.GetElementText(drpdownEndpoint));
        }
        public void ValidateEndpointSortorderMIUID()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            driver.ClickElement(miuidEndpoint, "MIU ID");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(drpdownEndpoint, "Displayed is: " + driver.GetElementText(drpdownEndpoint));
        }
        public void ValidateEndpointSortorderMeterID()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            driver.ClickElement(meterNoEndpoint, "Meter ID");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(drpdownEndpoint, "Displayed is: " + driver.GetElementText(drpdownEndpoint));
        }
        public void ValidateEndpointSortorderMeterSize()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            driver.ClickElement(metersizeEndpoint, "Meter Size");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(drpdownEndpoint, "Displayed is: " + driver.GetElementText(drpdownEndpoint));
        }
        public void ValidateEndpointSortorderClassification(string group)
        {
            driver.ClickElement(By.XPath("//span[contains(.,'" + group + "')]"), "");
            driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            driver.ClickElement(classificationEndpoint, " Classification");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(By.XPath("//span[contains(text(),'Sort By:')]/..//kendo-dropdownlist//span[text()='Classfication']"),"Classification");
        }

        public void ValidateEndpointSortOneLevel()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            driver.ClickElement(accNoEndpoint, "Account Number");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(By.XPath("//span[contains(text(),'Sort By:')]/..//kendo-dropdownlist//span[text()='Account Number']"), "Classification");
            //driver.ClickElement(endpointxpath, "Endpoints");
            //driver.ClickElement(drpdownEndpoint, "Endpoint Dropdown");
            if (driver.CheckElementDoesnotExists(metersizeEndpoint, "metersize"))
            {
                testReport.Pass("Sorting can be done by only one field at a given time");
            }
            else
            {
                ReporterFactory.LogFailure("multiple elements are able to select but only one option should be selectable in the sortby dropdownlist");
            }
           // driver.ClickElement(metersizeEndpoint, "Meter Size");
            //driver.ClickElement(classificationEndpoint, " Classification");
            //driver.sleepTime(5000);
            //driver.CheckElementDisplayed(drpdownEndpoint, "Displayed is: " + driver.GetElementText(drpdownEndpoint));
            
        }

        public void ValidateGroupMembersSelectOption()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownmultiSelect, "Multiselect Dropdown");
            driver.CheckElementDisplayed(selectAll, "Select All");
            driver.CheckElementDisplayed(deselectAll, "Deselect All");
            driver.CheckElementDisplayed(selectPage, "Page Select;");
        }
        public void ValidateGroupMembersSelectPage()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownmultiSelect, "Multiselect Dropdown");
            driver.ClickElement(selectPage, "Select Page");
            testReport.Pass("All the Group members in the current page are selected");
        }
        public void ValidateGroupMembersSelectAll()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownmultiSelect, "Multiselect Dropdown");
            driver.ClickElement(selectAll, "Select All");
            testReport.Pass("All the Group members related to the Group are selected");
        }

        public void ValidateGroupMembersDeselectAll()
        {
            driver.ClickElement(endpointxpath, "Endpoints");
            driver.ClickElement(drpdownmultiSelect, "Multiselect Dropdown");
            driver.ClickElement(deselectAll, "Deselect All");
            testReport.Pass("All the selections made are cleared");
        }

        public void ValidateSelectCountUpdate(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, "Automation", "searchGroup");
            driver.ClickElement(select1st, "Select Group 1");
            driver.ClickElement(select2nd, "Select Group 2");
            testReport.Pass("Selected count is updated: " + driver.GetElementText(selectedGroups));
        }

        public void ValidateDeselectCountUpdate(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, "Automation", "searchGroup");
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint")){
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, "Automation", "searchGroup");
            }
            driver.ClickElement(select1st, "Select Group 1");
            driver.ClickElement(select2nd, "Select Group 2");
            testReport.Pass("Selected count is updated: " + driver.GetElementText(selectedGroups));
            driver.ClickElement(select1st, "Select Group 1");
            testReport.Pass("Selected count is updated: " + driver.GetElementText(selectedGroups));
        }

        public void ValidateRetainedPage(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, "Automation", "searchGroup");
            if (!driver.CheckElementDisplayed(select1st, "firstendpoint"))
            {
                driver.Navigate().Refresh();
                driver.WaitForElement(searchgroupxpath, TimeSpan.FromSeconds(30));
                driver.SendKeysToElement(searchgroupxpath, "Automation", "searchGroup");
            }
            driver.ClickElement(endpointNextPage, "Next Page");
            driver.WaitForElement(endpointNextPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(endpointNextPage, "Previous Page");
            testReport.Pass("Selections made in Step 5 are retained");
        }
        public void ValidateNoEndpointExist(string group)
        {
            //driver.ClickElement(By.XPath("//span[contains(.,'" + group + "')]"), "");
            driver.SendKeysToElement(By.XPath("//input[@name='txtGroupsSearch']"), group, "groupnamesearch");
            driver.ClickElement(By.XPath("//span[@class='k-input-value-text']"),"selectdpoints");
            driver.ClickElement(By.XPath("//span[text()='# Endpoints']"), "clickoption");
            driver.WaitForElement(noEndpoint, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(noEndpoint, "Group has no Endpoints");
        }
        public void ValidateNoEndpointAddEndpoint(string group)
        {
            driver.SendKeysToElement(By.XPath("//input[@name='txtGroupsSearch']"), group, "groupnamesearch");
            driver.ClickElement(By.XPath("//span[@class='k-input-value-text']"), "selectdpoints");
            driver.ClickElement(By.XPath("//span[text()='# Endpoints']"), "clickoption");
            driver.WaitForElement(noEndpoint, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(noEndpoint, "Group has no Endpoints");
            driver.CheckElementDisplayed(btnAddEndpoint, "Add Endpoint");
        }
        public void ValidateNoEndpointAddEndpointAccess(string group)
        {
            driver.ClickElement(By.XPath("//span[contains(.,'" + group + "')]"), "");
            driver.WaitForElement(noEndpoint, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(noEndpoint, "Group has no Endpoints");
            driver.ClickElement(btnAddEndpoint, "Add Endpoint");
            driver.CheckElementDisplayed(header, "Search Endpoints");
        }

        public void ValidateNoEndpointExistCreateButtonEnabled(string group)
        {
            driver.SendKeysToElement(By.XPath("//input[@name='txtGroupsSearch']"), group, "groupnamesearch");
            driver.sleepTime(4000);
            driver.ClickElement(By.XPath("//span[@class='k-input-value-text']"), "selectdpoints");
            driver.ClickElement(By.XPath("//span[text()='# Endpoints']"), "clickoption");
            driver.CheckElementDisplayed(noEndpoint, "Group has no Endpoints");
            driver.CheckElementDisplayed(btnCreate, "Create");
        }

        public void ValidateNoEndpointExistCreateButtonAccess(string group)
        {
            driver.SendKeysToElement(By.XPath("//input[@name='txtGroupsSearch']"), group, "groupnamesearch");
            driver.sleepTime(4000);
            driver.ClickElement(By.XPath("//span[@class='k-input-value-text']"), "selectdpoints");
            driver.ClickElement(By.XPath("//span[text()='# Endpoints']"), "clickoption");
            driver.sleepTime(4000);
            driver.CheckElementDisplayed(noEndpoint, "Group has no Endpoints");
            driver.ClickElement(btnCreate, "Create");
        }

        public void ValidateNoGroupExist(string utility)
        {
            driver.ClickElement(lnkChooseUtilities, "Utilities Dropdown");
            driver.SendKeysToElementAndPressEnter(utilitySearch, utility, "Utility");
            driver.ClickElement(tblChooseUtilities, "Select");
            driver.ClickElement(btnChooseUtilitiesOk, "OK");
            driver.CheckElementDisplayed(noGroupExist, "NO GROUP EXIST YET");
        }


        public void ValidateEndpointPageThrough(string group)
        {
            driver.SendKeysToElement(searchgroupxpath, group, "searchgroup");
            driver.CheckElementDisplayed(endpointNextPage, "Endpoint NextPage");
        }
        public void ValidateSearchEndpointPageThrough()
        {
            driver.CheckElementDisplayed(searchEndpointNextPage, "Search Endpoint NextPage");
        }
        public void ValidateSearchEndpointPageThroughAccess()
        {
            driver.ClickElement(searchEndpointNextPage, "Search Endpoint NextPage");
            testReport.Pass("Next set of Endpoints are displayed");
        }
        public void ValidateEndpointSearchEndpointPageThrough()
        {
            driver.SendKeysToElement(accNameTxtBox, "A", "Account Name");
            driver.ClickElement(btnAdvanceSearch, "Search");
            driver.WaitForElement(searchEndpointNextPage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(searchEndpointNextPage, "Search Endpoint NextPage");
        }
        public void ValidateEndpointSearchEndpointPageThroughAccess()
        {
            driver.SendKeysToElement(accNameTxtBox, "A", "Account Name");
            driver.ClickElement(btnAdvanceSearch, "Search");
            driver.WaitForElement(searchEndpointNextPage, TimeSpan.FromSeconds(20));
            driver.ClickElement(searchEndpointNextPage, "Search Endpoint NextPage");
        }
        public void ValidateAccNameMaxCharacterSearchResults(string accountNumber)
        {
            driver.SendKeysToElement(accNoTxtBox, accountNumber, "Account Number");
        }
        public void ValidateAccNoMaxCharacterSearchResults(string accountName)
        {
            driver.SendKeysToElement(accNameTxtBox, accountName, "Account Name");
        }
        public void ValidateAddressMaxCharacterSearchResults(string address)
        {
            driver.SendKeysToElement(addressTxtBox, address, "Address");
        }
        public void ValidateMIUIDMaxCharacterSearchResults(string miuID)
        {
            driver.SendKeysToElement(miuIdTxtBox, miuID, "miuID");
        }
        public void ValidateMeterIDMaxCharacterSearchResults(string meter)
        {
            driver.SendKeysToElement(meterIDTxtBox, meter, "Meter ID");
        }
        public void ValidateCityMaxCharacterSearchResults(string city)
        {
            driver.SendKeysToElement(cityTxtBox, city, "City");
        }
        public void ValidateZipCharacterSearchResults(string zip)
        {
            driver.SendKeysToElement(zipTxtBox, zip, "zip");
            
        }
        public void ValidateZipCharacterUSSupport(string zip)
        {
            driver.SendKeysToElementAndPressEnter(zipTxtBox, zip, "zip");
        }

        public void ValidateEndpointSearchEndpointLastPageAccess()
        {
            driver.SendKeysToElement(accNameTxtBox, "A", "Account Name");
            driver.ClickElement(btnAdvanceSearch, "Search");
            driver.WaitForElement(searchEndpointNextPage, TimeSpan.FromSeconds(20));
            driver.ClickElement(searchEndpointLastPage, "Search Endpoint Last Page");
            driver.CheckElementDisplayed(advanceSeachEndpoint, "List of all Endpoints in the Group are displayed");
        }
        public void ValidateMiuStatusSearchResults()
        {
            driver.ClickElement(miuStatusActive, "MIU Status");
            driver.ClickElement(btnAdvanceSearch, "Search");
            //driver.WaitForElement(searchEndpointNextPage, TimeSpan.FromSeconds(20));
            //driver.ClickElement(searchEndpointLastPage, "Search Endpoint Last Page");
            driver.CheckElementDisplayed(advanceSeachEndpoint, "List of all Endpoints in the Group are displayed");
        }
        public void ValidateFromDateSearchResults()
        {
            driver.ClickElement(meterInstallDatefrom, "");
            //driver.SendKeysToElement(meterInstallDatefrom, "5/10/2019", "From Date");
            //driver.ClickElement(btnAdvanceSearch, "Search");
            //driver.WaitForElement(searchEndpointNextPage, TimeSpan.FromSeconds(20));
            //driver.ClickElement(searchEndpointLastPage, "Search Endpoint Last Page");
            driver.CheckElementDisplayed(advanceSeachEndpoint, "List of all Endpoints in the Group are displayed");
        }
        public void ValidateSearchEndpointLastPage()
        {
            driver.ClickElement(searchEndpointLastPage, "Search Endpoint NextPage");
            driver.WaitForElement(advanceSeachEndpoint, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(advanceSeachEndpoint, "List of all Endpoints in the Group are displayed");
            testReport.Pass("Next set of Endpoints are displayed");
        }
        public void ValidateSearchEndpointProperties()
        {
            driver.CheckElementDisplayed(accNameTxtBox, "Acc Name");
            driver.CheckElementDisplayed(accNoTxtBox, "Acc No");
            driver.CheckElementDisplayed(miuStatus, "MIU Id");
            driver.CheckElementDisplayed(addressTxtBox, "Address");
            driver.CheckElementDisplayed(meterSize, "Meter No");
        }
        public void ValidateSearchEndpointMeterInstallDate()
        {
            driver.CheckElementDisplayed(meterInstallDatefrom, "Date text in Meter Installation Date is visible");
        }


        public void ValidateEndpointsSortOrder()
        {
            driver.ClickElement(drpDowngroupNamesort, "Sort Order");
            driver.CheckElementDisplayed(endpointSort, "Endpoint Sort Order");
        }

        public void ValidateLastUpdatedSortOrder()
        {
            driver.ClickElement(drpDowngroupNamesort, "Sort Order");
            driver.CheckElementDisplayed(lastUpdatedSort, "Last Updated Sort Order");
        }


        public void ValidateEditDescription(string desc)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(description, desc, "Description");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            //if(driver.GetElementText(description).Equals(desc))
            driver.CheckElementDisplayed(description, "");
            string s = driver.GetElementText(description);
            if(driver.CheckElementDisplayed(description, ""))
            {
                testReport.Pass("Group Name updated in Step 5 is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Group Name updated in Step 5 is not displayed"+s);
            }
        }

        public void ValidateEditGroupNameToastMessage(string gName)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(grpName, gName, "Group Name");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));
        }
        public void ValidateGroupNameEditable()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(grpName, "Group Name");
        }
        public void ValidateEditGroupNameAddEndpoint(string gName)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(grpName, gName, "Group Name");
            driver.ClickElement(btnAddEndpoint,"Add Endpoint");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));
        }

        public void ValidateEditGroupNameAddEndpointAccess(string gName)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(grpName, gName, "Group Name");
            driver.ClickElement(btnAddEndpoint, "Add Endpoint");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(header, "Search Endpoints");
        }

        public void ValidateGroupNameErrorMsg(string grpName)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(By.Name("name"), grpName, "Group Name");
            driver.ClickElement(btnFinish, "Finsih");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
            if (driver.GetElementText(toastMessage).Contains("A Group with that name already exists"))
            {
                testReport.Pass("A Group with that name already exists is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("A Group with that name does not exists");
            }
        }

        public void ValidateGroupNameMandatory(string grpName)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(By.Name("name"), grpName, "Group Name");
            driver.CheckElementDisplayed(btnFinish, "Finish");
            testReport.Pass("Group Name field is mandatory");
        }

        public void ValidateGroupDescOptional(string grpName)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(By.Name("name"), grpName, "Group Name");
            driver.CheckElementDisplayed(btnFinish, "Finish");
            testReport.Pass("Group Description field is optional field");
        }

        public void ValidateGroupDescMaxLength(string desc)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(description, desc, "Group Name");
            driver.CheckElementDisplayed(btnFinish, "Finish");
            testReport.Pass("Group Description accepts max length of 200 characters");
        }

        public void ValidateEditGroupDescMaxLength(string desc)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElement(description, desc, "Group Desc");
            driver.CheckElementDisplayed(btnFinish, "Finish");
            testReport.Pass("Group Description accepts max length of 200 characters");
        }

        public void ValidateEditGroupUnchanged(string desc)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElement(description, desc, "Group Desc");
            driver.ClickElement(btnFinish, "Finish");
        }

        public void ValidateEditGroupErrorMsg(string grpname)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(grpName, grpname, "Group Name");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));
        }
        public void ValidateEditGroupNameMandatory(string grpname)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(grpName, grpname, "Group Name");
            driver.CheckElementDisplayed(btnFinish, "Finish");
            testReport.Pass("Group Name field is Mandatory");
        }

        public void ValidateCancelButtonDislay()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
        }
        public void ValidateCancelButtonAccess()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEndpointButtonDislay()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(btnAddEndpoint, "Endpoint");
        }
        public void ValidateGrpPageEndpointButtonDislay()
        {
            driver.CheckElementDisplayed(btnAddEndpoint, "Endpoint");
        }

        public void ValidateCreateGroupSuccessToast(string grpname)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
            testReport.Pass("Green Success toast with following message is displayed" + driver.GetElementText(toastMessage));
        }

        public void ValidateNameinGroupList(string grpname)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
            driver.sleepTime(3000);
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'" + grpname + "')]"), "");
        }

        public void ValidateFinishButtonAccessinGroupList(string grpname)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
            driver.sleepTime(3000);
            driver.CheckElementDisplayed(header, " Default Groups screen is displayed");
        }

        public void ValidateEndpointButtonNotUniqueErrorMsg(string grpname)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(toastMessage, "A Group with that name already exists");
        }

        public void ValidateEndpointButtonNoGrpName(string grpname)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            driver.CheckElementDisplayed(btnAddEndpoint, "Group Name is required");
        }

        public void ValidateAddEndpointButtonAccess(string grpname)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            driver.ClickElement(btnAddEndpoint, "Add Endpoint");
            driver.CheckElementDisplayed(header, driver.GetElementText(header));
        }
        public void ValidateAddEndpointButtonAccess()
        {
            driver.WaitForElement(btnAddEndpoint, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnAddEndpoint, "Add Endpoint");
            driver.CheckElementDisplayed(header, driver.GetElementText(header));
        }
        public void ValidateDeleteButtonDisplay()
        {
            driver.CheckElementDisplayed(btnDelete,"Delete");
        }

        public void ValidateDeleteWarning()
        {
            driver.ClickElement(btnDelete, "Delete");
            driver.CheckElementDisplayed(deleteGrpConfimpopup, "Delete Warning ");
            driver.ClickElement(deleteCancel, "Cancel");
        }

        public void ValidateDeleteDialogContents()
        {
            driver.ClickElement(btnDelete, "Delete");
            driver.CheckElementDisplayed(deleteGrpConfimpopup, "Delete Warning ");
            driver.CheckElementDisplayed(deleteConfirmation, "Confirmation Dialog");
            driver.ClickElement(deleteCancel, "Cancel");
        }

        public void ValidateDeleteDialogCancelButton()
        {
            driver.ClickElement(btnDelete, "Delete");
            driver.CheckElementDisplayed(deleteCancel, "Cancel");
            driver.ClickElement(deleteCancel, "Cancel");
        }

        public void ValidateDeleteDialogDeleteButton()
        {
            driver.ClickElement(btnDelete, "Delete");
            driver.CheckElementDisplayed(btndeleteDialogdelete, "Delete");
            driver.ClickElement(deleteCancel, "Cancel");
        }

        public void ValidateDeleteDialogDeleteAccess()
        {
            driver.ClickElement(btnDelete, "Delete");
            driver.ClickElement(btndeleteDialogdelete, "Delete");
        }
        public void ValidateDeleteGroupToastMsg()
        {
            driver.ClickElement(btnDelete, "Delete");
            driver.ClickElement(btndeleteDialogdelete, "Delete");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));
        }
        public void ValidateEditButtonDisplay()
        {
            driver.CheckElementDisplayed(btnEdit, "Edit");
        }
        public void ValidateEditButtonAccess()
        {
            driver.ClickElement(btnEdit, "Edit");
        }
        public void ValidateMeterNumber(string group)
        {
            driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            driver.WaitForElement(groupListAccNumber, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(groupListmeterNumber, "Meter Number");
        }
        public void ValidateAccNumber(string group)
        {
            driver.ClickElement(By.XPath("//span[text()='" + group + "']"), "");
            driver.WaitForElement(By.XPath("//span[contains(.,'Account Number')][1]"), TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'Account Number')][1]"), "Account Number");
        }

        public void ValidatePremiseIDNotDisplayed()
        {
            driver.CheckElementDoesnotExists(By.Id("Premise"), "PremiseID");
        }
        public void ValidateMulitSelectDropdown()
        {
            driver.WaitForElement(drpDownMultiSelectEndpoint, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(drpDownMultiSelectEndpoint, "Multi Select Dropdown");
        }

        public void ValidateEditCancelDispay()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
        }
        public void ValidateEditCancelAccess()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditDescription()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(description, "", "Description");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage,TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));
        }
        public void ValidateEditAddEndpointDisplay()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnAddEndpoint, "Add Endpoint");
        }

        public void ValidateEditFinishDisplay()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnFinish, "Finish");
        }

        public void ValidateLastUpdatedDateinGroupList(string grpname)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(grpName, grpname, "Group Name");
            driver.ClickElement(btnFinish, "Finish");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
            driver.sleepTime(3000);
            driver.ClickElement(By.XPath("//span[contains(.,'" + grpname + "')]"), "");
            testReport.Info( "Updated Date is " + driver.GetElementText(updatedDate));
        }

        public void ValidateFinishButtonDislay()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(btnFinish, "Finish");
        }

    }
}
