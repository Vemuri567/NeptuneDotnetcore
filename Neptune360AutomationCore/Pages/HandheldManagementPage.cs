using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Globalization;

namespace Neptune360UIAutomation
{
    public class HandheldManagementPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By colFileName = By.XPath("//table//th[2]");
        private By colExportDate = By.XPath("//table//th[3]");
        private By lftNavHandhelds = By.XPath("//span[text()='HANDHELDS']");
        private By lftNavHandheldSettings = By.XPath("//span[text()='HANDHELD SETTINGS']");
        private By breadcrumb = By.XPath("//sd-toolbar/div/span/span");
        #endregion


        /// <summary>
        /// Method to Validate Handheld MAnagement Page Displayed
        /// </summary>
        public void ValidateHandheldManagementPageDisplayed()
        {
            driver.ClickElement(lftNavHandhelds, "File Name");
            driver.CheckElementDisplayed(breadcrumb,"Handhelds Page");
        }

        /// <summary>
        /// Method to Validate Handheld Settings Page Displayed
        /// </summary>
        public void ValidateHandheldSettingsPageDisplayed()
        {
            driver.ClickElement(lftNavHandheldSettings, "Handheld Settings");
            driver.CheckElementDisplayed(breadcrumb, "Handhelds Page");
        }
    }
}