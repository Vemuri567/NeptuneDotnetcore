using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
   public class APIDeploymentPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By BreadCrumb = By.XPath("//sd-toolbar/div/span/span");
        private By apiHeaderTitle = By.XPath("//h2[contains(.,'API Deployment')]");
        private By btnCreate=By.XPath("//button[contains(.,'Create')]");
        private By btnCancel = By.XPath("//button[contains(.,'Cancel')]");
        private By btnEdit = By.XPath("//button[contains(.,'Edit')]");
        private By btnDone = By.XPath("//button[contains(.,'Done')]");
        private By btnDoneSecond = By.XPath("//button[3]");
        private By btnDeleteBundle = By.XPath("//button[contains(.,'Delete Bundle')]");
        private By bundles = By.XPath("//h4[contains(.,'Bundles')]");
        private By platformAPI = By.XPath("//h4[contains(.,'Platform API')]");
        private By bundlesList = By.XPath("//sd-bundle-template-list/div");
        private By bundleOne = By.XPath("//sd-bundle-template[1]/div");
        private By homePage = By.CssSelector(".welcome-message > span");
        private By consumption = By.XPath("//span[contains(.,'consumption')]");
        private By versionColumns = By.XPath("//span[contains(@class,'title table-title-version')]");
        private By versionValuesUnderVersion = By.XPath("//section//li//span[2][text()=' v1' or text()=' v2']");
        private By endpoints = By.XPath("//span[contains(.,'endpoints')]");
        private By active = By.XPath("//span[contains(.,'Active')]");
        private By consumptionEnabled = By.XPath("//span[contains(.,'consumption')]/..//img");
        private By enableOne = By.XPath("//div[1]/div[2]/section/div[1]/ul/li/span[4]/span/kendo-switch/span");
        private By enableTwo = By.XPath("//div[2]/div[2]/section/div[1]/ul/li/span[4]/span/kendo-switch/span");
        private By enableThree = By.XPath("//div[3]/div[2]/section/div[1]/ul/li/span[4]/span/kendo-switch/span");
        private By enableFour = By.XPath("//div[4]/div[2]/section/div[1]/ul/li/span[4]/span/kendo-switch/span");
        private By enableFive = By.XPath("//div[5]/div[2]/section/div[1]/ul/li/span[4]/span/kendo-switch/span");
        private By apiTextbox = By.XPath("//input[@type='text']");
        private By toastMessage = By.Id("toast-container");
        private By deleteBundleDialogue = By.XPath("//span[contains(text(),'Delete Bundle')]");
        private By deleteDialoguCancel = By.XPath("//button[@id='deactCancelButton']");
        private By deleteDialogBody = By.XPath("//p[contains(.,'Are you sure you want to delete this Bundle?')]");
        private By bundleName = By.CssSelector(".deactivate-item-name");
        private By deleteConfirm = By.XPath("//button[@id='deactYesButton']");
        private By bundleDisable = By.XPath("//div[1]/div[2]/section/div[1]/ul/li/span[4]/span/kendo-switch/span");
        private By usagePlans = By.XPath("//span[text()='USAGE PLANS']");
        #endregion

        /// <summary>
        /// Method to Validate Title Display
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateTitleDisplay()
        {
            if(driver.GetElementText(apiHeaderTitle).Equals("API Deployment"))
            {
                testReport.Pass("API Deployment Page is Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Page is Not Displayed");
            }
            
        }

        public void ValidateBreadCrumbDisplay()
        {
            if (driver.GetElementText(BreadCrumb).Equals("API DEPLOYMENT"))
            {
                testReport.Pass("API Deployment Breadcrumb is Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("API Deployment Breadcrumb is Not Displayed");
            }
        }

        public void ValidateCreateButton()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnCreate, "Create");
        }

        public void ValidateCreateButtonDisabled()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.IsElementDisabled(btnCreate, "Create");
        }

        public void ValidateEditCreateButtonDisabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.IsElementDisabled(btnCreate, "Create");
        }

        public void ValidateEditButton()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnEdit,"Edit");            
        }

        public void ValidateDeleteBundleButton()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnDeleteBundle, "Delete Bundle");
        }

        public void ValidateEditButtonDisabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.IsElementDisabled(btnEdit, "Edit");
        }

        public void ValidateDoneButtonDisabled()
        {
            driver.WaitForElement(btnDone, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.IsElementDisabled(btnDone, "Done");
        }

        public void ValidateEditDoneButtonDisabled()
        {
            driver.WaitForElement(btnDone, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.IsElementDisabled(btnDone, "Done");
        }

        public void ValidateEditButtonNotExist()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }

        public void ValidateDoneButton()
        {
            driver.WaitForElement(btnDone, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnDone, "Done");
        }

        public void ValidateEditDoneButton()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnDoneSecond, "Done");
        }


        public void ValidateCreateButtonNotExist()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            if (driver.CheckElementDoesnotExists(btnCreate, "Create"))
            {
                testReport.Pass("Create Button is Not Displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Create Button is  Displayed");
            }
        }

        public void ValidateBundles()
        {
            driver.WaitForElement(bundles, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(bundles, "Bundles");
        }

        public void ValidatePlatformAPI()
        {
            driver.WaitForElement(platformAPI, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(platformAPI, "Platform API");
        }

        public void ValidateListOfBundles()
        {
            driver.WaitForElement(bundlesList, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(bundlesList, "Platform API");
        }

        public void ValidateUniqueBundles()
        {
            driver.WaitForElement(bundleOne, TimeSpan.FromSeconds(10));
            driver.ClickElement(bundlesList, "Platform API");
        }

        public void ValidateDoneButtonClick()
        {
            driver.WaitForElement(btnDone, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnDone, "Done");
            driver.WaitForElement(homePage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(homePage, "Welcome Message");
        }

        public void ValidateConsumption()
        {
            driver.WaitForElement(consumption, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(consumption, "Consumption");
        }

        public void ValidateConsumptionEndpoint()
        {
            driver.WaitForElement(versionColumns, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(versionColumns, "Version Column");
            driver.CheckElementDisplayed(versionValuesUnderVersion, "Version Values under version");
        }

        public void ValidateStatusActive()
        {
            driver.WaitForElement(consumption, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(active, "Active Status");
        }

        public void ValidateAPITextBBox()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(apiTextbox, "Name of the Bundle that was selected prior to clicking Create button is displayed in the Bundle Name field");
        }

        public void ValidateDeleteBundleDialog()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnDeleteBundle, "Delete Bundle");
            driver.CheckElementDisplayed(deleteBundleDialogue, "Delete Bundle Dialogue");
            driver.ClickElement(deleteDialoguCancel, "Cancel");
        }

        public void ValidateDeleteBundleDialogContents()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnDeleteBundle, "Delete Bundle");
            driver.CheckElementDisplayed(deleteBundleDialogue, "Delete Bundle Dialogue");
            driver.CheckElementDisplayed(deleteDialogBody, "Delete Dialog Body");
            driver.CheckElementDisplayed(bundleName, "Bundle Name");
            driver.CheckElementDisplayed(deleteConfirm, "Delete");
            driver.ClickElement(deleteDialoguCancel, "Cancel");
        }

        public void ValidateDeleteBundleConfirmation(string bundle)
        {
            driver.WaitForElement(By.XPath("//span[contains(text(),'" + bundle + "')]"),TimeSpan.FromSeconds(15));
            driver.ClickElement(By.XPath("//span[contains(text(),'" + bundle + "')]"),"Bundle");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnDeleteBundle, "Delete Bundle");
            driver.ClickElement(deleteConfirm, "Delete Confirm");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));
        }

        public void ValidateDeleteBundleAPIPage(string bundle)
        {
            driver.WaitForElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), TimeSpan.FromSeconds(15));
            driver.ClickElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), "Bundle");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnDeleteBundle, "Delete Bundle");
            driver.ClickElement(deleteConfirm, "Delete Confirm");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(apiHeaderTitle, "API Deployment Page");
        }

        public void ValidateCreateBundleWebServices()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(consumptionEnabled, "Webservices");
        }

        public void ValidateEditWebServicesEnabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(enableOne, "Webservices Enable");
        }

        public void ValidateMultipleWebServicesEnabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(enableOne, "Webservices Enable");
            driver.ClickElement(enableTwo, "2nd Webservices Enable");
        }

        public void ValidateFiveWebServicesEnabled()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.sleepTime(2000);
            driver.ClickElement(enableOne, "1st Webservices Enable");
            driver.ClickElement(enableTwo, "2nd Webservices Enable");
            driver.ClickElement(enableThree, "3rd Webservices Enable");
            driver.ClickElement(enableFour, "4th Webservices Enable");
            driver.ClickElement(enableFive, "5th Webservices Enable");
        }

        public void ValidateCreateBundleComplementaryUsagePlans(string bundle)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.sleepTime(2000);
            driver.SendKeysToElementClearFirst(apiTextbox, bundle, "");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
            driver.ClickElement(usagePlans, "USAGE PLANS");
            driver.WaitForElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(By.XPath("//span[contains(text(),'" + bundle + "')]"),"Bundle");
        }

        public void ValidateEditBundleDoneConfirmation(string bundle)
        {
            driver.WaitForElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), TimeSpan.FromSeconds(15));
            driver.ClickElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), "Bundle");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(bundleDisable, "Bundle Disable");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));
        }

        public void ValidateEditBundleDoneAPIPage(string bundle)
        {
            driver.WaitForElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), TimeSpan.FromSeconds(15));
            driver.ClickElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), "Bundle");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(bundleDisable, "Bundle Disable");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(apiHeaderTitle, "API Page");
        }

        public void ValidateBundleNameCannotChange()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(apiTextbox, "Text Box");
        }

        public void ValidateUpdatedBundleOnList(string bundle)
        {
            driver.WaitForElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), TimeSpan.FromSeconds(15));
            driver.ClickElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), "Bundle");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(bundleDisable, "Bundle Disable");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(apiHeaderTitle, "API Page");
            driver.CheckElementDisplayed(By.XPath("//span[contains(text(),'" + bundle + "')]"), "Updated Bundle");
        }

        public void ValidateCreateDuplicateBundle()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(toastMessage, "Following message 'This bundle name already exists.Please enter another.' is displayed");
        }

        public void ValidateUsagePlanDeleted(string bundle)
        {
            driver.ClickElement(By.XPath("//span[contains(text(),'" + bundle + "')]"), "Bundle");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnDeleteBundle, "Delete");
            driver.ClickElement(deleteConfirm, "Delete");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
            driver.ClickElement(usagePlans, "Usage Plan");
            //driver.CheckElementDoesnotExists(By.XPath("//span[contains(text(),'" + bundle + "')]"), "Bundle Deleted");
        }

        public void ValidateBundleNameBlank()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElementClearFirst(apiTextbox, "", "Text Box");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.CheckElementDisplayed(toastMessage, "The following message is displayed  'Required field is blank.Please enter data into required field.'");
        }

        public void ValidateCreateCancel()
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditCancel()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
        }

        public void ValidateEditCancelAPIPage()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
            driver.CheckElementDisplayed(apiHeaderTitle, "API Deployment Page");
        }

        public void ValidateCreateUniqueBundleName(string bundle)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElementClearFirst(apiTextbox, bundle, "Bundle Name");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Green confirmation toast message is displayed as follows: Test01");            
        }

        public void ValidateUniqueBundleNameDisplay(string bundleName)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElementClearFirst(apiTextbox, bundleName, "Bundle Name");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Green confirmation toast message is displayed as follows: Test01");
            driver.CheckElementDisplayed(By.XPath("//span[contains(.,'" + bundleName + "')]"), "Unique Bundle Name");
        }
        public void ValidateCreateUniqueBundleAPIDisplay(string bundleName)
        {
            driver.WaitForElement(btnCreate, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElementClearFirst(apiTextbox, bundleName, "Bundle Name");
            driver.ClickElement(btnDoneSecond, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Green confirmation toast message is displayed as follows: Test01");
            driver.CheckElementDisplayed(apiHeaderTitle,"API Deployment");
        }


        public void ValidateEnabledColumn()
        {
            driver.WaitForElement(consumption, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(consumptionEnabled, "Consumption Enabled");
            //string defaultproperty = driver.GetElementProperty(consumptionEnabled, "src").ToString();
            //if (defaultproperty.Contains("Confirm"))
            //{
            //    testReport.Pass("Create Partners permission is set to No");
            //}
            //else
            //{
            //    ReporterFactory.LogFailure("Create Partners permission is set to Yes");
            //}
        }

    }
}
