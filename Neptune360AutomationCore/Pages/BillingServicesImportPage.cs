using OpenQA.Selenium;
using Keys = OpenQA.Selenium.Keys;

namespace Neptune360UIAutomation
{
    public class BillingServicesImportPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By btnImport = By.XPath("//button[text()='Import']");
        private By rowFileName = By.XPath("//table[@class='k-grid-table']//tr/td[1]");
        private By btnBrowse = By.XPath("//span[text()='Browse']");
        private By msgImportComplete = By.XPath("//span[contains(text(), 'Import Complete']");
        private By btnBackImportScreen = By.XPath("//button[text()='Back']");
        private By lblFileUpload = By.XPath("//span[text()='File Upload']");
        private By lblFileValidation = By.XPath("//span[text()='File Validation']");
        private By lblLoadingRecords = By.XPath("//span[text()='Loading Records']");
        private By lblLoadingReads = By.XPath("//span[text()='Loading Reads']");
        private By imgSpinnerWheel = By.XPath("//div[@class='spinning-cog']/i");
        private By lblComplete = By.XPath("//span[text()='Complete']");
        private By lblInProgress = By.XPath("//span[text()='In Progress']");
        private By lblFailed = By.XPath("//span[text()='Failed']");
        private By unSupportFile = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/sd-import-summary/div/div[3]/div/div[2]/sd-file-upload/div/div[1]/div[2]/div/div");
        private By importComplete = By.Id("toast-container");
        private By btnContinue = By.XPath("//button[text()='Continue']");
        private By btnDeactivate = By.XPath("//button[text()='Deactivate active route(s)']");
        private By txtFilename = By.XPath("//*[@id='importGrid']/div/div/div/table/thead/tr/th[1]");
        private By txtEmail = By.XPath("//*[@id='importGrid']/div/div/div/table/thead/tr/th[2]");
        private By txtDateTime = By.XPath("//*[@id='importGrid']/div/div/div/table/thead/tr/th[3]");
        private By txtStatus = By.XPath("//*[@id='importGrid']/div/div/div/table/thead/tr/th[4]");
        private By rowEmail = By.XPath("//table[@class='k-grid-table']//tr/td[2]");
        private By rowDateTime = By.XPath("//table[@class='k-grid-table']//tr/td[3]");
        private By rowStatus = By.XPath("//table[@class='k-grid-table']//tr/td[4]");
        private By btnCancel = By.XPath("/html/body/sd-app/div[1]/sd-main/div/ng-sidebar-container/div/div/sd-import-summary/div/div[3]/div[2]/div[2]/div[2]/button");
        private By btnYes = By.XPath("//button[text()='Yes']");
        private By btnNo = By.XPath("//button[text()='No']");
        private By rowFileone = By.XPath("//table/tbody/tr[1]/td[1]/a");
        #endregion

        /// <summary>
        /// Method to Validate Import Option
        /// </summary>
        public void ValidateImport()
        {
            driver.CheckElementExists(btnImport, "Import");
        }

