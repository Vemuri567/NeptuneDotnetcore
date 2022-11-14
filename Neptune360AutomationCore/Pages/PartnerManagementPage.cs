using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class PartnerManagementPage : AbstractTemplatePage
    {

        #region UI Object Repository
        private By apiHeaderTitle = By.XPath("//h2[contains(.,'Partner Management')]");
        private By BreadCrumb = By.XPath("//sd-toolbar/div/span/span");
        private By btnCreate = By.XPath("//button[contains(.,'Create')]");
        private By loadingPage = By.XPath("//h4[text()='loading']");
        private By partnerCreateButton = By.XPath("//kendo-dialog-actions//button[text()='Create']");
        private By btnCancel = By.XPath("//button[contains(.,'Cancel')]");
        private By btnEdit = By.XPath("//button[contains(.,'Edit')]");
        private By btnDone = By.XPath("//button[contains(.,'Done')]");
        private By btnSave = By.XPath("//button[contains(.,'Save')]");
        private By btnDelete = By.XPath("//button[contains(.,'Delete')]");
        private By deletePartnerDelete = By.XPath("(//button[@type='button'])[3]");
        private By partnersList = By.XPath("//kendo-grid-list");
        private By partnerOne = By.XPath("//kendo-grid-list//tr[1]/td/p");
        private By partnerTwo = By.XPath("//kendo-grid-list//tr[2]/td/p");
        private By searchBox = By.XPath("//input[@id='handheldSearch']");
        private By searchIcon = By.XPath("//thead/tr[2]/td/div/span");
        private By contactEmail = By.XPath("//h4[contains(.,'Contact Email')]");
        private By contactPhone = By.XPath("//h4[contains(.,' Contact Phone ')]");
        private By contactAddress = By.XPath("//h4[contains(.,' Address ')]");
        private By contactCity = By.XPath("//h4[contains(.,' City ')]");
        private By contactState = By.XPath("//h4[contains(.,' State ')]");
        private By contactZip = By.XPath("//h4[contains(.,' Zip Code ')]");
        private By partnerName = By.XPath("//h3");
        private By clientSecretKey=By.XPath("//h4[contains(.,'Client Secret Key')]");
        private By apiKey=By.XPath("//h4[contains(.,'API Key')]");
        private By utility = By.XPath("//sd-partnermanagement//div[2]/div[2]//kendo-grid-list//td[1]");
        private By siteID = By.XPath("//sd-partnermanagement//div[2]/div[2]//kendo-grid-list//td[2]");
        private By bundle = By.XPath("//sd-partnermanagement//div[2]/div[2]//kendo-grid-list//td[3]");
        private By usagePlan = By.XPath("//sd-partnermanagement//div[2]/div[2]//kendo-grid-list//td[4]");
        private By clientID = By.XPath("//sd-partnermanagement//div[2]/div[2]//kendo-grid-list//td[5]");
        private By createdDate = By.XPath("//sd-partnermanagement//div[2]/div[2]//kendo-grid-list//td[6]");
        private By secretToggle = By.XPath("//td[5]/secret-visibility-toggle/div/div/span");
        private By utilitiesList = By.XPath("//sd-partnermanagement/div/div[2]/div[2]/div[2]/div/div");
        private By nextButton = By.XPath("(//kendo-pager-numeric-buttons//span)[2]");
        private By previousButton = By.XPath("(//kendo-pager-numeric-buttons//span)[1]");
        private By createPartnerPage = By.XPath("//span[contains(.,'Create New Partner')]");
        private By siteIDList = By.XPath("//sd-partnermanagement/form/kendo-dialog/div[2]//div[2]//div[2]//p[1]");
        private By partnerNameFieldBox = By.XPath("//kendo-autocomplete/kendo-searchbar/input");
        private By toastMessage = By.Id("toast-container");
        private By createXButton = By.XPath("//button[@title='Close']");
        private By createXIconButton = By.XPath("//div[2]/button/span");
        private By name = By.Name("name");
        private By email = By.Name("email");
        private By phone = By.Name("phone");
        private By address = By.Name("address");
        private By city = By.Name("city");
        private By state = By.Name("state");
        private By zip = By.Name("zip");
        private By partnerType = By.Name("partnerSelected");
        private By partnerDefaultValue= By.XPath("//kendo-dropdownlist[@name='partnerSelected']//span[@class='k-input-value-text']");
        private By thirdPartyVendor = By.XPath("//li[contains(.,'3rd Party Vendor')]");
        private By selectUtility=By.XPath("//span[contains(.,'Test ')]");
        private By utilitySection = By.XPath("//p[contains(.,'Test ')]");
        private By colUtility = By.XPath("//p[contains(.,'Utility')]");
        private By colSiteID = By.XPath("//p[contains(.,'Site ID')]");
        private By colBundle = By.XPath("//p[contains(.,'Bundle')]");
        private By colUsagePlan = By.XPath("//p[contains(.,'Usage Plan')]");
        private By drpDownBundle = By.XPath("//div[2]/div/div/kendo-dropdownlist/span/span");
        private By drpDownBundleTwo = By.XPath("//div[2]/div/kendo-dropdownlist/span/span");
        private By bundleFromDrpdown = By.XPath("//div/ul/li[2]");
        private By bundleFromDrpdownTwo = By.XPath("//div/ul/li[3]");
        private By editPartnerPage = By.XPath("//span[contains(text(),'Edit Partner')]");
        private By deletePartnerPage = By.XPath("//span[contains(text(),'Delete Partner')]");
        private By deleteSure = By.XPath("//p[contains(.,' delete this partner?')]");
        private By apiKeyShow = By.XPath("//div[2]/secret-visibility-toggle/div/div/span");
        private By errorMessage = By.XPath("//div[text() = ' Only one bundle can be paired with a utility. ']");
        private By defaultUsagePlan = By.XPath("//div/div/div[2]/div/div[2]/div");

        #endregion

        /// <summary>
        /// Method to Validate Title Display
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateTitleDisplay()
        {
            if (driver.GetElementText(apiHeaderTitle).Equals("Partner Management"))
            {
                testReport.Pass("Partner Management Page is Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Partner Management Page is Not Displayed");
            }
        }

        public void ValidateAPIKeyDisplayed()
        {
            driver.WaitForElement(apiKeyShow, TimeSpan.FromSeconds(15));
            driver.ClickElement(apiKeyShow, "Show ");
        }

        public void ValidateBreadCrumbBarDisplay()
        {
            driver.GetElementText(BreadCrumb).Equals("PARTNER MANAGEMENT");
        }

        public void ValidateCreateButton()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(btnCreate,"Create");
        }

        public void ValidateDeleteButton()
        {
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(btnDelete, "Delete");
        }

        public void ValidateEditButton()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(btnEdit, "Edit");
        }

        public void ValidatePartnersList()
        {
            driver.WaitForElement(partnersList, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(partnersList, "Partners List");
        }

        public void ValidateUniquePartnerName()
        {
            driver.WaitForElement(partnerOne, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(partnerOne, "Partners Name");
            driver.CheckElementDisplayed(partnerTwo, "Partner Name");
            testReport.Info("1st Partner Name: "+driver.GetElementText(partnerOne));
            testReport.Info("2nd Partner Name: " + driver.GetElementText(partnerTwo));
        }

        public void ValidateListOfPartnersName()
        {
            driver.WaitForElement(partnerOne, TimeSpan.FromSeconds(20));
            driver.ClickElement(partnerOne, "Partners Name");
            driver.ClickElement(partnerTwo, "Partner Name");
        }

        public void ValidateSearchBox()
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(searchBox, "Partners Name");
            driver.ClickElement(searchBox, "Search Box");
        }

        public void ValidateFullName(string partner)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partner, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.CheckElementDisplayed(partnerOne, "Partner");
        }

        public void ValidatePaginationNext(string partner)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partner, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(nextButton, TimeSpan.FromSeconds(15));
            driver.ClickElement(nextButton, "Next");
        }

        public void ValidatePaginationPrevios(string partner)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partner, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(nextButton, TimeSpan.FromSeconds(15));
            driver.ClickElement(nextButton, "Next");
            driver.ClickElement(previousButton, "Previous");
        }

        public void ValidatePaginationDetails(string partner)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partner, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(nextButton, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(previousButton, "Previous");
            driver.IsElementEnabled(nextButton, "Next");
        }

        public void ValidateCreatePartnerPage()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(createPartnerPage, "Create Partner Page");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateSiteIDNotPresent()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDoesnotExists(siteIDList, "Site ID");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidatePartnerNameSearchBox()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerNameFieldBox, "Partner Name Field Box");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateSearchPartnerName(string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(partnerNameFieldBox,utility, "Partner Name");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateSearchPartnerUtilitySelection(string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(loadingPage, 60);

            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(partnerNameFieldBox, "Import", "Partner Name");
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'Import')]"), "Select Utility");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCreatePartnerXIcon(string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(loadingPage, 60);

            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(partnerNameFieldBox, "Import", "Partner Name");
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'Import')]"), "Select Utility");
            driver.CheckElementDisplayed(createXButton, "X Icon");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCreatePartnerXIconClick(string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(loadingPage, 180);
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(partnerNameFieldBox, "Import", "Partner Name");
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'Import')]"), "Select Utility");
            driver.ClickElement(createXButton, "X Icon");
        }

        public void ValidateCreatePartnerUtilitySection(string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(loadingPage, 180);
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Partner Name");
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'Import')]"), "utilityname");
            driver.ClickElement(By.XPath("//span[contains(.,'Import')]"), "utilityname");
            //driver.CheckElementDisplayed(utilitySection, "Utility Section");
            driver.ClickElement(createXButton, "X Icon");
        }

        public void ValidateCreatePartnerUtilityColumn(string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(loadingPage, 60);
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Partner Name");
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'Import')]"), "utilityname");
            driver.CheckElementDisplayed(colUtility, "Ütility");
            driver.CheckElementDisplayed(colSiteID, "Site ID");
            driver.CheckElementDisplayed(colBundle, "Bundle");
            driver.CheckElementDisplayed(colUsagePlan, "Usage Plan");
            driver.ClickElement(createXButton, "X Icon");

        }

        public void ValidateCreatePartnerBundleUpdate(string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(loadingPage, 60);
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Partner Name");
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'Import')]"), "utilityname");
            driver.ClickElement(drpDownBundle, "Dropdown");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.ClickElement(createXButton, "X Icon");
        }

        public void ValidateCreatePartnerSiteIdNotSelected (string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(loadingPage, 60);
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, "Abc", "Partner Name");
            driver.SendKeysToElement(email, "Abc@email.com", "Ëmail");
            driver.SendKeysToElement(phone, "123456", "Phone");
            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info("Error Message Displayed is: "+ driver.GetElementText(toastMessage));
            driver.ClickElement(createXButton, "X Icon");
        }

        public void ValidatePartnerNameRequired()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(60));
            driver.WaitForElementNotExists(loadingPage, 60);
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(By.XPath("//label[text()='Partner Name']//following-sibling::input"), "regressiontext1.4.9.3", "partnername");
            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(toastMessage, "Partner Name is Required");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidatePartnerDropdownDisabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.IsElementEnabled(partnerType, "Partner Dropdown");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateAddressBarDisabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDoesnotExists(address, "Address Bar");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCityBarDisabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDoesnotExists(city, "City Bar");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateStateBarDisabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDoesnotExists(state, "State Bar");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateZipBarDisabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDoesnotExists(zip, "Zip Bar");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateAddressBarDisplayed()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.CheckElementDisplayed(address, "Address Bar");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCityBarDisplayed()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.CheckElementDisplayed(city, "City Bar");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateZipDisplayed()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.CheckElementDisplayed(zip, "Zip");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateStateDisplayed()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.CheckElementDisplayed(state, "State");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidatePartnerTypeDisplayed()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(partnerType, "Dropdown");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidatePartnerTypeDropdownsDisplayed()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.CheckElementDisplayed(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateThirdPartyVendorPartnerType()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDefaultPartnerType()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnCreate, "Create");
            driver.ClickElement(btnCreate, "Create");
            //driver.ClickElement(partnerType, "Dropdown");
            driver.CheckElementDisplayed(By.XPath("//span[text()='Utility']"), "default PartnerType");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCancelPartner()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCreatePartnerCreateButton()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(partnerCreateButton, "Create");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCreatePartnerMoreThanOneBundle(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'Import')]"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle dropdown"); 
            driver.ClickElement(bundleFromDrpdown, "Bundle");


            driver.SendKeysToElement(partnerNameFieldBox, "import", "Utility Name");
            driver.ClickElement(By.XPath("//div//span[contains(text(),'Import')]"), "Utility");
            Thread.Sleep(2000);
            driver.ClickElement(drpDownBundleTwo, "Bundle dropdown");
            driver.ClickElement(bundleFromDrpdown, "Bundle");

            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(errorMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(errorMessage,"Error Message"); ;
            driver.ClickElement(btnCancel, "cancel");
        }

        public void ValidateSelectBundle(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'Import')]"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle dropdown");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.ClickElement(btnCancel, "cancel");
        }

        public void ValidateSelectBundleWithExistingBundle(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'Import')]"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle dropdown");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'Import')]"), "Utility");
            driver.ClickElement(drpDownBundleTwo, "Bundle dropdown");
            driver.ClickElement(bundleFromDrpdownTwo, "Bundle");
            driver.ClickElement(btnCancel, "cancel");
        }

        public void ValidateEditBundleWithExistingBundle(string partnerName, string utility)
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            //driver.SendKeysToElement(name, partnerName, "Partner Name");
            //driver.SendKeysToElement(email, "test@email.com", "Email");
            //driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'" + utility + "')]"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle dropdown");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'" + utility + "')]"), "Utility");
            driver.ClickElement(drpDownBundleTwo, "Bundle dropdown");
            driver.ClickElement(bundleFromDrpdownTwo, "Bundle");
            driver.ClickElement(btnCancel, "cancel");
        }

        public void ValidateDefaultUsagePlan(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'Import')]"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle dropdown");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.CheckElementDisplayed(defaultUsagePlan, "Usage Plan");
            testReport.Info("Default Usage Plan is: " + driver.GetElementText(defaultUsagePlan));
            driver.ClickElement(btnCancel, "cancel");
        }
        public void ValidateCreateNewPartner(string partnerName,string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'" + utility + "')]"), "Utility");
            driver.ClickElement(drpDownBundle, "Dropdown");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info(driver.GetElementText(toastMessage));
        }

        public void ValidateCreatePartnerDifferentBundle(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create"); driver.ClickElement(partnerType, "Utility Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            
            driver.SendKeysToElement(address, "South", "Address");
            driver.SendKeysToElement(city, "Downtown", "City");
            driver.SendKeysToElement(state, "Atlanta", "State");
            driver.SendKeysToElement(zip, "099900", "Zip Code");

            //driver.SendKeysToElement(name, partnerName, "Partner Name");
            //driver.SendKeysToElement(email, "test@email.com", "Email");
            //driver.SendKeysToElement(phone, "12345678", "Phone");
            //driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(.,'" + utility + "')]"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");

            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(.,'" + utility + "')]"), "Utility");
            driver.ClickElement(drpDownBundleTwo, "Bundle");
            driver.ClickElement(bundleFromDrpdownTwo, "Bundle");

            driver.ClickElement(partnerCreateButton, "Create");
            driver.sleepTime(5000);
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info(driver.GetElementText(toastMessage));
        }

        public void ValidateCreatePartnerThirdPartyVendor(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create"); driver.ClickElement(partnerType, "Utility Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(address, "South", "Address");
            driver.SendKeysToElement(city, "Downtown", "City");
            driver.SendKeysToElement(state, "Atlanta", "State");
            driver.SendKeysToElement(zip, "099900", "Zip Code");

            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[text()='" + utility + "']"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");

            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info(driver.GetElementText(toastMessage));
        }

        public void ValidateCreatePartnerThirdPartyVendorSameBundle(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create"); driver.ClickElement(partnerType, "Utility Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.SendKeysToElement(name, partnerName, "Partner Name");

            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(address, "South", "Address");
            driver.SendKeysToElement(city, "Downtown", "City");
            driver.SendKeysToElement(state, "Atlanta", "State");
            driver.SendKeysToElement(zip, "099900", "Zip Code");

            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[text()='" + utility + "']"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");

            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[text()='" + utility + "']"), "Utility");
            driver.ClickElement(drpDownBundleTwo, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");

            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCreatePartnerSameBundle(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Utility Dropdown");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[text()='" + utility + "']"), "Utility");
            driver.SendKeysToElement(address, "South", "Address");
            driver.SendKeysToElement(city, "Downtown", "City");
            driver.SendKeysToElement(state, "Atlanta", "State");
            driver.SendKeysToElement(zip, "099900", "Zip Code");
            //driver.SendKeysToElement(By.XPath("//input[@placeholder='Search Utility Name or Site ID']"), Keys.Clear, "utilityname");
            //driver.SendKeysToElement(By.XPath("//input[@placeholder='Search Utility Name or Site ID']"), "Test Water Co", "utilityname");

            //driver.ClickElement(By.XPath("//span[text()='"+utility+"']"), "Utility");
            driver.ClickElement(drpDownBundle, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");

            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[text()='" + utility + "']"), "Utility");
            driver.ClickElement(drpDownBundleTwo, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");

            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(toastMessage, "Toast Message");
            testReport.Info(driver.GetElementText(toastMessage));
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerSameSiteDifferentBundle(string partnerName, string utility)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.ClickElement(btnEdit, "Edit");

            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.sleepTime(5000);

            driver.ClickElement(By.XPath("//span[contains(text(),'" + utility + "')]"), "Utility");
            driver.ClickElement(drpDownBundleTwo, "Bundle");
            driver.ClickElement(bundleFromDrpdownTwo, "Bundle");

            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(toastMessage, "Toast Message");
            testReport.Info(driver.GetElementText(toastMessage));
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerSameSiteSameBundle(string partnerName, string utility)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, "AutomationTest", "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.ClickElement(btnEdit, "Edit");
           

            driver.SendKeysToElement(partnerNameFieldBox, "Test Water Co", "Utility Name");
            driver.SendKeysToElementClearFirst(partnerNameFieldBox, "Test Water Co", "Utility Name");
            driver.sleepTime(5000);
            //driver.ClickElement(By.XPath("//span[contains(.,'" + utility + "')]"), "Utility");
            driver.ClickElement(By.XPath("//span[contains(text(),'Test Water Co')]"), "Utility");
            driver.ClickElement(By.XPath("//span[contains(text(),'" + "Select" + "')]"), "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");

            driver.ClickElement(btnSave, "Save");
            //driver.WaitForElement(errorMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(By.XPath("//div[text()=' Only one bundle can be paired with a utility. ']"), "error Message");
            //testReport.Info(driver.GetElementText(errorMessage));
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCreateNewPartnerPartnerManagementPage(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[text()='" + utility + "']"), "Utility");
            //driver.ClickElement(selectUtility, "Utility");
            driver.ClickElement(drpDownBundle, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info(driver.GetElementText(toastMessage));
            driver.WaitForElement(apiHeaderTitle, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(apiHeaderTitle, "Partner Management Page");
        }

        public void ValidateCreateNewPartnerDisplayOrder(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.WaitForElementNotExists(By.XPath("//h4[text()='loading']"),300);
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, "import", "Utility Name");
            driver.ClickElement(By.XPath("//kendo-list//li[3]//span[contains(text(),'import')]"), "Utility");
            Thread.Sleep(5000);
            driver.ClickElement(drpDownBundle, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info(driver.GetElementText(toastMessage));
            driver.WaitForElement(By.XPath("//p[contains(.,'"+ partnerName+"')]"), TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(By.XPath("//p[contains(.,'" + partnerName + "')]"), "Partner Name");
        }


        public void ValidateEditPartner(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Create");
            //driver.WaitForElement(By.XPath("//span[contains(.,'" + partnerName + "')]"), TimeSpan.FromSeconds(10));
            //driver.ClickElement(By.XPath("//span[contains(.,'" + partnerName + "')]"), "Partner Name");
            //driver.ClickElement(btnEdit, "Edit");
            //driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(editPartnerPage, "Edit Partner Page");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerCancelButton(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(editPartnerPage, "Edit Partner Page");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerSaveButton(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(editPartnerPage, "Edit Partner Page");
            driver.CheckElementDisplayed(btnSave, "Save");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerXButton(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.CheckElementDisplayed(editPartnerPage, "Edit Partner Page");
            driver.CheckElementDisplayed(createXButton, "X Button");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerEmail(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(email, "Email");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerPhone(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(phone, "Phone");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerAddress(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(address, "address");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerCity(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(city, "City");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerState(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(state, "State");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerZip(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(zip, "Zip");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerXIcon(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(createXButton, "X Icon");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerXIconClick(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(createXButton, "X Icon");
        }

        public void ValidateEditPartnerBundleUpdate(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.ClickElement(drpDownBundle, "Dropdown");
            driver.ClickElement(By.XPath("//span[contains(.,'"+partnerName+"')]"), "bundledropdown");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditPartnerSave(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.WaitForElementNotExists(loadingPage, 300);
            driver.SendKeysToElementClearFirst(searchBox, "Test", "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.SendKeysToElementClearFirst(phone, "12300", "phone");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Toast Message");
        }

        public void ValidateDeletePartner(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDelete, "edit");
            driver.WaitForElement(deletePartnerPage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(deletePartnerPage, "Delete Partner");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDeletePartnerContents(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDelete, "edit");
            driver.WaitForElement(deletePartnerPage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(deleteSure, "Delete Partner Dialog");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDeletePartnerCancel(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDelete, "edit");
            driver.WaitForElement(deletePartnerPage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDeletePartnerDeleteButton(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDelete, "edit");
            driver.WaitForElement(deletePartnerPage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(deletePartnerDelete, "Delete");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDeletePartnerDeleteButtonClick(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDelete, "edit");
            driver.WaitForElement(deletePartnerPage, TimeSpan.FromSeconds(20));
            driver.ClickElement(deletePartnerDelete, "Delete");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.sleepTime(10000);
            driver.CheckElementDoesnotExists(By.XPath("//p[contains(.,'" + partnerName + "')]"), "Partner Name");
        }

        public void ValidateDeletePartnerDeleteButtonPartnerScreen(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDelete, "edit");
            driver.WaitForElement(deletePartnerPage, TimeSpan.FromSeconds(20));
            driver.ClickElement(deletePartnerDelete, "Delete");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(apiHeaderTitle, "Partner Management Screen"); 
        }


        public void ValidateDeletePartnerXIcon(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDelete, "edit");
            driver.WaitForElement(deletePartnerPage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(createXButton, "X Icon");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDeletePartnerXIconClick(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnDelete, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDelete, "edit");
            driver.WaitForElement(deletePartnerPage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(createXButton, "X Icon");
            driver.ClickElement(createXButton, "X Icon");
        }

        public void ValidateEditPartnerSavePartnerScreen(string partnerName)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.WaitForElementNotExists(By.XPath("//h4[text()='loading']"), 300);

            driver.SendKeysToElementClearFirst(searchBox, partnerName, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "edit");
            driver.WaitForElement(editPartnerPage, TimeSpan.FromSeconds(10));
            driver.SendKeysToElementClearFirst(phone, "12300", "phone");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.WaitForElement(apiHeaderTitle, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(apiHeaderTitle, "Partner Management Screen");
        }

        public void ValidateExistingPartnerErrorMessage(string partnerName, string utility)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(name, partnerName, "Partner Name");
            driver.SendKeysToElement(email, "test@email.com", "Email");
            driver.SendKeysToElement(phone, "12345678", "Phone");
            driver.SendKeysToElement(partnerNameFieldBox, utility, "Utility Name");
            driver.ClickElement(By.XPath("//span[contains(text(),'" + utility + "')]"), "Utility");
            //driver.ClickElement(selectUtility, "Utility");
            driver.ClickElement(drpDownBundle, "Bundle");
            driver.ClickElement(bundleFromDrpdown, "Bundle");
            driver.ClickElement(partnerCreateButton, "Create");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info(driver.GetElementText(toastMessage));
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCreateXButton()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.WaitForElement(createXIconButton, TimeSpan.FromSeconds(10));

            driver.CheckElementDisplayed(createXIconButton, "X Button");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEmailEditable()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(email, "Email");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidatePhoneEditable()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(phone, "Phone");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateAddressEditable()
        {
            driver.sleepTime(5000);
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.CheckElementDisplayed(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(address, "Address");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateCityEditable()
        {
            driver.sleepTime(5000);
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.CheckElementDisplayed(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(city, "City");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateStateEditable()
        {
            driver.sleepTime(5000);
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.CheckElementDisplayed(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(state, "State");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateZipEditable()
        {
            driver.sleepTime(5000);
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(partnerType, "Dropdown");
            driver.CheckElementDisplayed(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(thirdPartyVendor, "3rd Party Vendor");
            driver.ClickElement(zip, "Zip Code");
            driver.ClickElement(btnCancel, "Cancel");
        }


        public void ValidateSecretToggle()
        {
            driver.sleepTime(5000);
            driver.ClickElement(partnerTwo, "");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(clientID, "Client ID");
            driver.CheckElementDisplayed(secretToggle, "Secret Toggle");
        }

        public void ValidateClientIDDisplayed()
        {
            driver.sleepTime(5000);
            driver.ClickElement(partnerTwo, "");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(clientID, "Client ID");
            driver.ClickElement(secretToggle, "Secret Toggle");
        }

        public void ValidateUtilitiesList()
        {
            driver.sleepTime(5000);
            driver.ClickElement(partnerTwo, "");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(utilitiesList, "List Of Utilities");
        }

        public void ValidatePartnerDetails(string partner)
        {
            driver.WaitForElement(searchBox, TimeSpan.FromSeconds(20));
            driver.SendKeysToElementClearFirst(searchBox, partner, "Partner Name");
            driver.ClickElement(searchIcon, "Search Icon");
            driver.ClickElement(partnerOne, "Partner");

            driver.WaitForElement(partnerName, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(partnerName, "Partner Name");
            driver.CheckElementDisplayed(clientSecretKey, "Client Secret Key");
            driver.CheckElementDisplayed(apiKey, "API Key");
            driver.CheckElementDisplayed(contactEmail, "Contact Email");
            driver.CheckElementDisplayed(contactPhone, "Phone");
            driver.CheckElementDisplayed(contactAddress, "Address");
            driver.CheckElementDisplayed(contactCity, "City");
            driver.CheckElementDisplayed(contactState, "State");
            driver.CheckElementDisplayed(contactZip, "ZIP Code");
        }

        public void ValidatePartnerTableDetails()
        {
            driver.ClickElement(partnerTwo, "");
            driver.sleepTime(5000);
            driver.WaitForElement(utility, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(utility, "Utility");
            driver.CheckElementDisplayed(siteID, "Site ID");
            driver.CheckElementDisplayed(bundle, "Bundle");
            driver.CheckElementDisplayed(usagePlan, "Usage Plan");
            driver.CheckElementDisplayed(clientID, "Client ID");
            driver.CheckElementDisplayed(createdDate, "Created Date");
            
        }
    }
}
