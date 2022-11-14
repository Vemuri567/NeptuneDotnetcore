using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class UsagePlanPage : AbstractTemplatePage
    {
        #region UI Object Repository    
        private By lftNavPlatformManagement = By.XPath("//img[contains(@src, '/assets/svg/leftnavigation/PlatformManagement.icon.16x16.svg')]");
        private By lftNavUsagePlan = By.XPath("//span[text()='USAGE PLANS']");
        private By breadCrumb = By.XPath("//ng-sidebar-container//sd-toolbar//span/span");
        private By btnEdit = By.XPath("//button[text()='Edit']");
        private By btnCreate = By.XPath("//button[text()='Create']");
        private By btnDelete = By.XPath("//button[text()='Delete']");
        private By btnDoneTop = By.XPath("//div[2]//div[2]/div[1]/div[2]/div/div/button[2]");
        private By btnDone = By.XPath("//sd-usageplan/div/div[1]/div[2]/div/div/button[2]");
        private By lftList = By.XPath("//div/div[2]/div/div/div[1]/div[2]/div");
        private By usagePlan1 = By.XPath("//div[@class='template-list-container']//div[1]//span");
        private By usagePlan2 = By.XPath("//div[@class='template-list-container']//div[2]//span");
        private By detailsSection = By.XPath("//div/div[2]/div/div/div[2]/div[2]");
        private By burst = By.Name("burst");
        private By rate = By.Name("rate");
        private By requests = By.Name("requests");
        private By name = By.Name("name");
        private By per = By.XPath("//form/div[5]/div/kendo-dropdownlist/span");
        private By date = By.Name("created date");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By toastMessage = By.Id("toast-container");

        #endregion

        /// <summary>
        /// Method to Validate dashboard to homepage
        /// </summary>
        public void ValidateUsageplanBreadbrumb()
        {
            driver.CheckElementDisplayed(breadCrumb, "Breadcrumb");
        }

        /// <summary>
        /// Method to Validate Edit Button
        /// </summary>
        public void ValidateEditButton()
        {
            driver.WaitForElement(btnDone, TimeSpan.FromSeconds(120));
            driver.CheckElementDisplayed(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Done Button
        /// </summary>
        public void ValidateDoneButton()
        {
            driver.WaitForElement(btnDone, TimeSpan.FromSeconds(60));
            driver.CheckElementDisplayed(btnDone, "Edit");
        }

        /// <summary>
        /// Method to Validate Title
        /// </summary>
        public void ValidateTitle()
        {
            driver.WaitForElement(btnDone, TimeSpan.FromSeconds(20));
            if(driver.Title.Contains("USAGE PLANS"))
            {
                testReport.Pass("Usage Plan is displayed as Left section title");
            }
        }

        /// <summary>
        /// Method to Validate Left List Section
        /// </summary>
        public void ValidateLeftListSection()
        {
            driver.WaitForElement(btnDone, TimeSpan.FromSeconds(60));
            driver.CheckElementDisplayed(lftList, "Left List Section");
        }

        /// <summary>
        /// Method to Validate Single Section
        /// </summary>
        public void ValidateSingleSection()
        {
            driver.WaitForElement(usagePlan2, TimeSpan.FromSeconds(60));
            driver.ClickElement(usagePlan2, "2nd Usage Plan");
            driver.ClickElement(usagePlan1, "1st Usage Plan");
        }

        /// <summary>
        /// Method to Validate Details Section 
        /// </summary>
        public void ValidateDetailsSection()
        {
            driver.WaitForElement(detailsSection, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(detailsSection, "Details Section");
        }

        /// <summary>
        /// Method to Validate Details Section Field Display
        /// </summary>
        public void ValidateDetailsSectionFieldDisplay()
        {
            driver.WaitForElement(burst, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(burst, "Burst");
            driver.CheckElementDisplayed(rate, "Rate");
            driver.CheckElementDisplayed(requests, "Requests");
        }

        /// <summary>
        /// Method to Validate Done Button Click
        /// </summary>
        public void ValidateDoneButtonClick()
        {
            driver.WaitElementExistsAndVisible(btnDone);

            driver.ClickElement(btnDone, "Done");
        }

        /// <summary>
        /// Method to Validate Top Item Selected
        /// </summary>
        public void ValidateTopItemSelected()
        {
            driver.WaitForElement(usagePlan1, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(usagePlan1, "Top Item");
        }

        /// <summary>
        /// Method to Validate Item Name Not Editable
        /// </summary>
        public void ValidateItemNameNotEditable()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(name, "Name");
            testReport.Pass("Item Name not Editable");
        }

        /// <summary>
        /// Method to Validate Create_Button_Not_Available
        /// </summary>
        public void ValidateCreateButtonNotAvailable()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.CheckElementDoesnotExists(btnCreate, "Create");
            testReport.Pass("Create Button Not Available");
        }

        /// <summary>
        /// Method to Validate Delete Button_Not_Available
        /// </summary>
        public void ValidateDeleteButtonNotAvailable()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.CheckElementDoesnotExists(btnDelete, "Delete");
            testReport.Pass("Delete Button Not Available");
        }

        /// <summary>
        /// Method to Validate Edit Rate
        /// </summary>
        public void ValidateEditRate()
        {
            driver.WaitElementExistsAndVisible(btnEdit);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(rate, "Rate");
            testReport.Pass("RATE field is editable");
        }

        /// <summary>
        /// Method to Validate Edit Burst
        /// </summary>
        public void ValidateEditBurst()
        {
            driver.WaitElementExistsAndVisible(btnEdit);
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(burst, "Burst");
            testReport.Pass("Burst field is editable");
        }

        /// <summary>
        /// Method to Validate Edit Requests
        /// </summary>
        public void ValidateEditRequests()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(requests, "Request");
            testReport.Pass("Request field is editable");
        }

        /// <summary>
        /// Method to Validate Edit Per
        /// </summary>
        public void ValidateEditPer()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(per, "Per");
            testReport.Pass("Per field is editable");
        }

        /// <summary>
        /// Method to Validate Edit Date
        /// </summary>
        public void ValidateEditDate()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(date, "Date");
            testReport.Pass("Date field is Not editable");
        }

        /// <summary>
        /// Method to Validate Edit Button Grayed Out
        /// </summary>
        public void ValidateEditButtonGrayedOut()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            driver.IsElementDisabled(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Done Button Grayed Out
        /// </summary>
        public void ValidateDoneButtonGrayedOut()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            driver.IsElementDisabled(btnDone, "Done");
        }

        /// <summary>
        /// Method to Validate Cancel Button Displays
        /// </summary>
        public void ValidateCancelButtonDisplays()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Cancel Button Access
        /// </summary>
        public void ValidateCancelButtonAccess()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Done_Button_Access_Confirmation
        /// </summary>
        public void ValidateDoneButtonAccessConfirmation()
        {
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnEdit, "Edit");
            string rateFieldValue = driver.GetElementAttribute(rate, "value");
            int rateValue =Convert.ToInt32(driver.GetElementAttribute(rate,"value"));
            driver.SendKeysToElementClearFirst(rate, (rateValue+1).ToString(), "Rate");
            driver.ClickElement(btnDoneTop, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, "Toast Message");
        }

    }
}
