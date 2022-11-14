using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class OnlineHelpPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By righArrow = By.CssSelector(".fa-caret-down:nth-child(1)");
        private By helpContents = By.XPath("//span[contains(.,'Help Contents')]");
        private By aboutNeptune360 = By.XPath("//span[contains(.,'About Neptune 360')]");
        private By modal = By.XPath("//div[contains(text(),' About Neptune 360 ')]");
        private By copyright = By.XPath("//kendo-dialog[@id='About-Neptune360']/div[2]/div/span");
        private By btnDashBoard = By.XPath("//img[contains(@src,'Dashboard.3D')]");
        private By detailReport = By.XPath("//span[text()='System Consumption']/..//a[contains(text(),'Detail Report')]");
        private By topTenConsumtionDetailReport = By.XPath("//div[3]/div/span[2]/a");
        private By btnCustInquiry = By.XPath("//img[contains(@src,'CustomerInquiry.3D')]");
        private By btnImport = By.XPath("//button[text()='Import']");
        private By btnBillingServices = By.XPath("//img[contains(@src,'BillingServices.3D')]");
        private By btnReports = By.XPath("//img[contains(@src,'Reports.icon')]");
        private By btnUserManagement = By.XPath("//img[contains(@src,'UserManagement.3D')]");
        private By btnNotification = By.XPath("//img[contains(@src,'Notifications.3D')]");
        private By questionMark = By.CssSelector(".fa-question");
        private By btnCloseModal = By.CssSelector(".k-i-x");
        private By searchBox = By.XPath("//input[@type='search']");
        private By searchResult = By.XPath("//h3[contains(*,'Dashboard')]");
        private By invalidResult = By.XPath("//h1[@id='results-heading']/span");
        private By welcomeLink = By.XPath("(//a[contains(text(),'Welcome')])[2]");
        private By dashboardLink = By.XPath("(//a[contains(text(),'Dashboard')])[2]");
        private By btnPrint = By.XPath("//button[@title='Print']");
        private By advancedButton = By.Id("details-button");
        private By proceedLink = By.Id("proceed-link");
        private By neptune360Help = By.XPath("//span[contains(.,' 360™ Help System')]");
        private By contextualHelp = By.CssSelector(".logo");

        private By splashIconnCustInq = By.XPath("//img[contains(@src,'Neptune360.Inquiry')]");
        private By splashUserManagement = By.XPath("//img[contains(@src,'Neptune360.User')]");
        private By splashUtilityManagement=By.XPath("//img[contains(@src,'Neptune360.Utility')]");


        private By lftNavBillingServices = By.XPath("//span[text()='BILLING SERVICES']");
        private By lftNavImportFiles = By.XPath("//span[text()='IMPORT FILES']");
        private By lftNavExportFiles = By.XPath("//span[text()='EXPORT FILES']");
        private By lftNavExportHistory = By.XPath("//span[text()='EXPORT HISTORY']");
        private By lftNavUtilityManagement = By.XPath("//span[text()='UTILITY MANAGEMENT']");
        private By lftNavAlertConfig = By.XPath("//span[text()='ALERT NOTIFICATIONS']");
        private By lftNavDeviceManagement = By.XPath("//span[text()='DEVICE MANAGEMENT']");
        private By lftNavUserManagement = By.XPath("//span[text()='USER MANAGEMENT']");
        private By lftNavPlatformManagement = By.XPath("//span[text()='PLATFORM MANAGEMENT']");
        private By lftNavRoleManagement = By.XPath("//span[text()='ROLE MANAGEMENT ']");
        private By lftNavEmailNotification = By.XPath("//span[text()='EMAIL NOTIFICATION']");
        private By completeCount = By.XPath("//div[2]/div/sd-dashboardcard/div/div[2]/h1/span/a");

        private By completeRight = By.XPath("//div[2]/div/sd-dashboardcard//div[1]/h1/div[2]");
        private By gatewayRight = By.XPath("//div[8]/div/sd-dashboardcard/div/div[1]/h1/div[2]");
        private By gatewayCount = By.XPath("//div[8]/div/sd-dashboardcard/div/div[2]/h1");
        private By criticalContinuous = By.XPath("(//sd-dashboardcard)[3]//following-sibling::span[@class]//a");
        private By continuousConsumptionRight = By.XPath("(//sd-dashboardcard)[3]//following-sibling::div[@class='pull-right fa fa-caret-right']");
        private By majorReverseFlowCount = By.XPath("//div[5]/div/sd-dashboardcard/div/div[2]/h1/span/a");
        private By reverseFlowRight = By.XPath("//div[5]//sd-dashboardcard//div[1]/h1/div[2]");
        private By topConsumptionActualDetail = By.XPath("//span[contains(text(),'Top')]/..//a[contains(text(),'Detail Report')]");
        #endregion

        /// <summary>
        /// Method to Validate Title Display landing page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageQuestionMark()
        {
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Title Display Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkMenuArrowDashboard()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            if(!driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10)))
            {
                driver.ClickElement(advancedButton, "Advanced");
                driver.ClickElement(proceedLink, "Proceed");
            }
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Reports Question Mark
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkReports()
        {
            driver.ClickElement(btnReports, "Reports");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.sleepTime(7000);
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

       

        /// <summary>
        /// Method to Validate Title Display Dashboard Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkMenuArrowDashboardHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Question Mark Menu Arrow Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionDashboardDetailReportArrow()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.ClickElement(detailReport, "Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Question Dashboard Top10 Detail Report Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionDashboardTop10DetailReportArrow()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Question Report Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionCustomerInquiryQuestionReportArrow()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionCustomerInquiryHelpContent()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportHelpContentPage()
        {
            driver.ClickElement(btnBillingServices, "Customer Inquiry");
            driver.WaitForElement(btnImport, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Billing Services Import Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void BillingServicesImportQuestiontArrow()
        {
            driver.ClickElement(btnBillingServices, "Customer Inquiry");
            driver.WaitForElement(btnImport, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Billing Services Export Files Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void BillingServicesExportFilesQuestiontArrow()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export Files");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Billing Services Export Files Help Content Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportFilesHelpContentPage()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export Files");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Billing Services Export History Help Content Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryHelpContentPage()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Device Management Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportDeviceManagementHelpContent()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate User Management Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportUserManagementHelpContent()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Dashboard Detailed Report Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardDetailedReportHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detail Report");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Dashboard Top 10 Detailed Report Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardTop10DetailedReportHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Detail Report");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Complete Reading Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CompleteReadingHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Complete Reading About Neptune 360
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CompleteReadingAboutNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "AboutNeptune360");
        }
        /// <summary>
        /// Method to Validate Question MArk Complete Reading
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMArkCompleteReading()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question MArk Complete Reading
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMArkVisibleCompleteReading()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
        }

        /// <summary>
        /// Method to Validate Complete Reading Right Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CompleteReadingRightArrow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "RightArrow");
        }

        /// <summary>
        /// Method to Validate Question MArk Complete Reading Visible
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkCompleteReadingVisible()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
        }

        /// <summary>
        /// Method to Validate ModalComplete Reading
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCompleteReadings()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.sleepTime(5000);
            driver.ClickElement(completeCount, "Complete Count");
            
            driver.ClickElement(righArrow, "Arrow");
            driver.sleepTime(5000);
            driver.ClickElement(aboutNeptune360, "AboutNeptune360");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(modal, "Modal");
            driver.sleepTime(5000);
            driver.ClickElement(btnCloseModal, "Close");
        }


        /// <summary>
        /// Method to Validate Copyright Statement Complete Reading 
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementCompleteReadings()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "AboutNeptune360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "Modal");
        }


        /// <summary>
        /// Method to Validate Incomplete Reading Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IncompleteReadingHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeCount, "Incomplete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Incomplete Reading Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IncompleteReadingContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeCount, "Incomplete Count");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Incomplete Reading AboutNeptune360
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IncompleteReadingAboutNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeCount, "Incomplete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate Question Mark Incomplete Reading 
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkIncompleteReading()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeCount, "Incomplete Count");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Incomplete Reading 
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleIncompleteReading()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeCount, "Incomplete Count");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
        }
        /// <summary>
        /// Method to Validate Question Mark Incomplete Reading Visible
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkIncompleteReadingVisible()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeCount, "Incomplete Count");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
        }

        /// <summary>
        /// Method to Validate Modal Incomplete Reading
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalIncompleteReadings()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeCount, "Incomplete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "Modal");
        }

        /// <summary>
        /// Method to Validate Copyright Statement Incomplete Reading
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementIncompleteReading()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Right");
            driver.ClickElement(completeCount, "Incomplete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "Modal");
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Landing Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleLandingPage()
        {
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }



        /// <summary>
        /// Method to Validate Question Mark Visible Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleDashboard()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }
        /// <summary>
        /// Method to Validate Question Mark Visible Dashboard System Consumption Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleDashboardSystemConsumptionDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "System Consumption Detail Report");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Dashboard Top 10 Acc Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleDashboardTop10AccDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "System Consumption Detail Report");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleCustomerInquiry()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Import
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleImport()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.WaitForElement(btnImport, TimeSpan.FromSeconds(20));
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Export
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleExport()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export Files");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Export History
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleExportHistory()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Divice Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleDiviceManagement()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Divice Management");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible User Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleUserManagement()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Route Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleRouteManagement()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.sleepTime(7000);
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }


        /// <summary>
        /// Method to Validate Question Mark Visible Alert Configuration
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleAlertConfiguration()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavAlertConfig, "Alert Configration");
            driver.sleepTime(7000);
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Print_Help_Documents_Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void printHelpDocumentsDashboard()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='User Management']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Print_Help_Documents_User_Management_from_Landing_Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void printHelpDocumentsUserManagementLandingPage()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='User Management']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Print_Help_Documents Top 10 Accounts
        /// @Author - Gurudas Puthal
        /// </summary>
        public void printHelpDocumentsTop10Accounts()
        {
            driver.ClickElement(btnDashBoard, "DashBoard");
            driver.ClickElement(topConsumptionActualDetail, "Top 10 Accounts");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Print_Help_Documents Top 10 Accounts
        /// @Author - Gurudas Puthal
        /// </summary>
        public void printHelpDocumentsCompleteReadings()
        {
            driver.ClickElement(btnDashBoard, "DashBoard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Landing Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleLandingPage()
        {
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleDashboard()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Dashboard System_Consumption_Detail_Repor
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleDashboardSystemConsumptionDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detail Report");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Dashboard Top 10 System_Consumption_Detail_Repor
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleDashboardTop10SystemConsumptionDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 System_Consumption Detail Report");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }
        /// <summary>
        /// Method to Validate Question Mark Accessible Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleCustomerInquiry()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Import
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleImport()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.WaitForElement(btnImport, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Export
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleExport()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export");
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Export History
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleExportHistory()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Device Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleDeviceManagement()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible User Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleUserManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible User Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleUserManagementLandingPage()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Roles Permissions
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleRolesPermissions()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Roles Management");
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Accessible Notification
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkAccessibleNotification()
        {
            driver.ClickElement(btnNotification, "Notification");
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Roles and Permissions
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleRolesandPermissions()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Roles Management");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Visible Notifications
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleNotifications()
        {
            driver.ClickElement(btnNotification, "Notifications");
            driver.WaitForElement(questionMark, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Export History Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryQuestiontArrow()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Device Management Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementQuestiontArrow()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate User Management Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void userManagementQuestiontArrow()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "Úser Management");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate User Management Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void userManagementPrintHelp()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "Úser Management");
            driver.sleepTime(7000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.sleepTime(7000);
            driver.switchToNewWindow();
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Roles Permissions Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionsQuestiontArrow()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Notificatio Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationQuestiontArrow()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavEmailNotification, "Role Management");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Notificatio Help_Access
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationHelpAccess()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavEmailNotification, "Role Management");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Help is opened in new browser");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Landing Page User Management Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageUserManagementQuestiontArrow()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Landing Page User Management Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageUserManagementMenuArrow()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Dashboard Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingDashboardMenuArrow()
        {
            driver.ClickElement(btnDashBoard, "User Management");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Dashboard System Consumption Detail Report Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboarDetailReportMenuArrow()
        {
            driver.ClickElement(btnDashBoard, "User Management");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "System Consumption Detail Report");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Dashboard System Consumption Detail Report Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboarDetailReportPrintHelp()
        {
            driver.ClickElement(btnDashBoard, "User Management");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "System Consumption Detail Report");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryPrintHelp()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
            //driver.sleepTime(7000);
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Customer Inquiry']"), "customerinquirylink");
            driver.sleepTime(7000);
            //Actions builder = new Actions(driver);
            //builder.MoveToElement(driver.FindElement(By.XPath("//a[text()='Welcome']"))).Build().Perform();
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Import Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportPrintHelp()
        {
            driver.ClickElement(btnBillingServices, "BillingServices");
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportPrintHelp()
        {
            driver.ClickElement(lftNavBillingServices, "BillingServices");
            driver.ClickElement(lftNavExportFiles, "Export");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(7000);
            //Actions builder = new Actions(driver);
            //driver.FindElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Billing Services']")).Click();
            driver.sleepTime(7000);
            //IWebElement export=driver.FindElement(By.XPath("//ul[@class='sub-menu openRight']//a[text()='Export']"));
            //export.Click();
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export  History Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryPrintHelp()
        {
            driver.ClickElement(lftNavBillingServices, "BillingServices");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(7000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,-350)", "");
            //Actions builder = new Actions(driver);
            driver.FindElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Billing Services']")).Click();
             driver.sleepTime(7000);
            //IWebElement export = driver.FindElement(By.XPath("//ul[@class='sub-menu openRight']//a[text()='Export History']"));
            //export.Click();
            driver.CheckElementExists(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Dashboard top 10 System Consumption Detail Report Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboarTop10DetailReportMenuArrow()
        {
            driver.ClickElement(btnDashBoard, "User Management");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10System Consumption Detail Report");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryMenuArrow()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Import Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportMenuArrow()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.WaitForElement(btnImport, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnImport, "Import");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Export Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportMenuArrow()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export Files");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }
        /// <summary>
        /// Method to Validate Export History Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryMenuArrow()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Device Management Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementMenuArrow()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate User Management Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementMenuArrow()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Roles_Permissions Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionsMenuArrow()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }

        /// <summary>
        /// Method to Validate Notification Menu Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationMenuArrow()
        {
            driver.ClickElement(btnNotification, "Notification");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Menu Arrow");
        }



        /// <summary>
        /// Method to Validate Landing Page Dashboard Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageDashboardQuestiontArrow()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate DashboardTop10DetailReport Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardTop10DetailReportQuestiontArrow()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.sleepTime(5000);
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Complete Count Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CompleteCountQuestiontArrow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Incomplete Count Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IncompleteCountQuestiontArrow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Incomplete Count Print Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IncompleteCountPrintHelp()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Skipped Reading Question Mark
        /// @Author - Gurudas Puthal
        /// </summary>
        public void SkippedReadingQuestionMark()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeCount, "Skipped Reading");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Incomplete Count Right Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IncompleteCountRightArrow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(completeRight, "Right Arrow");
            driver.ClickElement(completeCount, "Complete Count");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Arrow");
        }

        /// <summary>
        /// Method to Validate critical coninous Count Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void criticalConinousQuestiontArrow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(60));
            driver.ClickElement(criticalContinuous, "Coninous Consumption");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Critical Gateway Help Access
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CriticalGatewayHelpAccess()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(criticalContinuous, "Coninous Consumption");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "questionMark");
            driver.switchToNewWindow();
            testReport.Pass("Help is opened in new browser");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Warning Gateway Help Access
        /// @Author - Gurudas Puthal
        /// </summary>
        public void WarningGatewayHelpAccess()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(gatewayRight, TimeSpan.FromSeconds(15));
            driver.ClickElement(gatewayRight, "gateway Right");
            driver.ClickElement(gatewayCount, "Warning Gateway");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "questionMark");
            driver.switchToNewWindow();
            testReport.Pass("Help is opened in new browser");
            driver.switchBackToMainWindow();
        }
        /// <summary>
        /// Method to Validate Normal  Gateway Help Access
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NormalGatewayHelpAccess()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(gatewayRight, TimeSpan.FromSeconds(15));
            driver.ClickElement(gatewayRight, "gateway Right");
            driver.ClickElement(gatewayRight, "gateway Right");
            driver.ClickElement(gatewayCount, "Warning Gateway");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "questionMark");
            driver.switchToNewWindow();
            testReport.Pass("Help is opened in new browser");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate critical coninous Count Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestiontMarkcriticalConsumption()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(criticalContinuous, "Coninous Consumption");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MajorReverseFlowQuestiontArrow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MajorReverseFlowHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Question Mark Major Reverse Flow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkMajorReverseFlow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Major Reverse Flow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleMajorReverseFlow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Neptune360
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MajorReverseFlowNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "Neptune 360");
        }

        /// <summary>
        /// Method to Validate Modal Major Reverse Flow 
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalMajorReverseFlow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "Close");
        }

        /// <summary>
        /// Method to Validate Copyright Statement Major Reverse Flow 
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementMajorReverseFlow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "Close");
        }

      

        /// <summary>
        /// Method to Validate Minor Reverse Flow Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MinorReverseFlowQuestiontArrow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(reverseFlowRight, "Right Arrow");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Minor Reverse Flow Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MinorReverseFlowHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(reverseFlowRight, "Right Arrow");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Question Mark Minor Reverse Flow 
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkMinorReverseFlow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(reverseFlowRight, "Right Arrow");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Minor Reverse Flow 
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleMinorReverseFlow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(reverseFlowRight, "Right Arrow");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
        }

        /// <summary>
        /// Method to Validate Minor Reverse Flow Neptune 360
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MinorReverseFlowNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(reverseFlowRight, "Right Arrow");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "Neptune 360");
        }

        /// <summary>
        /// Method to Validate Modal Minor Reverse Flow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalMinorReverseFlow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(reverseFlowRight, "Right Arrow");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "Modal");
        }

        /// <summary>
        /// Method to Validate Copyright Statement Minor Reverse Flow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementMinorReverseFlow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.ClickElement(reverseFlowRight, "Right Arrow");
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "Modal");
        }

        /// <summary>
        /// Method to Validate Notification Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationHelpContent()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavEmailNotification, "Email Notification");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Notification Print Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationPrintHelp()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavEmailNotification, "Email Notification");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Email Notifications']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Roles Permissions Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionsHelpContent()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Roles Permissions Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionsPrintHelp()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.CheckElementDisplayed(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }


        /// <summary>
        /// Method to Validate Landing Page Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageHelpContent()
        {
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Dashboard Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Dashboard Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardHelpContentOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Dashboard Contectual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardContectualHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.sleepTime(2000);
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate User_Management_Landing_Page Contectual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementLandingPageContectualHelpOneInstance()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.sleepTime(2000);
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Dashboard Top Ten Detail Report Contectual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardTopTenDetailReportContectualHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "DashBoard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(10));
            driver.ClickElement(topTenConsumtionDetailReport, "Top Ten Detail Report");
            driver.sleepTime(2000);
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate User Management Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementHelpContentOneInstance()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Top Ten Acc Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void TopTenAccHelpContentOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top Ten Acc Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Complete Readings Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CompleteReadingsHelpContentOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(completeCount, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeCount, "Complete Readings");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Complete Readings Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CompleteReadingsContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(completeCount, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeCount, "Complete Readings");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help");            
            driver.switchBackToMainWindow();
        }


        /// <summary>
        /// Method to Validate Incomplete Readings Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CompleteReadingsHelpIncompleteOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Complete Right");
            driver.ClickElement(completeCount, "Complete Readings");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }        

        /// <summary>
        /// Method to Validate complete Readings Contextual Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CompleteReadingsContextualHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeCount, "Complete Readings");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate complete Readings Contextual Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IncompleteReadingsContextualHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(completeRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(completeRight, "Complete Right");
            driver.ClickElement(completeCount, "Incomplete Readings");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Continuous Usage Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ContinuousUsageHelpIncontentOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(20));
            driver.ClickElement(criticalContinuous, "Continuous Usage");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Continuous Usage Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ContinuousUsageContextualHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(20));
            driver.ClickElement(criticalContinuous, "Continuous Usage");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Continuous Usage Contextua lHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ContinuousUsageHelpContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(20));
            driver.ClickElement(criticalContinuous, "Continuous Usage");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Continuous Usage Neptune 360
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ContinuousUsageNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(60));
            driver.ClickElement(criticalContinuous, "Continuous Usage");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate Qusetion Mark Continuous Usage Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QusetionMarkContinuousUsageDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(20));
            driver.ClickElement(criticalContinuous, "Continuous Usage");
            driver.CheckElementDisplayed(questionMark, "Qusetion Mark");
        }

        /// <summary>
        /// Method to Validate  Continuous Usage Right Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ContinuousUsageRightArrow()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(20));
            driver.ClickElement(criticalContinuous, "Continuous Usage");
            driver.CheckElementDisplayed(righArrow, "Right Arrow");
        }

        /// <summary>
        /// Method to Validate Modal Continuous Usage
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalContinuousUsage()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElementNotExists(By.XPath("//h4[text()='loading']"));
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(20));
            driver.ClickElement(criticalContinuous, "Continuous Usage");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "Close");
        }

        /// <summary>
        /// Method to Validate Copyright Statement Continuous Usage
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementContinuousUsage()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(60));
            driver.ClickElement(criticalContinuous, "Continuous Usage");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "Close");
        }

        /// <summary>
        /// Method to Validate Intermittent Usage Neptune 360
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IntermittentUsageNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(60));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate modal Intermittent Usage
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalIntermittentUsage()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElementNotExists(By.XPath("//h4[text()='loading']"));
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune360");
            driver.ClickElement(btnCloseModal, "Close");
        }

        /// <summary>
        /// Method to Validate Copyright Statement Intermittent Usage
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementIntermittentUsage()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElementNotExists(By.XPath("//h4[text()='loading']"));

            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(60));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "Close");
        }

        /// <summary>
        /// Method to Validate Intermittent Usage Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IntermittentUsageHelpIncontentOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Intermittent Usage Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IntermittentUsageContextualHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.ClickElement(questionMark, "questionMark");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "questionMark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Intermittent Usage Contextua lHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IntermittentUsageContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(continuousConsumptionRight, "Right");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MajorReverseFlowHelpIncontentOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(majorReverseFlowCount, TimeSpan.FromSeconds(20));
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Contextal Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MajorReverseFlowContextalHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(majorReverseFlowCount, TimeSpan.FromSeconds(20));
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MajorReverseFlowContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(majorReverseFlowCount, TimeSpan.FromSeconds(20));
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MajorReverseFlowPrintHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(majorReverseFlowCount, TimeSpan.FromSeconds(20));
            driver.ClickElement(majorReverseFlowCount, "Major Reverse Flow");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Minor Reverse Flow Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MinorReverseFlowHelpIncontentOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(reverseFlowRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(reverseFlowRight, "Right");
            driver.ClickElement(majorReverseFlowCount, "Minor Reverse Flow");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }
        /// <summary>
        /// Method to Validate Minor Reverse Flow Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MinorReverseFlowContextualHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(reverseFlowRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(reverseFlowRight, "Right");
            driver.ClickElement(majorReverseFlowCount, "Minor Reverse Flow");
            driver.ClickElement(questionMark, "questionMark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "questionMark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Minor Reverse Flow ContextualHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MinorReverseFlowContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(reverseFlowRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(reverseFlowRight, "Right");
            driver.ClickElement(majorReverseFlowCount, "Minor Reverse Flow");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Minor Reverse Flow Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void MinorReverseFlowPrintHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(reverseFlowRight, TimeSpan.FromSeconds(20));
            driver.ClickElement(reverseFlowRight, "Right");
            driver.ClickElement(majorReverseFlowCount, "Minor Reverse Flow");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Notification Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationHelpIncontentOneInstance()
        {
            driver.ClickElement(btnNotification, "Notification");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Notification Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationContextualHelpOneInstance()
        {
            driver.ClickElement(btnNotification, "Notification");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Roles Permissions Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionsContextualHelpOneInstance()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Landing Page Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageContextualHelpOneInstance()
        {
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate System Consumption Detail Report Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void SystemConsumptionDetailReportContextualHelpOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(10));
            driver.ClickElement(detailReport, "System Consumption Detail Report");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryContextualHelpOneInstance()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }
        /// <summary>
        /// Method to Validate Import Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportContextualHelpOneInstance()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavImportFiles, "Import Files");
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportContextualHelpOneInstance()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export Files");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export History Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryContextualHelpOneInstance()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Device Management Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementContextualHelpOneInstance()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate User Management Contextual Help One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementContextualHelpOneInstance()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.navigateToMainWindow();
            driver.ClickElement(questionMark, "question Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Search Box
        /// @Author - Gurudas Puthal
        /// </summary>
        public void SearchBox()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.CheckElementDisplayed(searchBox, "Search Box");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Search Box Valid Topic
        /// @Author - Gurudas Puthal
        /// </summary>
        public void SearchBoxValidTopic()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.SendKeysToElementAndPressEnter(searchBox, "Dashboard","Search Box");
            driver.WaitForElement(searchResult,TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(searchResult, "Result");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Search Box Invalid Topic
        /// @Author - Gurudas Puthal
        /// </summary>
        public void SearchBoxInvalidTopic()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.SendKeysToElementAndPressEnter(searchBox, "Abcd", "Search Box");
            driver.WaitForElement(invalidResult, TimeSpan.FromSeconds(15));
            driver.CheckElementDisplayed(invalidResult, "Invalid Topic");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Welcome
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkWelcome()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.ClickElement(welcomeLink, "Welcome");
            driver.CheckElementDisplayed(By.XPath("//h1[contains(.,'Welcome to Neptune® 360™')]"),"Welcome Link");
            //driver.CheckElementDisplayed(invalidResult, "Invalid Topic");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Welcome About the Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkAboutTheHelp()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.MoveToElement(welcomeLink, "");
            driver.sleepTime(7000);
            if (driver.VerifyDoesnotExists(By.XPath("//ul[@class='sub-menu openRight']//a[text()='About the Help']"), "About the Help"))
            {
                driver.MoveToElement(welcomeLink, "");
                driver.sleepTime(7000);
                driver.MoveToElement(welcomeLink, "");
                driver.sleepTime(7000);
            }
            driver.ClickElement(By.XPath("//ul[@class='sub-menu openRight']//a[text()='About the Help']"),"About the Help");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkDashboard()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.ClickElement(dashboardLink,"Dashboard");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkCustomerInquiry()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("(//a[contains(text(),'Customer Inquiry')])[2]"), "Customer Inquiry");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Billing Services
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkBillingServices()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("(//a[contains(text(),'Billing Services')])[2]"), "Billing Services");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Notifications
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkNotifications()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//a[text()='Notifications']"), "Notifications");
            driver.sleepTime(7000);
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Customer Inquiry']"), "Custome Inquiry");
            driver.sleepTime(7000);
            driver.switchBackToMainWindow();
        }
        
        /// <summary>
        /// Method to Validate Splash Page Icon Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void SplashPageIconCustInquiry()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.ClickElement(splashIconnCustInq, "Customer Inquiry");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Splash Page Icon User Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void SplashPageIconUserManagement()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.ClickElement(splashUserManagement, "User Management");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Splash Page Icon Utility Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void SplashPageIconUtilityManagement()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.ClickElement(splashUtilityManagement, "Utility Management");
            driver.switchBackToMainWindow();
        }


        /// <summary>
        /// Method to Validate Quick Access Link Billing Services Import
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkBillingServicesImport()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.MoveToElement(By.XPath("(//a[contains(text(),'Billing Services')])[2]"), "Billing Services");
            driver.ClickElement(By.XPath("//a[contains(text(),'Import')]"), "Import");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Billing Services Export
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkBillingServicesExport()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.MoveToElement(By.XPath("(//a[contains(text(),'Billing Services')])[2]"), "Billing Services");
            driver.ClickElement(By.XPath("//a[contains(text(),'Export')]"), "Export");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Utility Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkUtilityManagement()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();            
            driver.ClickElement(By.XPath("(//a[contains(text(),'Utility Management')])[2]"), "Utility Management");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Utility Management Device Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkUtilityManagementDeviceManagement()
        {
            
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.sleepTime(7000);
            driver.switchToNewWindow();
            driver.sleepTime(7000);
            driver.MoveToElement(By.XPath("(//a[contains(text(),'Utility Management')])[2]"), "Utility Management");
            driver.sleepTime(3000);
            driver.ClickElement(By.XPath("//a[contains(text(),'Device Management')]"), "Device Management");
            driver.sleepTime(3000);
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Quick Access Link Utility Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuickAccessLinkPlatformManagement()
        {
            driver.ClickElement(righArrow, "Right arrow");
            driver.ClickElement(helpContents, "Help contents");
            driver.switchToNewWindow();
            driver.MoveToElement(By.XPath("(//a[contains(text(),'Utility Management')])[2]"), "Utility Management");
            driver.ClickElement(By.XPath("//a[contains(text(),'Device Management')]"), "Device Management");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Notification ContextualHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationHelpContextualHelp()
        {
            driver.ClickElement(btnNotification, "Notification");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Roles and Permissions Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionsHelpIncontentOneInstance()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Roles and Permissions ContextualHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionsContextualHelp()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Landing Page Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageHelpIncontentOneInstance()
        {
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Landing Page Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageContextualHelp()
        {
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Landing Page Print_Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPagePrintHelp()
        {
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.ClickElement(neptune360Help, "Neptune Help");
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Dashboard Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryContextualHelp()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Import Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportContextualHelp()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Detail_Report Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DetailReportHelpIncontentOneInstance()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detail report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Customer Inquiry Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryHelpIncontentOneInstance()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }
        /// <summary>
        /// Method to Validate Import Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportHelpIncontentOneInstance()
        {
            driver.ClickElement(btnBillingServices, "BillingServices");
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHelpIncontentOneInstance()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export ContextualHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportContextualHelp()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }
        
        /// <summary>
        /// Method to Validate Export History Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryContextualHelp()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Device Management Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementContextualHelp()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate User Management Contextual Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementContextualHelp()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Contextual Help contents are opened in a separate browser tab ");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export History Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryHelpIncontentOneInstance()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Device Management Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementHelpIncontentOneInstance()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate User Management Help Content One Instance
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementHelpIncontentOneInstance()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.navigateToMainWindow();
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate User Management LandingPageContextualHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementLandingPageContextualHelp()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            //driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            //driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");            
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Dashboard_System_Consumption_Detail_Report ContextualHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardSystemConsumptionDetailReportContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(10));
            driver.ClickElement(detailReport, "Detail Report");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            //driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            //driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        
        /// <summary>
        /// Method to Validate Dashboard Top ten Detail_Report ContextualHelp
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardTopTenDetailReportContextualHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(10));
            driver.ClickElement(topTenConsumtionDetailReport, "Top Ten Accounts Detail Report");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            //driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            //driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Landing Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageAboutNeptune360()
        {
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardAboutNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Dashboard Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardDetailReportAboutNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Dashboard Top 10 Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardTopTenDetailReportAboutNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumtion Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryAboutNeptune360()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Import
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportAboutNeptune360()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Export
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportAboutNeptune360()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export Files");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Export History
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryAboutNeptune360()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Device Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementAboutNeptune360()
        {
            driver.ClickElement(lftNavUtilityManagement, "UtilityManagement");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }
        /// <summary>
        /// Method to Validate About Neptune 360 Device Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementPrintHelp()
        {
            driver.ClickElement(lftNavUtilityManagement, "UtilityManagement");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.sleepTime(7000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }


        /// <summary>
        /// Method to Validate About Neptune 360 User Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementAboutNeptune360()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Role Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RoleManagementAboutNeptune360()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Notification
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationAboutNeptune360()
        {
            driver.ClickElement(btnNotification, "Notification");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 User Management from Landing Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementLandingPageAboutNeptune360()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune 360");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Landing Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalLandingPageNeptune360()
        {
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Dashboard Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalDashboardPageNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }


        /// <summary>
        /// Method to Validate About Neptune 360 Modal Dashboard Detail Report Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalDashboardDetailReportPageNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal DashboardTop ten Detail Report Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalDashboardTopTenDetailReportPageNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top Ten Accounts Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryDetailReportPageNeptune360()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Import
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportDetailReportPageNeptune360()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Export
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportDetailReportPageNeptune360()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Export history
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExporthistoryDetailReportPageNeptune360()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Device Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementModalNeptune360()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Roles Permission
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionModalNeptune360()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }





        /// <summary>
        /// Method to Validate About Neptune 360 Modal User Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementModalNeptune360()
        {
            driver.ClickElement(lftNavPlatformManagement, "Utility Management");
            driver.ClickElement(lftNavUserManagement, "Device Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Roles and Permissions
        /// @Author - Gurudas Puthal
        /// </summary>
        public void RolesPermissionsModalNeptune360()
        {
            driver.ClickElement(lftNavPlatformManagement, "Utility Management");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Notification
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NotificationModalNeptune360()
        {
            driver.ClickElement(btnNotification, "Notification");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal User_Management_from_Landing_Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementLandingPageModalNeptune360()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement - Landing Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementLandingPage()
        {
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementDashboard()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Dashboard System Consumption Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "System Consumption Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Dashboard Top 10 Accounts System Consumption Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementTopTenAccountsDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Accounts System Consumption Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementCustomerInquiry()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Import
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementImport()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Export
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementExport()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Export History
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementExportHistory()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Device Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementDeviceManagement()
        {
            driver.ClickElement(lftNavUtilityManagement, "UtilityManagement");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement User Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementUserManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Roles and Permissions
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementRolesPermissions()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Roles and Permissions");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement Notification
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementNotification()
        {
            driver.ClickElement(btnNotification, "Notification");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Copyright Statement User_Management_Landing_Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CopyrightStatementUserManagementLandingPage()
        {
            driver.ClickElement(btnUserManagement, " User Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(copyright, "Copyright Statement");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Landing Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseLandingPage()
        {
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseDashboard()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Dashboard Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseDashboardDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detail report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Dashboard Top Ten Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseDashboardTopTenDetailReport()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top 10 Consumption Detail report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseCustomerInquiry()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Import
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseImport()
        {
            driver.ClickElement(btnBillingServices, "BillingServices");
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }
        /// <summary>
        /// Method to Validate About Modal Close Export
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseExport()
        {
            driver.ClickElement(lftNavBillingServices, "BillingServices");
            driver.ClickElement(lftNavExportFiles, "Export");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Export History
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseExportHistory()
        {
            driver.ClickElement(lftNavBillingServices, "BillingServices");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Device Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseDeviceManagement()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close User Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseUserManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Roles and Permissions
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseRolesPermissions()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, "Roles Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close Notification
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseNotification()
        {
            driver.ClickElement(btnNotification, "Notification");
            //driver.ClickElement(lftNavRoleManagement, "Roles Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Modal Close User Management from Landing Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ModalCloseUserManagementLandingPage()
        {
            driver.ClickElement(btnUserManagement, "User Management");
            //driver.ClickElement(lftNavRoleManagement, "Roles Management");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(btnCloseModal, "X");
            driver.ClickElement(btnCloseModal, "X");
        }




        /// <summary>
        /// Method to Validate About Neptune 360 Modal Landing_Page
        /// @Author - Gurudas Puthal
        /// </summary>
        public void LandingPageModalNeptune360()
        {
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }
        /// <summary>
        /// Method to Validate About Neptune 360 Modal Dashboard
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboardModalNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Dashboard Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboarDetailReportdModalNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(detailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(detailReport, "Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Modal Dashboard Top Ten Detail Report
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DashboarTopTenDetailReportdModalNeptune360()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(topTenConsumtionDetailReport, TimeSpan.FromSeconds(20));
            driver.ClickElement(topTenConsumtionDetailReport, "Top Ten Detail Report");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }
        /// <summary>
        /// Method to Validate About Neptune 360 Customer Inquiry
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryModalNeptune360()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Import
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportModalNeptune360()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.WaitForElement(btnImport, TimeSpan.FromSeconds(20));
            driver.ClickElement(btnImport, "Import");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }
        /// <summary>
        /// Method to Validate About Neptune 360 Export
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportModalNeptune360()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export Files");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }

        /// <summary>
        /// Method to Validate About Neptune 360 Export History
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryModalNeptune360()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(aboutNeptune360, "About Neptune 360");
            driver.CheckElementDisplayed(modal, "Modal");
            driver.ClickElement(btnCloseModal, "X");
        }




        /// <summary>
        /// Method to Validate Customer Inquiry Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void CustomerInquiryHelpContent()
        {
            driver.ClickElement(btnCustInquiry, "Customer Inquiry");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }
        /// <summary>
        /// Method to Validate Import Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ImportHelpContent()
        {
            driver.ClickElement(btnBillingServices, "Billing Services");
            driver.ClickElement(btnImport, "Import");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHelpContent()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportFiles, "Export");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Export History Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ExportHistoryHelpContent()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavExportHistory, "Export History");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Device Management Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void DeviceManagementHelpContent()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management");
            driver.ClickElement(lftNavDeviceManagement, "Device Management");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(neptune360Help, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Help, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }
        /// <summary>
        /// Method to Validate User Management Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void UserManagementHelpContent()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavUserManagement, "User Management");
            driver.sleepTime(2000);
            driver.ClickElement(righArrow, "Arrow");
            driver.ClickElement(helpContents, "Help Contents");
            driver.switchToNewWindow();
            driver.WaitForElement(contextualHelp, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(contextualHelp, "Neptune® 360™ Help System");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Conitnuous Usage Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ConitnousUsageHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
        
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(60));
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Conitnuous Usage Print Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ConitnousUsagePrintHelp()
        {
            driver.ClickElement(btnDashBoard, "Dashboard");
            driver.WaitForElement(criticalContinuous, TimeSpan.FromSeconds(20));
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Intermittent Usage Help Content
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IntermittentUsageHelpContent()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.sleepTime(5000);
            bool flag = false;
            while (!flag)
            {
                if ((driver.FindElements(By.XPath("//div[not(contains(@title,'Cluster')) and @role='button']")).Count) == 0)
                {
                    flag = false;
                }
                else { flag = true; } //driver.Navigate().Refresh();//driver.sleepTime(8000); }
            }
            //driver.sleepTime(8000);
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Intermittent Count Question Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IntermittentUsageQuestiontArrow()
        {  
            driver.ClickElement(btnDashBoard, "Dahboard");

            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(60));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            driver.ClickElement(righArrow, "Arrow");
            driver.CheckElementDisplayed(helpContents, "Help Contents");
            driver.CheckElementDisplayed(aboutNeptune360, "About Neptune360");
        }

        /// <summary>
        /// Method to Validate Intermittent Count Print Help
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IntermittentUsagePrintHelp()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            //driver.ClickElement(By.XPath("//ul[@class='navigation clearfix']//a[text()='Dashboard']"), "Dashboardlink");
            driver.sleepTime(7000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            driver.IsElementEnabled(btnPrint, "Print Button");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Normal Continuous Consumption Help Access
        /// @Author - Gurudas Puthal
        /// </summary>
        public void NormalContinuousConsumptionHelpAccess()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Normal Continuous Consumption");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Help is opened in new browser");
            driver.switchBackToMainWindow();
        }

        /// <summary>
        /// Method to Validate Warning Continuous Consumption Help Access
        /// @Author - Gurudas Puthal
        /// </summary>
        public void WarningContinuousConsumptionHelpAccess()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Warning Continuous Consumption");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Question Mark");
            driver.switchToNewWindow();
            testReport.Pass("Help is opened in new browser");
            driver.switchBackToMainWindow();
        }


        /// <summary>
        /// Method to Validate Question Mark Intermittent Count
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkIntermittent()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            driver.ClickElement(questionMark, "Questionn (?) Mark");
            driver.switchToNewWindow();
            driver.switchBackToMainWindow();
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Question Mark Intermittent Count
        /// @Author - Gurudas Puthal
        /// </summary>
        public void QuestionMarkVisibleIntermittent()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(questionMark, "Questionn (?) Mark");
        }

        /// <summary>
        /// Method to Validate Intermittent Right Arrow
        /// @Author - Gurudas Puthal
        /// </summary>
        public void IntermittentRightArrow()
        {
            driver.ClickElement(btnDashBoard, "Dahboard");
            driver.WaitForElement(continuousConsumptionRight, TimeSpan.FromSeconds(30));
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(continuousConsumptionRight, "Right Arrow");
            driver.ClickElement(criticalContinuous, "Intermittent Usage");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(righArrow, "Right Arrow");
        }

        /// <summary>
        /// Method to Validate Authentication Device Management
        /// @Author - Gurudas Puthal
        /// </summary>
        public void AuthenticationDeviceManagement()
        {
            driver.Navigate().GoToUrl("http://help.qa.neptune360.com/Content/B_Procedure%20Topics/User%20Management.htm?cshid=1018");
            testReport.Pass("Successfully Navigated to the URL");
        }

    }
}
