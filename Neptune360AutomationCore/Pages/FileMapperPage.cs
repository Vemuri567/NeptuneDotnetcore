using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Neptune360UIAutomation
{
    public class FileMapperPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By fileMapperTitle = By.XPath("//h2[contains(.,'File Mapper')]");
        private By breadcrumb = By.XPath("//sd-toolbar/div/span/span");
        private By backButton = By.XPath("//span[contains(.,'Back')]");
        private By filemapperBackbutton = By.XPath("//button[contains(.,'Back')]");
        private By filemapperNextButton = By.XPath("//button[contains(.,'Next')]");
        private By nextButton = By.XPath("//span[contains(.,'Next')]");
        private By selectSourcefile = By.XPath("//div[contains(text(),'Select a Source File:')]");
        private By selectMapingConfig = By.XPath("//div[contains(text(),'Select a Mapping Configuration:')]");
        private By textBox = By.XPath("//label/label");
        private By browseBtn = By.XPath("//span[contains(.,'Browse')]");
        private By begingNewMapping = By.XPath("//label[contains(.,'Begin New Mapping')]");
        private By useSaasItem = By.XPath("//label[contains(.,'Use SAAS')]");
        private By useExistingMapping = By.XPath("//label[contains(.,'Use doubleQuote-semicolon Mapping')]");

        #endregion


        public void ValidateFileMapperTitle()
        {
            driver.CheckElementDisplayed(fileMapperTitle, "Title");
        }

        public void ValidateFileMapperBreadcrumb()
        {
            driver.CheckElementDisplayed(breadcrumb, driver.GetElementText(breadcrumb));
        }
        public void ValidateFileMapperBackbutton()
        {
            driver.CheckElementDisplayed(backButton, "Back ");
        }

        public void ValidateFileMapperBackbuttonDisabled()
        {
            // driver.IsElementDisabled(backButton, "Back ");
            bool text=driver.FindElement(filemapperBackbutton).Enabled;
            if (text==false)
            {
                testReport.Pass("backbutton is disabled");
            }
            else
            {
                ReporterFactory.LogFailure("Backbutton is enabled");
            }
        }

        public void ValidateFileMapperNextbuttonDisplay()
        {
            driver.CheckElementDisplayed(nextButton, "Next ");
        }
        public void ValidateFileMapperNextbuttonDisabled()
        {
            bool text = driver.FindElement(filemapperNextButton).Enabled;
            if (text == false)
            {
                testReport.Pass("nextbutton is disabled");
            }
            else
            {
                ReporterFactory.LogFailure("nextbutton is enabled");
            }
        }

        public void ValidateFileMapperSourceFileText()
        {
            driver.CheckElementDisplayed(selectSourcefile, " select a Source file");
        }
        public void ValidateFileMapperSelectMappingConfig()
        {
            driver.CheckElementDisplayed(selectMapingConfig, " select Maping Config ");
        }
        public void ValidateFileMapperSelectMappingConfigOneItem()
        {
            driver.CheckElementDisplayed(begingNewMapping, " beging New Mapping ");
        }
        public void ValidateFileMapperSelectMappingSelectEachItem()
        {
            driver.ClickElement(begingNewMapping, " beging New Mapping ");
            driver.ClickElement(useExistingMapping, "Use doubleQuote-semicolon Mapping Item");
        }
        public void ValidateFileMapperSelectMappingNextBtnDisable()
        {
            driver.CheckElementDisplayed(begingNewMapping, " beging New Mapping ");
            //driver.IsElementDisabled(nextButton, "Next");
            bool text = driver.FindElement(filemapperNextButton).Enabled;
            if (text == false)
            {
                testReport.Pass("nextbutton is disabled");
            }
            else
            {
                ReporterFactory.LogFailure("nextbutton is enabled");
            }
        }
        public void ValidateFileMapperTextBoxDisplay()
        {
            driver.CheckElementDisplayed(textBox, "Text Box ");
        }
        public void ValidateFileMapperBrowseBtnDisplay()
        {
            driver.CheckElementDisplayed(browseBtn, "Browse");
        }
    }
}
