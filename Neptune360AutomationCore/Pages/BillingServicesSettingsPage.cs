using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Globalization;
using System.Threading;

namespace Neptune360UIAutomation
{
    public class BillingServicesSettingsPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By pageLoader = By.XPath("//div[@class='page-loader']");
        private By dataTranslations = By.XPath("//p[contains(.,'Data Translations')]");
        private By billingAutomation = By.XPath("//p[contains(.,'Billing Automation')]");
        private By importRules = By.XPath("//p[contains(.,'Import Rules')]");
        private By exportRules = By.XPath("//p[contains(.,'Export Rules')]");
        private By general = By.XPath("//p[contains(.,'General')]");
        private By overwriteReadDate = By.XPath("//div[1]/kendo-switch/span/span");
        private By meterSize = By.XPath("//button[text()=' Meter Size']");
        private By registerUOM = By.XPath("//button[text()=' Register UOM']");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By btnEdit = By.XPath("//button[text()='Edit']");
        private By btnSave = By.XPath("//button[text()='Save']");
        private By btnOk = By.XPath("//button[text()='Ok']");
        private By Xbutton = By.CssSelector(".k-i-x");
        private By meterSizeMappingPage = By.XPath("//kendo-dialog-titlebar");
        private By meterSize5_8 = By.XPath("//span[contains(.,'5/8')]");
        private By meterSize3_4 = By.XPath("//span[contains(.,'3/4')]");
        private By meterSize1 = By.XPath("//span[contains(.,'1')]");
        private By meterSize1_1_2 = By.XPath("//span[contains(.,'1-1/2')]");
        private By meterSize3 = By.XPath("//span[contains(.,'3')]");
        private By meterSize2 = By.XPath("//span[contains(.,'2')]");
        private By meterSize4 = By.XPath("//span[contains(.,'4')]");
        private By meterSize6 = By.XPath("//span[contains(.,'6')]");
        private By meterSize10 = By.XPath("//span[contains(.,'10')]");
        private By meterSize8 = By.XPath("//span[contains(.,'8')]");
        private By meterSize12 = By.XPath("//span[contains(.,'12')]");
        private By meterSize16 = By.XPath("//span[contains(.,'16')]");
        private By meterSize20 = By.XPath("//span[contains(.,'20')]");
        private By meterSizeClose = By.XPath("//kendo-dialog-titlebar/div[2]");

        private By utiliValueGal = By.XPath("//li[contains(.,'Gal')]");

        private By xValue = By.XPath("//table//tr[2]/td[2]/kendo-multiselect//kendo-taglist//span[@aria-label='delete']//parent::span");

        private By registerUOMTitle = By.XPath("//div[contains(text(),'Register UOM Mapping')]");
        private By utilityValueBox = By.XPath("//kendo-grid[@id='TransferGrid']//tr[1]//input");
        private By utilityBox2 = By.XPath("//kendo-grid[@id='TransferGrid']//tr[2]//input");
        private By value5_8 = By.XPath("//kendo-taglist//span[contains(.,'5/8')][contains(@class,'k-chip-label k-text-ellipsis')]");
        private By valueGal = By.XPath("//li[contains(.,'Gal')]");
        private By toastMessage = By.Id("toast-container");
        private By neptune360Value = By.XPath("//strong[contains(.,'Neptune 360 values')]");
        private By utilityValues = By.XPath("//strong[contains(.,'Utility values')]");
        private By cubicFeet = By.XPath("//span[contains(.,'Cubic Feet')]");
        private By gallons = By.XPath("//span[contains(.,'Gallons')]");
        private By cubicMeter = By.XPath("//span[contains(.,'Cubic Meter')]");
        private By imperialGallons = By.XPath("//span[contains(.,'Imperial Gallons')]");
        private By litres = By.XPath("//span[contains(.,'Liters')]");

        private By importAutomation = By.XPath("//span[contains(.,'Import Automation')]");
        private By sftpConfiguration = By.XPath("//span[contains(.,'SFTP Configuration')]");
        private By sftpUsername = By.XPath("//span[contains(.,'SFTP Username')]");
        private By sftpHostname = By.XPath("//span[contains(.,'SFTP Hostname')]");
        private By sftpPassword = By.XPath("//span[contains(.,'SFTP Password')]");
        private By copyImportLogs = By.XPath("//span[contains(.,'Copy Import Error Logs to SFTP')]");
        private By copyExport = By.XPath("//span[contains(.,'Copy Export to SFTP')]");