        /// <summary>
        /// Method to Validate Import Option Does not Exists
        /// </summary>
        public void ValidateImportDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnImport, "Import");
        }

        /// <summary>
        /// Method to Validate Import Files
        /// </summary>
        public void ValidateImportFiles()
        {
            driver.CheckElementExists(rowFileName, "Import FileName");
        }

        /// <summary>
        /// Method to Validate Import Files Does Not Exists
        /// </summary>
        public void ValidateImportFilesDoesNotExists()
        {
            driver.CheckElementDoesnotExists(rowFileName, "Import FileName");
        }

        /// <summary>
        /// Method to Validate Back Import Button Exists
        /// </summary>
        public void ValidateBackImportButtonExists()
        {
            driver.CheckElementExists(btnBackImportScreen, "Back");
        }

        /// <summary>
        /// Method to Validate Import Successful
        /// </summary>
        public void ValidateImportSuccessful(string filename)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(filename);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.sleepTime(10000);
            driver.CheckElementExists(msgImportComplete, "Import Complete");
            driver.ClickElement(btnBackImportScreen, "Back to Import Screen");
        }

        /// <summary>
        /// Method to Validate Import Summary Contents Validation
        /// </summary>
        public void ValidateImportSummaryContentsValidation(string filepath)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(filepath);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.sleepTime(20000);
            if (driver.CheckElementExists(btnDeactivate, "Deactivate"))
            {
                driver.ClickElement(btnDeactivate, "Deactivate");
            }
            driver.WaitForElement(lblFileUpload, System.TimeSpan.FromSeconds(30));
            driver.CheckElementExists(lblFileUpload, "File Upload");
            driver.CheckElementExists(lblFileValidation, "File Validation");
            driver.CheckElementExists(lblLoadingRecords, "Loading Records");
            driver.CheckElementExists(lblLoadingReads, "Loading Reads");
        }

        /// <summary>
        /// Method to Validate Import Summary Spinner Wheel
        /// </summary>
        public void ValidateImportSummarySpinnerWheel()
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("CorrectEZR3.imp");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(imgSpinnerWheel, "Spinner Wheel");
        }

        /// <summary>
        /// Method to Validate File Upload Complete
        /// </summary>
        public void ValidateFileUploadComplete()
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("CorrectEZR3.imp");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.sleepTime(20000);
            driver.CheckElementExists(lblComplete, "Complete");
        }

        /// <summary>
        /// Method to Validate File Validation In Progress
        /// </summary>
        public void ValidateFileValidationInProgress(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementDisplayed(unSupportFile, " Files with no data are not supported ");
            
        }

        ///<summary>
        ///Method to validate import errors on the Summary screen
        ///</summary>
        public void ValidateImportErrorsonSummaryScreen(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.sleepTime(10000);
            driver.WaitForElement(btnDeactivate, System.TimeSpan.FromSeconds(20));
            //driver.ClickElement(btnContinue, "Continue");
            if (driver.CheckElementExists(btnDeactivate, "Deactivate"))
            {
                driver.ClickElement(btnDeactivate, "Deactivate");
            }
            //driver.CheckElementExists(lblFileUpload, "File Upload");
            //driver.CheckElementExists(lblInProgress, "In Progress");
            driver.WaitForElement(importComplete, System.TimeSpan.FromSeconds(90000));
        }

        ///<summary>
        ///Method to validate import list colmns
        ///</summary>
        public void ValidateImportListColumns()
        {
            driver.CheckElementExists(txtFilename, "");
            driver.CheckElementExists(txtEmail, "");
            driver.CheckElementExists(txtDateTime, "");
            driver.CheckElementExists(txtStatus, "");
        }

        ///<summary>
        ///Method to validate import list colmns
        ///</summary>
        public void ValidateImportFileListValueDetails()
        {
            driver.CheckElementExists(rowFileName, "");
            driver.CheckElementExists(rowEmail, "");
            driver.CheckElementExists(rowDateTime, "");
            driver.CheckElementExists(rowStatus, "");
            driver.ClickElement(rowFileName, "");
        }

        ///<summary>
        ///Method to validate import list colmns
        ///</summary>
        public void ValidateImportListScreen()
        {            
            driver.CheckElementExists(rowDateTime, "");
        }


        ///<summary>
        ///Method to validate display import Runs
        ///</summary>
        public void ValidateDisplayImportRuns(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.sleepTime(10000);
            //driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            //driver.ClickElement(btnContinue, "Continue");
            
            driver.WaitForElement(lblComplete, System.TimeSpan.FromSeconds(3000));
            //driver.CheckElementExists(lblComplete, "");
            //driver.CheckElementExists(lblInProgress, "");
            driver.ClickElement(btnBackImportScreen, "Back");
            driver.CheckElementExists(rowStatus, "");
        }


        ///<summary>
        ///Method to validate Cancellation prompt
        ///</summary>
        public void ValidateCancellationPrompt(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnContinue, "Continue");
            driver.WaitForElement(btnCancel, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(btnYes, System.TimeSpan.FromSeconds(5000));
            driver.CheckElementExists(btnYes, "Yes");
            driver.WaitForElement(btnNo, System.TimeSpan.FromSeconds(3000));
            driver.CheckElementExists(btnNo, "No");
        }


        ///<summary>
        ///Method to validate Confriming Cancellation
        ///</summary>
        public void ValidateConfirmingCancellation(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnContinue, "Continue");
            driver.WaitForElement(btnCancel, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(btnYes, System.TimeSpan.FromSeconds(5000));            
            driver.ClickElement(btnYes, "Yes");
            driver.CheckElementExists(rowFileName, "");
        }

        ///<summary>
        ///Method to validate Cancelling Confirmation  
        ///</summary>
        public void ValidateCancellingConfirmation(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnContinue, "Continue");
            driver.WaitForElement(btnCancel, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(btnNo, System.TimeSpan.FromSeconds(5000));
            driver.ClickElement(btnNo, "No");
        }

        ///<summary>
        ///Method to validate Cancel button not displayed  
        ///</summary>
        public void ValidateCancelButtonNotDisplayed(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnContinue, "Continue");
            driver.WaitForElement(btnCancel, System.TimeSpan.FromSeconds(20));
            driver.CheckElementExists(btnCancel, "Cancel");
            driver.WaitForElement(importComplete, System.TimeSpan.FromSeconds(20000));
            driver.CheckElementExists(importComplete, "Import Complete");
        }

        ///<summary>
        ///Method to validate Cancel button displayed  
        ///</summary>
        public void ValidateCancelButtonDisplayed(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnContinue, "Continue");
            driver.WaitForElement(btnCancel, System.TimeSpan.FromSeconds(20));
            driver.CheckElementExists(btnCancel, "Cancel");
        }

        ///<summary>
        ///Method to validate Import process completed  
        ///</summary>
        public void ValidateImportProcessCompleted(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnContinue, "Continue");
            driver.WaitForElement(btnCancel, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(btnNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnNo, "No");
            driver.ClickElement(btnBackImportScreen, "Back");
            driver.CheckElementDisplayed(rowFileName, "");
        }

        ///<summary>
        ///Method to validate Cancel button should not display after import is complete  
        ///</summary>
        public void ValidateImportProcessCompletedCancelBtnNotDisplay(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnContinue, "Continue");
            driver.WaitForElement(btnCancel, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(btnNo, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnNo, "No");
            driver.WaitForElement(importComplete, System.TimeSpan.FromSeconds(20000));
            driver.CheckElementDisplayed(importComplete, "");
            driver.ClickElement(btnBackImportScreen, "Back");
            driver.CheckElementDisplayed(rowFileName, "");
        }


        ///<summary>
        ///Method to validate Cancel button displayed to the user who initiated the import  
        ///</summary>
        public void CancelButtonisDiplayedToUser(string importFile)
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys(importFile);
            SimulateSendKeys("{ENTER}");
            driver.ClickElement(btnImport, "Import");
            driver.WaitForElement(btnContinue, System.TimeSpan.FromSeconds(20));
            driver.ClickElement(btnContinue, "Continue");
            driver.ClickElement(btnBackImportScreen, "Back");
            driver.ClickElement(rowFileName, "");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Validate File Validation Complete
        /// </summary>
        public void ValidateFileValidationCompleted()
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("Test");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(lblFileUpload, "File Upload");
            driver.CheckElementExists(lblComplete, "Complete");
        }

        /// <summary>
        /// Method to Validate Loading Records In Progress
        /// </summary>
        public void ValidateLoadingRecordsInProgress()
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("Test");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(lblLoadingRecords, "Loading Records");
            driver.CheckElementExists(lblInProgress, "In Progress");
        }

        /// <summary>
        /// Method to Validate Loading Records Complete
        /// </summary>
        public void ValidateLoadingRecordsCompleted()
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("Test");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(lblLoadingRecords, "Loading Records");
            driver.CheckElementExists(lblComplete, "Complete");
        }

        /// <summary>
        /// Method to Validate Loading Reads In Progress
        /// </summary>
        public void ValidateLoadingReadsInProgress()
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("Test");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(lblLoadingReads, "Loading Reads");
            driver.CheckElementExists(lblInProgress, "In Progress");
        }

        /// <summary>
        /// Method to Validate Loading Reads Complete
        /// </summary>
        public void ValidateLoadingReadsCompleted()
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("Test");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(lblLoadingReads, "Loading Reads");
            driver.CheckElementExists(lblComplete, "Complete");
        }

        /// <summary>
        /// Method to Validate File Validation Failed
        /// </summary>
        public void ValidateFileValidationFailed()
        {
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("Test");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(lblFileUpload, "File Upload");
            driver.CheckElementExists(lblFailed, "Failed");
        }

        /// <summary>
        /// Method to Validate Import File Selection
        /// </summary>
        public void ValidateImportFileSelection()
        {
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(rowFileName, "Import List");
            driver.CheckElementExists(btnImport, "Import");
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(btnBrowse, "Browse");
            driver.ClickElement(btnBrowse, "Browse");
            SimulateSendKeys("Test");
            SimulateSendKeys(Keys.Enter);
            driver.ClickElement(btnImport, "Import");
            driver.CheckElementExists(lblFileUpload, "File Upload");
            driver.CheckElementExists(lblFileValidation, "File Validation");
            driver.CheckElementExists(lblLoadingRecords, "Loading Records");
            driver.CheckElementExists(lblLoadingReads, "Loading Reads");
        }
    }
}
