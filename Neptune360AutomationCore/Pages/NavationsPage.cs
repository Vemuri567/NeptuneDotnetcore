using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Neptune360UIAutomation
{
    public class NavigationsPage : AbstractTemplatePage
    {

        #region UI Object Repository        
        //private By btnDashBoard = By.XPath("//img[contains(@src,'Dashboard.3D')]");
        private By btnHomePage = By.XPath("//ng-sidebar-container//div/sd-toolbar//i");
        //private By btnCustomerInquiry = By.XPath("//img[contains(@src,'CustomerInquiry.3D')]");
        private By lftCustomerEnquiry = By.XPath("//span[text() = 'CUSTOMER INQUIRY']");
        private By lftNavBillingServices = By.XPath("//span[text()='BILLING SERVICES']");
        private By lftNavImport = By.XPath("//span[text()='IMPORT FILES']");
        private By lftNavExportHistory = By.XPath("//span[text()='EXPORT HISTORY']");
        private By lftNavExport = By.XPath("//span[text()='EXPORT FILES']");
        private By lftNavFileMapper = By.XPath("//span[text()='FILE MAPPER']");
        private By lftNavUtilityManagement = By.XPath("//span[text()='UTILITY MANAGEMENT']");
        private By lftNavPlatformManagement = By.XPath("//img[contains(@src, '/assets/svg/leftnavigation/PlatformManagement.icon.16x16.svg')]");
        private By lftNavUserManagement = By.XPath("//span[text() = 'USER MANAGEMENT']");
        private By lftNavRoleManagement = By.XPath("//span[text() = 'ROLE MANAGEMENT ']");
        private By lftNavNotification = By.XPath("//span[text() = 'EMAIL NOTIFICATION']");
        private By lftUtilityManagement = By.XPath("//span[text() = 'UTILITY MANAGEMENT']");
        private By lftDeviceManagement = By.XPath("//span[text() = 'DEVICE MANAGEMENT']");
        private By lftDashboard = By.XPath("//span[text() = 'DASHBOARD']");
        private By lftNavPartnerManagement = By.XPath("//span[text()='PARTNER MANAGEMENT']");
        private By lftnavApiDeployment = By.XPath("//span[text()='API DEPLOYMENT']");
        private By lftReports=By.XPath("//span[text() = ' REPORTS']");
        private By leftNavUsagePlans = By.XPath("//span[text()='USAGE PLANS']");
        private By letNavSDKAccess = By.XPath("//span[text()='SDK ACCESS']");
        private By lftNavGroups = By.XPath("//span[text()='GROUPS']");
        private By nspDBConversion = By.XPath("//span[text()='NSP DB CONVERSION']");
        private By lftNavSettings = By.XPath("//span[text()='SETTINGS']");

        private By groupManagement = By.XPath("//span[text()='GROUP MANAGEMENT']");
        private By searchEndpoint = By.XPath("//span[text()='SEARCH ENDPOINTS']");
        private By breadCrumb = By.XPath("//ng-sidebar-container//sd-toolbar//span/span");
        private By searchEndpoints = By.XPath("//span[text()='SEARCH ENDPOINTS']");
        #endregion

        /// <summary>
        /// Method to Validate dashboard to homepage
        /// </summary>
        public void ValidateDashboardToHomepage()
        {
            driver.ClickElement(lftDashboard,"Dashboard ");
            driver.ClickElement(btnHomePage, "HomePage ");
            testReport.Pass("<i> Successfully Navigated To <b>Home Page");

        }

        /// <summary>
        /// Method to Validate customer inquiry to home page
        /// </summary>
        public void ValidateCustomerInquiryToHomepage()
        {
            driver.ClickElement(lftCustomerEnquiry, "Customer Inquiry  ");
            driver.ClickElement(btnHomePage, "HomePage ");
            testReport.Pass("<i> Successfully Navigated from Customer Inquiry to Home page. ");

        }

        /// <summary>
        /// Method to Validate import to home page
        /// </summary>
        public void ValidateImportToHomepage()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavImport, "Import ");
            driver.ClickElement(btnHomePage, "HomePage ");
            testReport.Pass("<i> Successfully Navigated from Import page to Home page. ");

        }

        /// <summary>
        /// Method to Validate utility management to home page
        /// </summary>
        public void ValidateUtilityManagementToHomepage()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavImport, "Import ");
            driver.ClickElement(btnHomePage, "HomePage ");
            testReport.Pass("<i> Successfully Navigated from Import page to Home page. ");

        }

        /// <summary>
        /// Method to Validate user management to home page
        /// </summary>
        public void ValidateUserManagementToHomepage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavPartnerManagement, "Partner Management ");
            driver.ClickElement(lftNavUserManagement, "User Management ");
            driver.ClickElement(btnHomePage, "HomePage ");
            testReport.Pass("<i> Successfully Navigated from User Management page to Home page. ");

        }

        /// <summary>
        /// Method to Validate export to home page
        /// </summary>
        public void ValidateExportToHomepage()
        {
            driver.ClickElement(lftNavUtilityManagement, "Utility Management ");            
            driver.ClickElement(btnHomePage, "HomePage ");
            testReport.Pass("<i> Successfully Navigated from Utility Management page to Home page. ");
        }
        /// <summary>
        /// Method to Validate SDK Acces Display
        /// </summary>
        public void ValidateSDKAccessDisplay()
        {
            driver.WaitForElement(letNavSDKAccess, TimeSpan.FromSeconds(20));
            if(driver.CheckElementDisplayed(letNavSDKAccess, "SDK Acces"))
            {
                testReport.Pass("SDK ACCESS option is displayed in the Left Navigation pane");
            }
            else
            {
                ReporterFactory.LogFailure("SDK ACCESS option is not displayed in the Left Navigation pane");
            }
        }

        /// <summary>
        /// Method to Validate SDK Option_Access
        /// </summary>
        public void ValidateSDKOptionAccess()
        {
            driver.WaitForElement(letNavSDKAccess, TimeSpan.FromSeconds(20));
            driver.ClickElement(letNavSDKAccess, "SDK Access");
            if (driver.Title.Contains("SDK Access"))
            {
                testReport.Pass("SDK Access page is displayed");
            }
        }

        /// <summary>
        /// Method to Validate Groups Menu
        /// </summary>
        public void ValidateGroupsMenu()
        {
            driver.WaitForElement(lftNavGroups, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lftNavGroups, "Groups");            
        }

        /// <summary>
        /// Method to Validate Groups Menu Expand
        /// </summary>
        public void ValidateGroupsMenuExpand()
        {
            driver.WaitForElement(lftNavGroups, TimeSpan.FromSeconds(20));
            driver.ClickElement(lftNavGroups, "Groups");
            driver.CheckElementDisplayed(groupManagement, "group Management");
            driver.CheckElementDisplayed(searchEndpoint, "Search Endpoint");
        }

        /// <summary>
        /// Method to Validate Groups Access
        /// </summary>
        public void ValidateGroupsAccess()
        {
            driver.WaitForElement(lftNavGroups, TimeSpan.FromSeconds(20));
            driver.ClickElement(lftNavGroups, "Groups");
            driver.CheckElementDisplayed(groupManagement, "Group Management");
            driver.CheckElementDisplayed(searchEndpoint, "Search Endpoint");
        }

        /// <summary>
        /// Method to Validate NSP DB Conversion
        /// </summary>
        public void ValidateNSPDBConversion()
        {
            driver.WaitForElement(nspDBConversion, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(nspDBConversion, "NSP DB Conversion");
        }

        /// <summary>
        /// Method to Validate NSP DB Conversion Access
        /// </summary>
        public void ValidateNSPDBConversionAccess()
        {
            driver.WaitForElement(nspDBConversion, TimeSpan.FromSeconds(20));
            driver.ClickElement(nspDBConversion, "NSP DB Conversion");
            if (driver.Title.Contains("NSP DB Conversion"))
            {
                testReport.Pass("NSP DB Conversion page is displayed");
            }
        }

        /// <summary>
        /// Method to Validate Settings
        /// </summary>
        public void ValidateSettings()
        {
            driver.WaitForElement(lftNavUtilityManagement, TimeSpan.FromSeconds(20));
            driver.ClickElement(lftNavUtilityManagement, "NSP DB Conversion");
            driver.CheckElementDisplayed(lftNavSettings, "Settings");
        }

        /// <summary>
        /// Method to Validate user management to home page
        /// </summary>
        public void ValidateRolesNPermissionToHomepage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Utility Management ");
            driver.ClickElement(lftNavRoleManagement, "Role Management ");
            driver.ClickElement(btnHomePage, "HomePage ");
            testReport.Pass("<i> Successfully Navigated from Role Management page to Home page. ");

        }

        /// <summary>
        /// Method to Validate notofications to home page
        /// </summary>
        public void ValidateNotificationsToHomepage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(btnHomePage, "HomePage ");
            testReport.Pass("<i> Successfully Navigated from eMAIL Notification page to Home page. ");
        }

        /// <summary>
        /// Method to Validate Left Nav Reports Link
        /// </summary>
        public void ValidateLeftNavReportsLink()
        {
            driver.WaitForElement(lftReports, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(lftReports, "Reports");
        }

        /// <summary>
        /// Method to Validate Left Nav API Deployment 
        /// </summary>
        public void ValidateLeftNavAPIDeployment()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.CheckElementDisplayed(lftnavApiDeployment, "API Deployment");
        }

        /// <summary>
        /// Method to Validate Left Nav API Deployment Access
        /// </summary>
        public void ValidateLeftNavAPIDeploymentAccess()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftnavApiDeployment, "API Deployment");
            if(driver.Title.Contains("API Deployment"))
            {
                testReport.Pass("API DEPLOYMENT page is displayed");
            }
        }

        /// <summary>
        /// Method to Validate Left Nav Partner Management_Displays
        /// </summary>
        public void ValidateLeftNavPartnerManagementDisplay()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.CheckElementDisplayed(lftNavPartnerManagement, "Partner Management");            
        }

        /// <summary>
        /// Method to Validate Left Nav Usage_Plans_Display
        /// </summary>
        public void ValidateLeftNavUsagePlansDisplay()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.CheckElementDisplayed(leftNavUsagePlans, "Usage Plans");
        }

        /// <summary>
        /// Method to Validate Left Nav Usage Access
        /// </summary>
        public void ValidateLeftNavUsageAccess()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(leftNavUsagePlans, "Usage Plans");
            if (driver.Title.Contains("USAGE PLANS"))
            {
                testReport.Pass("File Mapper page is displayed");
            }
        }

        /// <summary>
        /// Method to Validate Left Nav File_Mapper_Display
        /// </summary>
        public void ValidateLeftNavFileMapperDisplay()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.CheckElementDisplayed(lftNavFileMapper, "File Mapper");
        }

        /// <summary>
        /// Method to Validate Left Nav File_Mapper_Access
        /// </summary>
        public void ValidateLeftNavFileMapperAccess()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services");
            driver.ClickElement(lftNavFileMapper, "File Mapper");
            if (driver.Title.Contains("File Mapper"))
            {
                testReport.Pass("File Mapper page is displayed");
            }
        }

        /// <summary>
        /// Method to Validate Left Nav Partner Management_Access
        /// </summary>
        public void ValidateLeftNavPartnerManagementAccess()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavPartnerManagement, "Partner Management");
            if (driver.Title.Contains("Partner Management"))
            {
                testReport.Pass("Partner Management page is displayed");
            }
        }

        /// <summary>
        /// Method to Validate Left Nav Reports Link
        /// </summary>
        public void ValidateLeftNavReportsScreenDisplay()
        {
            driver.ClickElement(lftReports, "Reports");
            if (driver.Title.Contains("Reports"))
            {
                testReport.Pass("<i> Verbiage of Import Screen title is : " + driver.Title);
            }
            else
            {
                ReporterFactory.LogFailure("Title not present. ");
            }
        }

        /// <summary>
        /// Method to Validate notofications to utility management page
        /// </summary>
        public void ValidateNotificationsToUtility()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(lftUtilityManagement, "Utility Management ");
            driver.ClickElement(lftDeviceManagement, "Device Management ");
            
            testReport.Pass("<i> Successfully Navigated from Notifications Page to Utility Management. ");

        }

        /// <summary>
        /// Method to Validate notofications to import page
        /// </summary>
        public void ValidateNotificationsToImportPage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavImport, "Ïmport Page");

            testReport.Pass("<i> Successfully Navigated from Notifications Page to Import Page. ");

        }

        /// <summary>
        /// Method to Validate notofications to export page
        /// </summary>
        public void ValidateNotificationsToExportPage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavExport, "Export Page");

            testReport.Pass("<i> Successfully Navigated from Notifications Page to Export Page. ");

        }

        /// <summary>
        /// Method to Validate notofications to customer enquiry page
        /// </summary>
        public void ValidateNotificationsToCustEnq()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(lftCustomerEnquiry, "Customer Enquiry  ");
            testReport.Pass("<i> Successfully Navigated from Notifications Page to Customer Enquiry Page. ");

        }

        /// <summary>
        /// Method to Validate notofications to customer enquiry page
        /// </summary>
        public void ValidateNotificationsToDashboard()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(lftDashboard, "Dashboard ");
            testReport.Pass("<i> Successfully Navigated from Notifications Page to Dashboard Page. ");

        }
        /// <summary>
        /// Method to Validate import files menu in left navi panel
        /// </summary>
        public void ValidateImportFilesMenu()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            if (driver.CheckElementDisplayed(lftNavImport, "Import Files "))
            {
                testReport.Pass("<i> Import Files menu is on left navigation panel of Billing Services. ");
            }
            else
            {
                ReporterFactory.LogFailure("Import Files menu is not present on left navigation panel of Billing Services.");
            }

        }

        /// <summary>
        /// Method to Validate bread crumb import file menu
        /// </summary>
        public void ValidateBreadcrumbImportFileMenu()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavImport, "Import Files ");
            if (driver.CheckElementDisplayed(breadCrumb, "Breadcrumb Import File"))
            {
                testReport.Pass("<i> Import Files breadcrumb menu is displayed on the screen. ");
            }
            else
            {
                ReporterFactory.LogFailure("Import Files breadcrumb menu is not displayed on the screen. ");
            }

        }

        /// <summary>
        /// Method to Validate verbiage of page title
        /// </summary>
        public void ValidateVerbiageOfPageTitle()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavImport, "Import Files ");
            if (driver.Title.Contains("Import Files"))
            {
                testReport.Pass("<i> Verbiage of Import Screen title is : " + driver.Title);
            }
            else
            {
                ReporterFactory.LogFailure("Title not present. ");
            }

        }

        /// <summary>
        /// Method to Validate verbiage of page title
        /// </summary>
        public void ValidateVerbiageExportFiles()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.CheckElementDisplayed(lftNavExport, "EXPORT FILES");
            if (driver.GetElementText(lftNavExport).Contains("EXPORT FILES"))
            {
                testReport.Pass("<i> Verbiage of Export File is : " + driver.GetElementText(lftNavExport));
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. "+ driver.GetElementText(lftNavExport));
            }

        }

        /// <summary>
        /// Method to Validate verbiage of page title
        /// </summary>
        public void ValidateExportFilesBreadcrumb()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavExport, "EXPORT FILES");
            if (driver.GetElementText(breadCrumb).Contains("EXPORT FILES"))
            {
                testReport.Pass("<i> Breadcrumb of Export File is : " + driver.GetElementText(lftNavExport));
            }
            else
            {
                ReporterFactory.LogFailure("Breadcrumb is wrong. " + driver.GetElementText(lftNavExport));
            }

        }

        /// <summary>
        /// Method to Validate verbiage of page title
        /// </summary>
        public void ValidateExportFilesTitleVerbiage()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavExport, "EXPORT FILES");
            if (driver.Title.Contains("Export Files"))
            {
                testReport.Pass("<i> Title Verbiage is : "+driver.Title);
            }
            else
            {
                ReporterFactory.LogFailure("Title is wrong. " + driver.Title);
            }

        }

        /// <summary>
        /// Method to Validate export history verbiage
        /// </summary>
        public void ValidateExportHistoryVerbiage()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.CheckElementDisplayed(lftNavExportHistory, "EXPORT HISTORY");
            if (driver.GetElementText(lftNavExportHistory).Contains("EXPORT HISTORY"))
            {
                testReport.Pass("<i> EXPORT HISTORY Verbiage is : " + driver.GetElementText(lftNavExportHistory));
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.GetElementText(lftNavExportHistory));
            }

        }

        /// <summary>
        /// Method to Validate export history breadcrumb verbiage
        /// </summary>
        public void ValidateExportHistoryBreadcrumb()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavExportHistory, "EXPORT HISTORY");
            if(driver.GetElementText(breadCrumb).Equals("EXPORT HISTORY"))
            {
                testReport.Pass("<i> Breadcrumb Verbiage is : " + driver.GetElementText(breadCrumb));
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.GetElementText(breadCrumb));
            }

        }

        /// <summary>
        /// Method to Validate export history page title verbiage
        /// </summary>
        public void ValidateExportHistoryPageTitleVerbiage()
        {
            driver.ClickElement(lftNavBillingServices, "Billing Services ");
            driver.ClickElement(lftNavExportHistory, "EXPORT HISTORY");
            if (driver.Title.Contains("Export History"))
            {
                testReport.Pass("<i> Title Verbiage is : " + driver.Title);
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.Title);
            }
        }

        /// <summary>
        /// Method to Validate role management verbiage
        /// </summary>
        public void ValidateRoleManagementVerbiage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Managment");
            driver.CheckElementDisplayed(lftNavRoleManagement, "Role Management");
            if (driver.GetElementText(lftNavRoleManagement).Contains("ROLE MANAGEMENT"))
            {
                testReport.Pass("<i> Verbiage is : " + driver.GetElementText(lftNavRoleManagement));
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.GetElementText(lftNavRoleManagement));
            }
        }

        /// <summary>
        /// Method to Validate role management breadcrumb verbiage
        /// </summary>
        public void ValidateRoleManagementBreadcrumbVerbiage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Managment");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.CheckElementDisplayed(breadCrumb, "Role Management");
            if (driver.GetElementText(breadCrumb).Contains("ROLE MANAGEMENT"))
            {
                testReport.Pass("<i> Verbiage is : " + driver.GetElementText(breadCrumb));
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.GetElementText(breadCrumb));
            }
        }

        /// <summary>
        /// Method to Validate role management breadcrumb verbiage
        /// </summary>
        public void ValidateRoleManagementPageTitleVerbiage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Managment");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            if (driver.Title.Contains("Role Management"))
            {
                testReport.Pass("<i> Verbiage is : " + driver.GetElementText(lftNavRoleManagement));
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.GetElementText(lftNavRoleManagement));
            }
        }


        /// <summary>
        /// Method to Validate email notification verbiage
        /// </summary>
        public void ValidateEmailNotificationVerbiage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Managment");
            driver.CheckElementDisplayed(lftNavNotification,"EMAIL NOTIFICATION ");
            if (driver.GetElementText(lftNavNotification).Contains("EMAIL NOTIFICATION"))
            {
                testReport.Pass("<i> Verbiage is : " + driver.GetElementText(lftNavNotification));
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.GetElementText(lftNavNotification));
            }
        }

        /// <summary>
        /// Method to Validate email notification breadcrumb verbiage
        /// </summary>
        public void ValidateEmailNotificationBreadcrumbVerbiage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Managment");
            driver.ClickElement(lftNavNotification, "EMAIL NOTIFICATION ");
            if (driver.GetElementText(breadCrumb).Contains("EMAIL NOTIFICATION"))
            {
                testReport.Pass("<i> Verbiage is : " + driver.GetElementText(breadCrumb));
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.GetElementText(breadCrumb));
            }
        }
        /// <summary>
        /// Method to Validate email notification title verbiage
        /// </summary>
        public void ValidateEmailNotificationPageTitleVerbiage()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Managment");
            driver.ClickElement(lftNavNotification, "EMAIL NOTIFICATION ");
            if (driver.Title.Contains("Email Notification"))
            {
                testReport.Pass("<i> Verbiage is : " + driver.Title);
            }
            else
            {
                ReporterFactory.LogFailure("Verbiage is wrong. " + driver.Title);
            }
        }
        /// <summary>
        /// Method to Validate homepage Link
        /// </summary>
        public void ValidateHomePageLink()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Managment");
            driver.ClickElement(lftNavUserManagement, "User Management ");
            driver.ClickElement(btnHomePage, "Home Page ");
            if (driver.Title.Contains("Neptune 360"))
            {
                testReport.Pass("<i> Navigated to Home Page");
            }
            else
            {
                ReporterFactory.LogFailure("Not Navigated to Home Page" + driver.Title);
            }
        }

        /// <summary>
        /// Method to Validate notofications to user management page
        /// </summary>
        public void ValidateNotificationsToUserManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(lftNavUserManagement, "User Management ");

            testReport.Pass("<i> Successfully Navigated from Notifications Page to Import Page. ");

        }

        /// <summary>
        /// Method to Validate notofications to role management page
        /// </summary>
        public void ValidateNotificationsToRoleManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(lftNavRoleManagement, "Role Management ");

            testReport.Pass("<i> Successfully Navigated from Notifications Page to Role Management. ");

        }
        /// <summary>
        /// Method to Validate notofications to import page
        /// </summary>
        public void ValidateNotificationsToImportScree()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavNotification, "eMAIL Notification ");
            driver.ClickElement(lftNavRoleManagement, "Role Management ");

            testReport.Pass("<i> Successfully Navigated from Notifications Page to Role Management. ");

        }

    }
}