        private By openRoutesHoverText = By.CssSelector(".row:nth-child(3) .fa");
        private By sftpConfigHoverText = By.CssSelector(".row:nth-child(5) .fa");
        private By importErrorHoverText = By.CssSelector(".row:nth-child(8) .fa");
        private By dataTranslationsHover = By.CssSelector("span.fa:nth-child(2)");
        private By copyExportToSftp = By.CssSelector(".row:nth-child(10) .fa");
        private By editMapping = By.XPath("//span[contains(.,'Edit Mappings')]");
        private By editMappingInfo = By.XPath("//sd-main//ng-sidebar-container//sd-billingservicessettings//div[2]//span[2]");
        private By ignoreOpenRouteswitch = By.XPath("//div[4]/div//kendo-switch/span/span");
        private By ignoreOpenRoutes = By.XPath("//div/div[2]/div/div[4]/div/div");
        private By sftpDefaultoption = By.XPath("//div/div[2]/div/div[6]/div/span");
        private By copyExportDefaultOption = By.XPath("//div/div[2]/div/div[11]/div/div/div");
        private By copyImportDefaultOption = By.XPath("//div/div[2]/div/div[9]/div/div/div");

        private By dataTranslationsHeading = By.XPath("//div/div/div/div[contains(.,'Data Translations')]");
        private By generalData = By.XPath("//div[@class='settings-section right white-bkgd']//span[@class='headerInput']");
        #endregion

        /// <summary>
        /// Method to Validate Export Files Validation
        /// </summary>
        public void ValidateDataTranslationsMeterSize5_8()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize5_8, "Value 5/8'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsMeterSize3_4()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize3_4, "Value 3/4'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsMeterSize1()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize1, "Value 1'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateEditMappingsLabel()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.CheckElementDisplayed(editMapping, "Edit Mapping");
        }

        public void ValidateEditMappingsLabelInfo()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.CheckElementDisplayed(editMappingInfo, "Edit Mapping Info");
        }
        public void ValidateDataTranslationsMeterSize1_1_2()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize1_1_2, "Value 1-1/2'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsMeterSize3()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize3, "Value 3'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDataTranslationsMeterSize2()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize2, "Value 2'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsMeterSize4()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize4, "Value 4'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDataTranslationsMeterSize6()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize6, "Value 6'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsMeterSize8()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize8, "Value 8'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsMeterSize10()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize10, "Value 10'' ");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDataTranslationsMeterSize12()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize12, "Value 12 ");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDataTranslationsMeterSize16()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize16, "Value 16 ");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDataTranslationsMeterSize20()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSize20, "Value 20 ");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDataTranslationsOkButton()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(btnOk, "Ok Button ");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsCancelButton()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(btnCancel, "Cancel Button ");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDataTranslationsCancelUpdate()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.ClickElement(xValue, "");
            driver.ClickElement(utilityBox2, "");
            driver.SendKeysToElementAndPressEnter(utilityBox2, "3/4", "Utility Value");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsEnterValue()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(meterSizeMappingPage, TimeSpan.FromSeconds(30));
            driver.ClickElement(xValue, "");
            driver.ClickElement(utilityBox2, "");
            driver.SendKeysToElementAndPressEnter(utilityBox2, "3/4", "Utility Value");
            driver.ClickElement(btnOk, "Ok");
        }
        public void ValidateDataTranslationsFields()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.CheckElementDisplayed(meterSize, "Meter Size");
            driver.CheckElementDisplayed(registerUOM, "Register UOM");
        }
        public void ValidateRegisterUOMEnterValue()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.CheckElementDisplayed(registerUOM, "Register UOM");
            driver.WaitForElement(registerUOMTitle, TimeSpan.FromSeconds(30));
            driver.ClickElement(xValue, "");
            driver.SendKeysToElementAndPressEnter(utilityBox2, "Gal", "Utility Value");
            driver.ClickElement(btnOk, "OK");
        }

        public void ValidateBillingAutomation()
        {
            driver.CheckElementDisplayed(billingAutomation, "Billing Automation");
        }
        public void ValidateBillingAutomationEdit()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.ClickElement(btnEdit, "Edit");
        }

        public void ValidateIgnoreOpenRoutes()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(ignoreOpenRoutes, "Ignore Open Routes");
            testReport.Info("Default Option is : " + driver.GetElementText(ignoreOpenRoutes));
        }
        public void ValidateSftpDefaultOption()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(sftpDefaultoption, "sftp Default option");
            testReport.Info("Default Option is : " + driver.GetElementText(sftpDefaultoption));
        }
        public void ValidateCopyImportError()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(copyImportLogs, "copy Import Logs");
        }
        public void ValidateCopyExporttoSFTP()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(copyExport, "copy Export to SFTP");
        }
        public void ValidateCopyExporttoSFTPDefaultOption()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(copyExportDefaultOption, "copy Export to SFTP Default Option");
            if (driver.GetElementText(copyExportDefaultOption).Contains("NO"))
            {
                testReport.Pass("Default Option is No");
            }
            //testReport.Info("Default Option is : " + driver.GetElementText(copyExportDefaultOption));
        }
        public void ValidateCopyImportErrorDefaultOption()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(copyImportDefaultOption, "copy Import to SFTP Default Option");
            if (driver.GetElementText(copyImportDefaultOption).Contains("NO"))
            {
                testReport.Pass("Default Option is No");
            }
            //testReport.Info("Default Option is : " + driver.GetElementText(copyExportDefaultOption));
        }
        public void ValidateBillingAutomationEditFunctionality()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(ignoreOpenRouteswitch, "Ignore Open Route Switch");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));

        }
        public void ValidateBillingAutomationFields()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.WaitForElement(sftpConfiguration, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(importAutomation, driver.GetElementText(importAutomation));
            driver.CheckElementDisplayed(sftpConfiguration, driver.GetElementText(sftpConfiguration));
            driver.CheckElementDisplayed(sftpUsername, driver.GetElementText(sftpUsername));
            driver.CheckElementDisplayed(sftpPassword, driver.GetElementText(sftpPassword));
            driver.CheckElementDisplayed(sftpHostname, driver.GetElementText(sftpHostname));
            driver.CheckElementDisplayed(copyImportLogs, driver.GetElementText(copyImportLogs));
            driver.CheckElementDisplayed(copyExport, driver.GetElementText(copyExport));
        }
        public void ValidateSftpConfigSubHeader()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.WaitForElement(sftpConfiguration, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(sftpConfiguration, driver.GetElementText(sftpConfiguration));
        }
        public void ValidateImportAutomation()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.WaitForElement(sftpConfiguration, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(importAutomation, driver.GetElementText(importAutomation));
        }


        public void ValidateBillingAutomationOpenRouteHover()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(openRoutesHoverText, "Hover Text");
        }

        public void ValidateDataTranslationsEditMapingHover()
        {
            driver.ClickElement(dataTranslations, "data Translations");
            driver.CheckElementDisplayed(dataTranslationsHover, "Hover Text");
        }
        public void ValidateDataTranslationsHeading()
        {
            driver.ClickElement(dataTranslations, "data Translations");
            driver.CheckElementDisplayed(dataTranslationsHeading, "Heading");
        }
        public void ValidateMeterSizeOptionDisplays()
        {
            driver.ClickElement(dataTranslations, "data Translations");
            driver.CheckElementDisplayed(meterSize, "meterSize");
        }
        public void ValidateMeterSizeOptionAccess()
        {
            driver.ClickElement(dataTranslations, "data Translations");
            driver.ClickElement(meterSize, "meterSize");
            driver.CheckElementDisplayed(meterSizeMappingPage, driver.GetElementText(meterSizeMappingPage));
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateMeterSizeTitle()
        {
            driver.ClickElement(dataTranslations, "data Translations");
            driver.ClickElement(meterSize, "meterSize");
            driver.WaitForElement(By.XPath("//a[@aria-label='Close']"), TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(meterSizeMappingPage, driver.GetElementText(meterSizeMappingPage));
            //driver.ClickElement(btnCancel, "Cancel");

            driver.ClickElement(By.XPath("//a[@aria-label='Close']"), "metersizepopupclosedbutton");
        }
        public void ValidateMeterSizeCloseAccess()
        {
            driver.ClickElement(dataTranslations, "data Translations");
            driver.ClickElement(meterSize, "meterSize");
            driver.WaitForElement(meterSizeClose, TimeSpan.FromSeconds(10));
            driver.ClickElement(meterSizeClose, "Close(X)");
        }
        public void ValidateMeterSizeNeptune360Value()
        {
            driver.ClickElement(dataTranslations, "data Translations");
            driver.ClickElement(meterSize, "meterSize");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Value, "neptune360Value");
            driver.ClickElement(meterSizeClose, "Close(X)");
        }

        public void ValidateMeterSizeUtilityDialogue()
        {
            driver.ClickElement(dataTranslations, "data Translations");
            driver.ClickElement(meterSize, "meterSize");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(utilityValues, "utilityValues");
            driver.ClickElement(meterSizeClose, "Close(X)");
        }
        public void ValidateImportRulesEditCancel()
        {
            driver.ClickElement(importRules, "import Rules");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateDataTranslationsDisplayed()
        {
            driver.CheckElementDisplayed(dataTranslations, "data Translations");
        }
        public void ValidateExportRulesAccess()
        {
            driver.ClickElement(exportRules, "export Rules");
        }
        public void ValidateExportRulesEditButtonDisplay()
        {
            driver.ClickElement(exportRules, "export Rules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(btnEdit, "Edit");
        }
        public void ValidateExportRulesEditButtonAccess()
        {
            driver.ClickElement(exportRules, "export Rules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEdit, "Edit");
        }
        public void ValidateExportRulesEditButtonSave()
        {
            driver.ClickElement(exportRules, "export Rules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(overwriteReadDate, "Switch");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));
        }
        public void ValidateExportRulesEditButtonCancel()
        {
            driver.ClickElement(exportRules, "exportRules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(overwriteReadDate, "Switch");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));
        }
        public void ValidateGeneralRulesEditButtonSave()
        {
            driver.ClickElement(general, "General Rules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(overwriteReadDate, "Switch");
            driver.ClickElement(btnSave, "Save");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(toastMessage, driver.GetElementText(toastMessage));
        }
        public void ValidateGeneralRulesEditButtonAccess()
        {
            driver.ClickElement(general, "General Rules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnEdit, "Edit");
        }
        public void ValidateGeneralRulesEditButtonDisplay()
        {
            driver.ClickElement(general, "General Rules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(btnEdit, "Edit");
        }
        public void ValidateGeneralRulesEditButtonNotDisplay()
        {
            driver.ClickElement(general, "General Rules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }


        public void ValidateGeneralRulesDetailsDisplay()
        {
            driver.ClickElement(general, "General Rules");
            driver.WaitForElement(btnEdit, TimeSpan.FromSeconds(30));
            //driver.CheckElementDisplayed(generalv4xpath, "Details");
        }


        public void ValidateBillingAutomationSftpConfigHover()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(sftpConfigHoverText, "sftp Config Hover Text");
        }
        public void ValidateBillingAutomationimportErrorHover()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(importErrorHoverText, "import Error Hover Text");
        }
        public void ValidateBillingAutomationCopyExportHover()
        {
            driver.ClickElement(billingAutomation, "Billing Automation");
            driver.CheckElementDisplayed(copyExport, "Copy Export to SFTP Hover Text");
        }

        public void ValidateRegisterUOMEnterValueCancel()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(registerUOMTitle, TimeSpan.FromSeconds(30));
            driver.ClickElement(xValue, "");
            driver.SendKeysToElementAndPressEnter(utilityBox2, "Gal", "Utility Value");
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(registerUOM, TimeSpan.FromSeconds(20));
            driver.ClickElement(registerUOM, "Register UOM");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateRegisterUOMPlaceholderDropdown()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(registerUOMTitle, TimeSpan.FromSeconds(30));
            driver.ClickElement(utilityValueBox, "Utility Value Box");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateRegisterUOMPlaceholderValue()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(registerUOMTitle, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(valueGal, "Gal");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateRegisterUOMUpdateValue()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(registerUOMTitle, TimeSpan.FromSeconds(30));
            driver.ClickElement(xValue, "");
            driver.SendKeysToElementAndPressEnter(utilityBox2, "Gal", "Utility Value");
            driver.ClickElement(btnOk, "Ok");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(30));
        }


        public void ValidateRegisterUOMStandardValues()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(registerUOMTitle, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(utiliValueGal, "Gal");
            driver.ClickElement(btnCancel, "");
        }
        public void ValidateRegisterUOMFieldValues()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(registerUOMTitle, TimeSpan.FromSeconds(30));
            driver.ClickElement(xValue, "");
            driver.SendKeysToElementAndPressEnter(utilityBox2, "Cubic Feet", "Utility Value");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            string s = driver.GetElementText(toastMessage);
            testReport.Info(s);
            driver.ClickElement(btnCancel, "");
        }

        public void ValidateDataTranslationsNeptune360Values()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(neptune360Value, driver.GetElementText(neptune360Value));
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateDataTranslationsNeptune360ValuestoHome()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(neptune360Value, driver.GetElementText(neptune360Value));
            driver.ClickElement(btnCancel, "Cancel");
            driver.ClickElement(By.XPath("//div[1]/sd-main/div/ng-sidebar-container/div//div/sd-toolbar/div/i"), "Home");
        }

        public void ValidateNeptune360ValuesCloseXAccess()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.ClickElement(Xbutton, "X");
        }
        public void ValidateRegistertUOMCancelAccess()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateRegistertUOMCubicFeet()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(cubicFeet, "Cubic Feet");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateRegistertUOMGallons()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(gallons, "Gallons");
            driver.ClickElement(btnCancel, "Cancel");
        }


        public void ValidateRegistertUOMCubicMeters()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(cubicMeter, "cubic Meter");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateRegistertUOMImperialGallons()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(imperialGallons, "imperial Gallons");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateRegistertUOMLitres()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(neptune360Value, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(litres, "litres");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateMeterSizeSave()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "meter Size");
            driver.ClickElement(btnOk, "ok");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(toastMessage, "Save Message");
        }
        public void ValidateMeterSizeValue()
        {
            Thread.Sleep(5000);
            driver.WaitForElementNotExists(pageLoader, 60);
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "meter Size");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            //driver.ClickElement(utilityValueBox, "Box");
            if (!driver.ElementPresent(value5_8, ""))
            {
                driver.SendKeysToElementAndPressEnter(By.XPath("//span[contains(text(),'5/8')]/parent::td//following-sibling::td//kendo-searchbar//input"), "5/8", "Meter Size 5/8");
                driver.ClickElement(btnOk, "Ok Button ");
                driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
                driver.WaitForElementNotExists(pageLoader, 60);

                driver.ClickElement(dataTranslations, "Data Translations");
                driver.ClickElement(meterSize, "meter Size");
                driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(60));

                driver.CheckElementDisplayed(value5_8, "Value 5/8");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateMeterSizeLength()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "meter Size");
            driver.ClickElement(xValue, "X");
            driver.SendKeysToElementAndPressEnter(utilityBox2, "12345678", "Value Box");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateRegistertUOMTitle()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.CheckElementDisplayed(registerUOMTitle, "Title");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateRegistertUOMDisplay()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.CheckElementDisplayed(registerUOM, "Register UOM");
        }


        public void ValidateDataTranslationsMappingSuccessToast()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            //driver.ClickElement(utilityValueBox, "Box");
            driver.ClickElement(value5_8, "5/8");
            driver.ClickElement(utilityValueBox, "Box");
            driver.ClickElement(value5_8, "5/8");
            driver.ClickElement(btnOk, "Ok Button ");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            testReport.Info(driver.GetElementText(toastMessage));
        }
        public void ValidateRegisterUOMUtilityValueComboBox()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(utilityValueBox, "Utility Value Combo Box");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateRegisterUOMComboBoxPlaceholderText()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(utilityValueBox, "Utility Value Combo Box");
            driver.ClickElement(utilityValueBox, "Utility Value Combo Box");
            driver.ClickElement(valueGal, "");
            driver.CheckElementDisplayed(utilityValueBox, "Placeholder");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateRegisterUOMComboBoxPlaceholderClick()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(utilityValueBox, "Utility Value Combo Box");
            driver.ClickElement(utilityValueBox, "Utility Value Combo Box");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateRegisterUOMComboBoxPlaceholderEnterValue()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(utilityValueBox, "Utility Value Combo Box");
            driver.ClickElement(xValue, "");
            driver.SendKeysToElementAndPressEnter(utilityValueBox, "Gal", "Utility Value Combo Box");
            driver.SendKeysToElementAndPressEnter(utilityValueBox, "Gal", "Utility Value Combo Box");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateRegisterUOMComboBoxPlaceholderDeleteValue()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(registerUOM, "Register UOM");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(utilityValueBox, "Utility Value Combo Box");
            driver.ClickElement(xValue, "");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateMeterSizeDeleteValue()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "Meter Size");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            driver.ClickElement(By.XPath("(//span[@class='k-icon k-i-close'])[1]"), "");
            driver.ClickElement(btnCancel, "Cancel");
        }

        public void ValidateMeterSizeEnterValue()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "meter Size");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementAndPressEnter(utilityValueBox, "Gal", "Utility Value Combo Box");
            driver.ClickElement(utilityValueBox, "");
            driver.SendKeysToElementAndPressEnter(utilityValueBox, "Gal", "Utility Value Combo Box");
            driver.ClickElement(btnCancel, "Cancel");
        }
        public void ValidateMeterSizeSelectFromDropdown()
        {
            driver.ClickElement(dataTranslations, "Data Translations");
            driver.ClickElement(meterSize, "meter Size");
            driver.WaitForElement(utilityValueBox, TimeSpan.FromSeconds(30));
            driver.SendKeysToElementAndPressEnter(utilityValueBox, "Gal", "Utility Value Combo Box");
            driver.ClickElement(btnCancel, "Cancel");
        }

    }
}
