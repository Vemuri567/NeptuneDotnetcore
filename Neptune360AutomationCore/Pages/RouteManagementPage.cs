using OpenQA.Selenium;
using System;

namespace Neptune360UIAutomation
{
    public class RouteManagementPage : AbstractTemplatePage
    {
        #region UI Object Repository  
        private By btnHomePage = By.XPath("//ng-sidebar-container//div/sd-toolbar//i");
        private By lftNavExportHistory = By.XPath("//span[text()='EXPORT HISTORY']");
        private By lftNavExport = By.XPath("//span[text()='EXPORT FILES']");
        private By lftNavUtilityManagement = By.XPath("//span[text()='UTILITY MANAGEMENT']");
        private By lftNavPlatformManagement = By.XPath("//img[contains(@src, '/assets/svg/leftnavigation/PlatformManagement.icon.16x16.svg')]");
        private By lftNavUserManagement = By.XPath("//span[text() = 'USER MANAGEMENT']");
        private By lftNavRoleManagement = By.XPath("//span[text() = 'ROLE MANAGEMENT ']");
        private By lftNavNotification = By.XPath("//span[text() = 'EMAIL NOTIFICATION']");
        private By lftUtilityManagement = By.XPath("//span[text() = 'UTILITY MANAGEMENT']");
        private By lftDeviceManagement = By.XPath("//span[text() = 'DEVICE MANAGEMENT']");
        private By lftDashboard = By.XPath("//span[text() = 'DASHBOARD']");
        private By totalReadingsWidget = By.CssSelector(".col-md-4:nth-child(3) g:nth-child(4) text:nth-child(1)");
        private By totalreadingsGraph = By.CssSelector(".col-md-4:nth-child(3) svg");
        private By lftRouteManagement = By.XPath("//span[text()='ROUTE MANAGEMENT']");
        private By btnRouteManagement = By.XPath("//img[contains(@src,'RouteManagement.icon.svg')]");
        private By lftRouteAssignment = By.XPath("//span[text()='ROUTE ASSIGNMENTS']");
        private By breadCrumb = By.XPath("//ng-sidebar-container//sd-toolbar//span/span");
        private By neptuneCustService = By.XPath("//span[text() = 'Neptune Customer Service Rep']");
        private By routeManagementDrpDwn = By.XPath("//span[text() = 'Route Management']");
        private By exportManagementDrpDwn = By.XPath("//span[text() = 'Export Management']");
        private By editAssignments = By.XPath("//span[text() = 'Edit Assignments']");
        private By neptuneSysAdmin = By.XPath("//span[text() = 'Neptune System Administrator']");
        private By btnEdit = By.XPath("//div[2]/button");
        private By btnEdit1 = By.XPath("//div[1]/button");
        private By btnViewRouteManagement = By.XPath("//span[text()='View Route Management Dashboard']/..//kendo-switch[@formcontrolname='claimStatus']");
        private By btnViewAssignments = By.XPath("//span[text()='Edit Assignments']/..//kendo-switch[@formcontrolname='claimStatus']");
        private By viewDropDown = By.XPath("//ntg-card//div[2]/div[1]//kendo-dropdownlist//span/span");
        private By dropDownValue = By.XPath("//kendo-dropdownlist");
        private By assignedRecords = By.CssSelector(".assignmentgrideditmodeff:nth-child(1) > td:nth-child(3)");
        private By btnAction = By.XPath("//div/div/kendo-dropdownbutton/button");
        private By popupAction = By.XPath("//kendo-button-list/ul");
        private By assignReader = By.XPath("//li[contains(.,'Assign Reader')]");
        private By unassignReader = By.XPath("//li[contains(.,'Unassign Reader')]");
        private By readers = By.XPath("//span[contains(.,'Readers')]");
        private By readersRow = By.Id("usersGrid");
        private By readerList(string readerName) => By.XPath("//tr[contains(@class,'readergrideditmodeoff')]//td[contains(text(),'"+readerName+"')]");
        private By viewAllRoutes = By.XPath("//kendo-grid-list/div");
        private By firstColumn = By.XPath("//tbody/tr/td[1]");
        private By secondColumn = By.XPath("//tbody/tr/td[2]");
        private By thirdColumn = By.XPath("//tbody/tr/td[3]");
        private By forthColumn = By.XPath("//tbody/tr/td[4]");
        private By fifthColumn = By.XPath("//tbody/tr/td[5]");
        private By readersName = By.XPath("//tbody/tr[2]/td");
        private By viewRouteManagement = By.XPath("//span[text()='View Route Management Dashboard']");
        private By totalIncomplete = By.XPath("//div[@id='gridRouteAssignment']/kendo-grid/div/kendo-grid-list/div/div/table/tbody/tr/td[3]");

        private By editRoute = By.XPath("//button[contains(.,'Edit')]");
        private By checkBox = By.XPath("//input[@type='checkbox']");
        private By selectReader = By.XPath("//sd-routemanagement/div/div[3]/div[1]/ntg-card/div/div[1]/div[1]//span/kendo-dropdownlist/span/span");
        private By btnSave = By.XPath("//button[contains(.,'Save')]");
        private By btnCancel = By.XPath("//button[contains(.,'Cancel')]");
        private By discardAllChanges = By.XPath("//div[text()='Discard all changes?']");
        private By btnYes = By.XPath("//button[contains(.,'Yes')]");
        private By btnNo = By.XPath("//button[contains(.,'No')]");

        private By selectAllFrmdropdown = By.XPath("//li[contains(.,'All')]");
        private By selectUnassignedFrmdropdown = By.XPath("//li[contains(.,'Unassigned')]");
        private By selectassignedFrmdropdown = By.XPath("//li[contains(.,'Assigned')]");
        private By selectLoadedFrmdropdown = By.XPath("//li[contains(.,'Loaded')]");
        private By selectUnloadedFrmdropdown = By.XPath("//li[contains(.,'Unloaded')]");

        private By filterButton = By.XPath("//th[4]/kendo-grid-filter-menu/a/span");
        private By filterButton_reader = By.XPath("//th[7]/kendo-grid-filter-menu/a/span");
        private By filterSearchBar = By.XPath("//kendo-searchbar/input");

        private By selectFilter = By.XPath("//button[contains(.,'Filter')]");
        private By selectClear = By.XPath("//button[contains(.,'Clear')]");

        private By routeFilter = By.XPath("//th[1]/kendo-grid-filter-menu/a/span");
        #endregion

        /// <summary>
        /// Method to Validate Export Management Route Management
        /// </summary>
        public void ValidateExportManagementRouteManagement()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            testReport.Info("<i> Successfully Navigated To <b>Role Management Page");
            driver.ClickElement(neptuneCustService, "Neptune Customer Service Rep ");
            driver.CheckElementDisplayed(routeManagementDrpDwn, "Route Mangement Dropdown");
            if (driver.CheckElementDisplayed(exportManagementDrpDwn, "Export Management Dropdown"))
            {
                testReport.Pass("<i>Export Management is Available.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Export Management is Not Available.");
            }
        }

        /// <summary>
        /// Method to Validate Edit Assignments Feature
        /// </summary>
        public void ValidateEditAssignmentFeature()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            testReport.Info("<i> Successfully Navigated To <b>Role Management Page");
            driver.ClickElement(neptuneSysAdmin, "Neptune System Admin ");
            driver.CheckElementDisplayed(routeManagementDrpDwn, "Route Mangement Dropdown");
            if (driver.CheckElementDisplayed(editAssignments, "Edit Assigments "))
            {
                testReport.Pass("<i>Edit Assigments is Available.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Edit Assigments is Not Available.");
            }
        }

        /// <summary>
        /// Method to Validate Basic Permissions
        /// </summary>
        public void ValidateBasicPermissions()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            testReport.Info("<i> Successfully Navigated To <b>Role Management Page");
            driver.ClickElement(neptuneSysAdmin, "Neptune System Admin ");
            if (driver.CheckElementDisplayed(routeManagementDrpDwn, "Route Mangement Dropdown"))
            {
                testReport.Pass("<i>Dropdown is displayed. ");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Dropdown is Not displayed. ");
            }

        }

        /// <summary>
        /// Method to Validate Route Management Feature Editable
        /// </summary>
        public void ValidateRouteManagementFeatureEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            testReport.Info("<i> Successfully Navigated To <b>Role Management Page");
            driver.ClickElement(neptuneSysAdmin, "Neptune System Admin ");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnViewRouteManagement, "Edit Button");
            testReport.Pass("<i>View Route Management Dashboard is Editbale ");

        }

        /// <summary>
        /// Method to Validate edit Assignments Editable
        /// </summary>
        public void ValidateEditAssignmentsEditable()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management ");
            driver.ClickElement(lftNavRoleManagement, "Role Management");
            driver.sleepTime(5000);
            testReport.Info("<i> Successfully Navigated To <b>Role Management Page");
            driver.ClickElement(neptuneSysAdmin, "Neptune System Admin ");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(btnViewAssignments, "View Assignments Edit Button");
            testReport.Pass("<i>View Assignments is Editbale ");

        }

        /// <summary>
        /// Method to Validate Route Management Display
        /// </summary>
        public void ValidateRouteManagementDisplay()
        {
            driver.WaitForElement(lftRouteManagement, TimeSpan.FromSeconds(10));
            if (driver.CheckElementDisplayed(lftRouteManagement, "Route Management"))
                testReport.Pass("<i>Route Management Navigateion is Displayed.");
            else
            {
                ReporterFactory.LogFailure("Route Management Navigateion is Not Displayed.");
            }
        }

        /// <summary>
        /// Method to Validate Route Management Collapse
        /// </summary>
        public void ValidateRouteManagementCollapse()
        {
            driver.ClickElement(lftRouteManagement, "Route Management");
            driver.CheckElementDisplayed(lftRouteAssignment, "Route Assignment");
            driver.ClickElement(lftRouteManagement, "Route Management");
            testReport.Pass("<i>Route Management is Collapsed.");
        }

        /// <summary>
        /// Method to Validate Route  Assignmens Page
        /// </summary>
        public void ValidateRouteAssignmentsPage()
        {
            driver.ClickElement(lftRouteManagement, "Route Management");
            driver.ClickElement(lftRouteAssignment, "Route Assignment");
            driver.WaitForElement(breadCrumb, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(breadCrumb, "Route  Assignmens Page");
        }

        /// <summary>
        /// Method to Validate Route Management Widget
        /// </summary>
        public void ValidateRouteManagementWidget()
        {
            if (driver.CheckElementDisplayed(btnRouteManagement, "Route Management Widget"))
                testReport.Pass("<i>Route Management widget is displayed.");
            else
                ReporterFactory.LogFailure("<i>Route Management widget is not displayed.");
        }
        /// <summary>
        /// Method to Validate Route Management Click
        /// </summary>
        public void ValidateRouteManagementClick()
        {
            driver.ClickElement(btnRouteManagement, "Route Management Widget");
            testReport.Pass("<i>Route Management widget is clicked.");
        }
        /// <summary>
        /// Method to Validate Total Readings Display
        /// </summary>
        public void ValidateTotalReading()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(totalReadingsWidget, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(totalReadingsWidget, "Total Readings");
            driver.sleepTime(4000);
            driver.CheckElementDisplayed(totalReadingsWidget, "Total Readings");
            testReport.Pass("<i>Total Readings is displayed.");
        }

        /// <summary>
        /// Method to Validate Total Readings Display graph
        /// </summary>
        public void ValidateTotalReadingGraph()
        {
            driver.ClickElement(btnRouteManagement, "Route Management Widget");
            driver.CheckElementDisplayed(totalReadingsWidget, "Total Readings");
            driver.sleepTime(4000);
            driver.CheckElementDisplayed(totalReadingsWidget, "Total Readings");
            testReport.Pass("<i>Total Readings is displayed at the right top.");
        }

        /// <summary>
        /// Method to Validate Total Readings Display to Right
        /// </summary>
        public void ValidateTotalReadingRight()
        {
            driver.ClickElement(btnRouteManagement, "Route Management Widget");
            driver.CheckElementDisplayed(totalReadingsWidget, "Total Readings");
            driver.sleepTime(4000);
            driver.CheckElementDisplayed(totalReadingsWidget, "Total Readings");
            testReport.Pass("<i>Total Readings is displayed at the right top.");
        }

        /// <summary>
        /// Method to Validate Route ManagementSub MenuDisplay
        /// </summary>
        public void ValidateRouteManagementSubMenuDisplay()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(totalreadingsGraph, System.TimeSpan.FromMinutes(2));
            if (driver.CheckElementDisplayed(totalreadingsGraph, "Total Readings Graph"))
                testReport.Pass("<i>Total Readings Graph is Displayed.");
            else
                ReporterFactory.LogFailure("<i>Total Readings Graph is Not Displayed.");
        }

        /// <summary>
        /// Method to Validate View Assigned
        /// </summary>
        public void ValidateViewAssigned()
        {
            try
            {
                driver.ClickElement(btnRouteManagement, "Route Management");
                driver.WaitForElement(viewDropDown, TimeSpan.FromSeconds(10));
                driver.FindElement(viewDropDown).Click();
                driver.sleepTime(2000);
                driver.FindElement(By.XPath("//li[contains(@id,'Assigned')]")).Click();
                driver.sleepTime(2000);
                driver.WaitForElement(assignedRecords, System.TimeSpan.FromSeconds(10));
                if (driver.CheckElementDisplayed(assignedRecords, "Assigned Records"))
                {
                    testReport.Pass("<i>Records found for Assigned Readers");
                }
                else
                {
                    testReport.Pass("<i>No Records Available. ");
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Method to Validate View Unassigned
        /// </summary>
        public void ValidateViewUnassigned()
        {
            try
            {
                driver.ClickElement(btnRouteManagement, "Route Management");
                driver.FindElement(viewDropDown).Click();
                driver.sleepTime(2000);
                driver.FindElement(By.XPath("//li[contains(@id,'Unassigned')]")).Click();
                if (driver.CheckElementDisplayed(assignedRecords, "Unassigned "))
                    testReport.Pass("<i>Unassigned Records displayed is : <mark> " + driver.GetElementText(assignedRecords));
                else
                    ReporterFactory.LogFailure("<i>Unassigned Records not displayed.");
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Method to Validate Edit Button
        /// </summary>
        public void ValidateEditButton()
        {
            try
            {
                driver.ClickElement(btnRouteManagement, "Route Management");
                if (driver.CheckElementDisplayed(btnEdit1, "Edit Button "))
                    testReport.Pass("<i>Edit Button is displayed. ");
                else
                    ReporterFactory.LogFailure("<i>Edit Button not displayed.");
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Method to Validate Edit Button Click
        /// </summary>
        public void ValidateEditButtonClick()
        {
            try
            {
                driver.ClickElement(btnRouteManagement, "Route Management");
                driver.ClickElement(btnEdit1, "Edit Button");
                driver.sleepTime(3000);
                if (driver.CheckElementDisplayed(btnEdit1, "Edit Button "))
                    testReport.Pass("<i>Edit Button is clickable. ");
                else
                    ReporterFactory.LogFailure("<i>Edit Button not clickable.");
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Method to Validate Edit Button Replaced
        /// </summary>
        public void ValidateEditButtonReplaced()
        {
            try
            {
                driver.ClickElement(btnRouteManagement, "Route Management");
                driver.ClickElement(btnEdit1, "Edit Button");
                driver.sleepTime(3000);
                if (driver.CheckElementDisplayed(btnAction, "Action Button "))
                    testReport.Pass("<i>Action Button is available. ");
                else
                    ReporterFactory.LogFailure("<i>Action Button not available.");
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Method to Validate Action Button Enabled
        /// </summary>
        public void ValidateActionButtonEnabled()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(3000);
            driver.ClickElement(btnEdit1, "Edit Button");
            driver.sleepTime(3000);
            driver.ClickElement(btnAction, "Action Button ");
            driver.sleepTime(3000);
            if (driver.CheckElementDisplayed(popupAction, "Popup"))
                testReport.Pass("<i>Action Button is Enabled. ");
            else
                ReporterFactory.LogFailure("<i>Action Button not Enabled.");

        }

        /// <summary>
        /// Method to Validate Cancel Button 
        /// </summary>
        public void ValidateCancelButton()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit1, "Edit Button");
            driver.sleepTime(3000);
            if (driver.CheckElementDisplayed(btnEdit1, "Cancel"))
                testReport.Pass("<i>Cancel Button is available. ");
            else
                ReporterFactory.LogFailure("<i>Cancel Button not available.");

        }

        /// <summary>
        /// Method to Validate Cancel Button Enabled
        /// </summary>
        public void ValidateCancelButtonEnabled()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit1, "Edit Button");
            driver.sleepTime(3000);
            driver.ClickElement(btnEdit1, "Cancel");
            driver.sleepTime(3000);
            if (driver.CheckElementDisplayed(btnEdit1, "Edit Button"))
                testReport.Pass("<i>Cancel Button is Enabled. ");
            else
                ReporterFactory.LogFailure("<i>Cancel Button not Enabled.");
        }
        /// <summary>
        /// Method to Validate Assign Routes
        /// </summary>
        public void ValidateAssignRoutes()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit1, "Edit Button");
            driver.sleepTime(3000);
            driver.ClickElement(btnAction, "Action Button");
            driver.WaitForElement(assignReader, TimeSpan.FromSeconds(3000));
            if (driver.CheckElementDisplayed(assignReader, "Assign Routes Button"))
                testReport.Pass("<i>Assign Reader is Displayed. ");
            else
                ReporterFactory.LogFailure("<i>Assign Reader is not Displayed");
        }

        /// <summary>
        /// Method to Validate Unassign Routes
        /// </summary>
        public void ValidateUnassignRoutes()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit1, "Edit Button");
            driver.sleepTime(3000);
            driver.ClickElement(btnAction, "Action Button");
            driver.WaitForElement(unassignReader, TimeSpan.FromSeconds(3000));
            if (driver.CheckElementDisplayed(unassignReader, "Unassign Routes Button"))
                testReport.Pass("<i>Unassign Reader is Displayed. ");
            else
                ReporterFactory.LogFailure("<i>Unassign Reader is not Displayed");
        }
        /// <summary>
        /// Method to Validate Readers
        /// </summary>
        public void ValidateReaders()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Button Readers");
            driver.sleepTime(2000);
            driver.ClickElement(btnEdit1, "Edit Button");
            driver.sleepTime(3000);

            if (driver.CheckElementDisplayed(readersRow, "Readers"))
                testReport.Pass("<i>Reader is Displayed. ");
            else
                ReporterFactory.LogFailure("<i>Reader is not Displayed");
        }

        /// <summary>
        /// Method to Validate Readers Button
        /// </summary>
        public void ValidateReadersButton()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            if (driver.CheckElementDisplayed(readers, "Readers"))
                testReport.Pass("<i>Readers Button is Displayed. ");
            else
                ReporterFactory.LogFailure("<i>Readers Button is not Displayed");
        }
        /// <summary>
        /// Method to Validate View All
        /// </summary>
        public void ValidateViewAll()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.FindElement(viewDropDown).Click();
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(viewAllRoutes, "Assigned Records"))
            {
                testReport.Pass("<i>Records found for all.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>No Records found for Assigned Readers. ");
            }
        }
        /// <summary>
        /// Method to Validate View exported
        /// </summary>
        public void ValidateViewExported()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.FindElement(viewDropDown).Click();
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(viewAllRoutes, "Assigned Records"))
            {
                testReport.Pass("<i>Exported Records displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Exported Records not displayed. ");
            }
        }
        /// <summary>
        /// Method to Validate View imported and exported
        /// </summary>
        public void ValidateViewImportednExported()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.FindElement(viewDropDown).Click();
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(viewAllRoutes, "Assigned Records"))
            {
                testReport.Pass("<i>Impotred and Exported Records displayed.");
            }
            else
            {
                ReporterFactory.LogFailure("<i>Impotred and Exported Records not displayed. ");
            }
        }

        /// <summary>
        /// Method to Validate assigned names
        /// </summary>
        public void ValidateAssignedNames()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Readers Button");
            if (driver.CheckElementDisplayed(readersRow, "Readers names"))
                testReport.Pass("<i>Readers name are Displayed as per the format. ");
            else
                ReporterFactory.LogFailure("<i>Readers name are not Displayed as per the format. ");
        }
        /// <summary>
        /// Method to Validate Column Heading
        /// </summary>
        public void ValidateCoumumnHeading()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(firstColumn, "Heading"))
                testReport.Pass("<i>Heading for first coloumn is : <mark><b> " + driver.GetElementText(firstColumn));
            else
                ReporterFactory.LogFailure("<i>Heading for first coloumn is not Displayed as per the format. ");
        }
        /// <summary>
        /// Method to Validate Route Value
        /// </summary>
        public void ValidateRouteValue()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(viewAllRoutes, "Heading"))
                testReport.Pass("<i>Route Heading Value is : <mark><b> " + driver.GetElementText(viewAllRoutes));
            else
                ReporterFactory.LogFailure("<i>Route Value is not Displayed as per the format. ");
        }

        /// <summary>
        /// Method to Validate Secound Column
        /// </summary>
        public void ValidateSecoundColumn()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(secondColumn, "Secound Column"))
                testReport.Pass("<i>Route Value is : <mark><b> " + driver.GetElementText(secondColumn));
            else
                ReporterFactory.LogFailure("<i>Route Value is not Displayed as per the format. ");
        }
        /// <summary>
        /// Method to Validate Total Routes
        /// </summary>
        public void ValidateTotalRoutes()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(secondColumn, "Total Routes"))
                testReport.Pass("<i>Total route for second is : <mark><b> " + driver.GetElementText(secondColumn));
            else
                ReporterFactory.LogFailure("<i>Total route Value is not Displayed as per the format. ");
        }
        /// <summary>
        /// Method to Validate Total Routes third column
        /// </summary>
        public void ValidateTotalRoutesThirdCol()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(thirdColumn, "Third Column"))
                testReport.Pass("<i>Total route value is : <mark><b> " + driver.GetElementText(thirdColumn));
            else
                ReporterFactory.LogFailure("<i>Total route Value is not Displayed as per the format. ");
        }

        /// <summary>
        /// Method to Validate Total Routes forth column
        /// </summary>
        public void ValidateTotalRoutesForthCol()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(forthColumn, "Forth Column Routes"))
                testReport.Pass("<i>Total route value is : <mark><b> " + driver.GetElementText(forthColumn));
            else
                ReporterFactory.LogFailure("<i>Total route Value is not Displayed as per the format. ");
        }

        /// <summary>
        /// Method to Validate Reader Value
        /// </summary>
        public void ValidateReaderValue()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(forthColumn, "Reader Value"))
                testReport.Pass("<i>Reader Value is : <mark><b> " + driver.GetElementText(forthColumn));
            else
                ReporterFactory.LogFailure("<i>Reader Value is not Displayed as per the format. ");
        }

        /// <summary>
        /// Method to Validate Fifth Column
        /// </summary>
        public void ValidateFifthColumn()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(fifthColumn, "Fifth Column Value"))
                testReport.Pass("<i>Fifth Column Value is : <mark><b> " + driver.GetElementText(fifthColumn));
            else
                ReporterFactory.LogFailure("<i>Fifth Column Value is not Displayed as per the format. ");
        }
        /// <summary>
        /// Method to Validate Status Value
        /// </summary>
        public void ValidateStatusValue()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(fifthColumn, "Status Value"))
                testReport.Pass("<i>Status Value is : <mark><b> " + driver.GetElementText(fifthColumn));
            else
                ReporterFactory.LogFailure("<i>Status Value is not Displayed as per the format. ");
        }
        /// <summary>
        /// Method to Validate Unassigned Value
        /// </summary>
        public void ValidateUnassignedDefault()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.CheckElementDisplayed(dropDownValue, "Drop down");
            if (driver.GetElementText(dropDownValue).Equals("Unassigned"))
            {
                testReport.Pass("<i>Deafault value is Unassigned");
            }
            else
            {
                ReporterFactory.LogFailure("Default value is not unassigned" + driver.GetElementText(viewDropDown));
            }
        }
        /// <summary>
        /// Method to Validate Readers Button
        /// </summary>
        public void ValidateReadersBtn()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Readers Button");
            if (driver.CheckElementDisplayed(readersRow, "Readers row"))
            {
                testReport.Pass("<i>Readers segment is displayed");
            }
            else
            {
                ReporterFactory.LogFailure("Readers segment is not displayed");
            }
        }
        /// <summary>
        /// Method to Validate Readers Name
        /// </summary>
        public void ValidateReadersName()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Readers Button");
            driver.CheckElementDisplayed(readersRow, "Readers row");
            if (driver.CheckElementDisplayed(readersName, "Readers Name"))
            {
                testReport.Pass("<i>Readers name is displayed as : " + driver.GetElementText(readersName));
            }
            else
            {
                ReporterFactory.LogFailure("Readers name is not displayed");
            }
        }
        public void ValidateReadersNameNotDisplayed(string readerName)
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Readers Button");
            driver.CheckElementDisplayed(readersRow, "Readers row");
            driver.CheckElementDoesnotExists(readerList(readerName), "Readers Name");
        }
        /// <summary>
        /// Method to Validate Readers Assigned Number
        /// </summary>
        public void ValidateReadersAssignedNo()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Readers Button");
            //driver.CheckElementDisplayed(readersRow, "Readers row");
            if (driver.CheckElementDisplayed(readersName, "Readers Name"))
            {
                testReport.Pass("<i>Readers name is displayed as : " + driver.GetElementText(readersName));

            }
            else
            {
                ReporterFactory.LogFailure("Readers name is not displayed");
            }
        }

        /// <summary>
        /// Method to Validate Readers Segment Hides
        /// </summary>
        public void ValidateReadersSegmentHides()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Readers Button");
            driver.ClickElement(readers, "Readers Button");
            testReport.Pass("<i>Readers segment is hidden. ");
        }

        /// <summary>
        /// Method to Validate Readers button open
        /// </summary>
        public void ValidateReadersButtonOpen()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Readers Button");
            if (driver.CheckElementDisplayed(readers, "Readers Button"))
                testReport.Pass("<i>Readers button is in Open state. ");
            else
                ReporterFactory.LogFailure("<i>Readers button is Not in Open state. ");
        }
        /// <summary>
        /// Method to Validate Readers button closed
        /// </summary>
        public void ValidateReadersButtonClosed()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(readers, "Readers Button");
            if (driver.CheckElementDisplayed(readers, "Readers Button"))
                testReport.Pass("<i>Readers button is in Close state. ");
            else
                ReporterFactory.LogFailure("<i>Readers button is Not in close state. ");
        }
        /// <summary>
        /// Method to Validate Readers button default
        /// </summary>
        public void ValidateReadersButtonDefault()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.CheckElementDoesnotExists(readersRow, "Readers Row");
        }
        /// <summary>
        /// Method to Validate Edit mode no change
        /// </summary>
        public void ValidateEditModeNoChange()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit1, "Edit Button");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit1, "Cancel Button");
            if (driver.CheckElementDisplayed(btnEdit1, "Edit Button"))
                testReport.Pass("<i>No changes done. ");
            else
                ReporterFactory.LogFailure("<i>Change done");
            driver.ClickElement(readers, "Readers");
            driver.sleepTime(2000);

        }
        /// <summary>
        /// Method to Validate Total Incomplete Route
        /// </summary>
        public void ValidateTotalIncompleteRoute()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(5000);
            driver.ClickElement(viewDropDown, "Drop down");
            driver.sleepTime(2000);
            driver.FindElement(By.XPath("//li[contains(@id,'All')]")).Click();
            driver.sleepTime(2000);
            if (driver.CheckElementDisplayed(thirdColumn, "Incomplete Routes"))
                testReport.Pass("<i>Total Incomplete route value is : <mark><b> " + driver.GetElementText(thirdColumn));
            else
                ReporterFactory.LogFailure("<i>Total Incomplete route Value is not Displayed as per the format. ");
        }

        /// <summary>
        /// Method to Validate Route Assignment Click
        /// </summary>
        public void ValidateRouteAssignmentClick()
        {
            driver.ClickElement(lftRouteManagement, "Route Management");
            driver.ClickElement(lftRouteAssignment, "Route Assignment");
            if (driver.CheckElementDisplayed(breadCrumb, "Route Assignment"))
                testReport.Pass("<i>Route Assignment Page is Displayed.");
            else
            {
                ReporterFactory.LogFailure("<i>Route Assignment Page is Not Displayed.");
            }
        }

        /// <summary>
        /// Method to Validate View Route Management Dashboard
        /// </summary>
        public void ValidateViewRouteManagementDashboard()
        {
            driver.ClickElement(lftNavPlatformManagement, "Platform Management");
            driver.ClickElement(lftNavRoleManagement, " Role Management");
            driver.WaitForElement(viewRouteManagement, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(viewRouteManagement, "View Route MAnagement Dashboard");
        }

        /// <summary>
        /// Method to Validate Edit Route Not Present
        /// </summary>
        public void ValidateEditRouteNotPresent()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Edit Route Save Button Display
        /// </summary>
        public void ValidateEditRouteSaveButtonDisplay()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(editRoute, "Edit");
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Edit Route Save Button Enabled
        /// </summary>
        public void ValidateEditRouteSaveButtonEnabled()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(editRoute, "Edit");
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Discard All Changes
        /// </summary>
        public void ValidateDiscardAllChanges()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(editRoute, "Edit");
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan')]"), "Reader");
            driver.WaitForElement(btnCancel, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(discardAllChanges, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(discardAllChanges, "Discard All Changes?");
            driver.ClickElement(btnYes, "Yes");
        }

        /// <summary>
        /// Method to Validate Discard All Changes noButton
        /// </summary>
        public void ValidateDiscardAllChangesNoButton()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(editRoute, "Edit");
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan')]"), "Reader");
            driver.WaitForElement(btnCancel, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(discardAllChanges, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(discardAllChanges, "Discard All Changes?");
            driver.CheckElementDisplayed(btnNo, "Mo");
            driver.ClickElement(btnYes, "Yes");
        }

        /// <summary>
        /// Method to Validate Discard All Changes noButton Access
        /// </summary>
        public void ValidateDiscardAllChangesNoButtonAccess()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(editRoute, "Edit");
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan')]"), "Reader");
            driver.WaitForElement(btnCancel, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(discardAllChanges, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(discardAllChanges, "Discard All Changes?");
            driver.CheckElementDisplayed(btnNo, "Mo");
            driver.ClickElement(btnYes, "Yes");
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(editRoute, "Ëdit");
        }

        /// <summary>
        /// Method to Validate Assign Route Reader Updated
        /// </summary>
        public void ValidateAssignRouteReaderUpdated()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Unassign Reader");
            //driver.ClickElement(selectReader, "Select Reader");
            //driver.ClickElement(By.XPath("//li[contains(.,'Ayan')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
        }

        /// <summary>
        /// Method to Validate Assign Route Status Display
        /// </summary>
        public void ValidateAssignRouteStatusDisplay()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Unassign Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
        }

        /// <summary>
        /// Method to Validate All Route Status Display
        /// </summary>
        public void ValidateAllRouteStatusDisplay()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Unassign Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
        }

        /// <summary>
        /// Method to Validate Assigned Route Unassigned Not Displayed
        /// </summary>
        public void ValidateAssignedRouteUnassignedNotDisplayed()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            testReport.Info("Route is removed from the Route view after assigning to a Reader");
        }

        /// <summary>
        /// Method to Validate Assigned Route Unassigned 
        /// </summary>
        public void ValidateAssignedRouteUnassigned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Assign Reader");
            //driver.ClickElement(selectReader, "Select Reader");
            //driver.ClickElement(By.XPath("//li[contains(.,'Ayan')]"), "Reader");
            //driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            //driver.ClickElement(btnSave, "Save");
            //driver.sleepTime(2000);
            //driver.ClickElement(viewDropDown, "Dropdown");
            //driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            testReport.Info("Assigned Route is displayed in the Route view as the View filter is set to All");
        }


        /// <summary>
        /// Method to Validate Assigned Route Reassigned 
        /// </summary>
        public void ValidateAssignedRouteReassigned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            //driver.ClickElement(checkBox, "Check Box");
            //driver.ClickElement(btnAction, "Action");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            testReport.Info("Assigned Route is displayed in the Route view as the View filter is set to All");
        }

        /// <summary>
        /// Method to Validate Assigned Route Reassigned View Assigned
        /// </summary>
        public void ValidateAssignedRouteReassignedViewAssigmnned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnassignedFrmdropdown, "Unassign");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            //driver.ClickElement(checkBox, "Check Box");
            //driver.ClickElement(btnAction, "Action");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectassignedFrmdropdown, "Assigned");
            testReport.Info("Status column or the corresponding Route is displayed as Assigned");
        }

        /// <summary>
        /// Method to Validate Unloaded Route Reassigned 
        /// </summary>
        public void ValidateUnloadedRouteReassigned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnloadedFrmdropdown, "Unloaded");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            //driver.ClickElement(checkBox, "Check Box");
            //driver.ClickElement(btnAction, "Action");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            //driver.ClickElement(btnSave, "Save");
            //driver.sleepTime(2000);
            //driver.ClickElement(viewDropDown, "Dropdown");
            //driver.ClickElement(selectassignedFrmdropdown, "Assigned");
            testReport.Info("Route is removed from the Route view after assigning to a Reader");
        }

        /// <summary>
        /// Method to Validate Unloaded Route Reassigned Filter All
        /// </summary>
        public void ValidateUnloadedRouteReassignedFilterAll()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnloadedFrmdropdown, "Unloaded");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            //driver.ClickElement(checkBox, "Check Box");
            //driver.ClickElement(btnAction, "Action");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            //driver.ClickElement(btnSave, "Save");
            //driver.sleepTime(2000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            testReport.Info("Route is removed from the Route view after assigning to a Reader");
        }

        /// <summary>
        /// Method to Validate Unloaded Route Reassigned Filter Assigned
        /// </summary>
        public void ValidateUnloadedRouteReassignedFilterAssigned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnloadedFrmdropdown, "Unloaded");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            //driver.ClickElement(checkBox, "Check Box");
            //driver.ClickElement(btnAction, "Action");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            //driver.ClickElement(btnSave, "Save");
            //driver.sleepTime(2000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectassignedFrmdropdown, "Assigned");
            testReport.Info("Unloaded Route that was assigned to a Reader is displayed when the filter is set to Assigned");
        }

        /// <summary>
        /// Method to Validate Filter Unassigned
        /// </summary>
        public void ValidateFilterUnassigned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            testReport.Info("Routes that are not assigned to a Reader is displayed in the Route Assignments screen");
        }

        /// <summary>
        /// Method to Validate Filter All
        /// </summary>
        public void ValidateFilterAll()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            testReport.Info("All routes that are available for that utility are displayed");
        }

        /// <summary>
        /// Method to Validate Filter Assigned
        /// </summary>
        public void ValidateFilterAssigned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectassignedFrmdropdown, "Assigned");
            testReport.Info("Routes that are assigned to a Reader are displayed");
        }

        /// <summary>
        /// Method to Validate Filter Loaded
        /// </summary>
        public void ValidateFilterLoaded()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectLoadedFrmdropdown, "Loaded");
            testReport.Info("Routes that are loaded to a meter reading device are displayed");
        }

        /// <summary>
        /// Method to Validate Filter Unloaded
        /// </summary>
        public void ValidateFilterUnloaded()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnloadedFrmdropdown, "Unloaded");
            testReport.Info("Routes that are Unloaded to a meter reading device are displayed");
        }

        /// <summary>
        /// Method to Validate Filter Valid Name
        /// </summary>
        public void ValidateValidName()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(filterButton_reader, TimeSpan.FromSeconds(60));

            driver.ClickElement(filterButton_reader, "Filter");
            driver.SendKeysToElementAndPressEnter(filterSearchBar, "Ayan Bhattacharjee", "Search Bar");
            driver.ClickElement(selectFilter, "Filter");
            testReport.Info("Any Routes that the reader is assigned to are displayed");
        }

        /// <summary>
        /// Method to Validate Filter Invalid Name
        /// </summary>
        public void ValidateInvalidName()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(filterButton_reader, TimeSpan.FromSeconds(60));

            driver.ClickElement(filterButton_reader, "Filter");
            driver.SendKeysToElementAndPressEnter(filterSearchBar, "Abc", "Search Bar");
            ////driver.ClickElement(selectFilter, "Filter");
            testReport.Info("NO DATA FOUND message is displayed ");
        }

        /// <summary>
        /// Method to Validate Blank Name Filter Disabled
        /// </summary>
        public void ValidateBlankNameFilterDisabled()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(filterButton_reader, TimeSpan.FromSeconds(60));

            driver.ClickElement(filterButton_reader, "Filter");
            driver.SendKeysToElementAndPressEnter(filterSearchBar, "", "Search Bar");
            driver.IsElementDisabled(selectFilter, "Filter");
            testReport.Info("Filter button is disabled when the Search field is left blank");
        }

        /// <summary>
        /// Method to Validate Clear Button
        /// </summary>
        public void ValidateClearButton()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(filterButton_reader, TimeSpan.FromSeconds(60));

            driver.ClickElement(filterButton_reader, "Filter");
            driver.SendKeysToElementAndPressEnter(filterSearchBar, "Abc", "Search Bar");
            driver.ClickElement(selectClear, "Clear");
            testReport.Info("Any Reader name entered in the search box is cleared and the Filter is closed");
        }

        /// <summary>
        /// Method to Validate Filter Route
        /// </summary>
        public void ValidateFilterRoutePartial()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(routeFilter, "Filter");
            driver.SendKeysToElementAndPressEnter(filterSearchBar, "AtlantaHwy", "Search Bar");
            driver.ClickElement(selectFilter, "Clear");
            testReport.Info("Any Routes that match the search criteria are displayed");
        }

        /// <summary>
        /// Method to Validate Filter Route Invalid Name
        /// </summary>
        public void ValidateFilterRouteInvalidName()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(routeFilter, "Filter");
            driver.SendKeysToElementAndPressEnter(filterSearchBar, "Abc", "Search Bar");
            testReport.Info("NO DATA FOUND message is displayed in the Search filter");
        }

        /// <summary>
        /// Method to Validate Filter Route blank Name
        /// </summary>
        public void ValidateFilterRouteBlankName()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(routeFilter, "Filter");
            driver.SendKeysToElementAndPressEnter(filterSearchBar, "", "Search Bar");
            driver.IsElementDisabled(selectFilter, "Filter Button");
            testReport.Info("Filter button is disabled when the Search field is left blank");
        }

        /// <summary>
        /// Method to Validate Clear Route Name
        /// </summary>
        public void ValidateClearRouteName()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.sleepTime(10000);
            driver.ClickElement(routeFilter, "Filter");
            driver.SendKeysToElementAndPressEnter(filterSearchBar, "UT06-MGMY-0001-AtlantaHwy", "Search Bar");
            driver.ClickElement(selectClear, "Clear Button");
            testReport.Info("Any Route name entered in the Search box is cleared and the Search fitter is closed");
        }

        /// <summary>
        /// Method to Validate Assigned Route Reassigned To Unassigned
        /// </summary>
        public void ValidateAssignedRouteReassignedToUnassigned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectassignedFrmdropdown, "Assigned");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Unassign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            ////driver.ClickElement(checkBox, "Check Box");
            ////driver.ClickElement(btnAction, "Action");
            //driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            //driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            testReport.Info("Route is removed from the Route view after assigning to a Reader");
        }

        /// <summary>
        /// Method to Validate Loaded Route Unassigned
        /// </summary>
        public void ValidateLoadedRouteUnassigned()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectLoadedFrmdropdown, "Loaded");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Unassign Reader");
            //driver.ClickElement(selectReader, "Select Reader");
            ////driver.ClickElement(checkBox, "Check Box");
            ////driver.ClickElement(btnAction, "Action");
            //driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            //driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            //driver.ClickElement(btnSave, "Save");
            //driver.sleepTime(2000);
            //driver.ClickElement(viewDropDown, "Dropdown");
            //driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            testReport.Info("Assigned Route is displayed in the Route view as the View filter is set to All");
        }

        /// <summary>
        /// Method to Validate Loaded Route Unassigned Hover Over
        /// </summary>
        public void ValidateLoadedRouteUnassignedHoverOver()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectLoadedFrmdropdown, "Loaded");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Assign Reader");
            //driver.ClickElement(selectReader, "Select Reader");
            ////driver.ClickElement(checkBox, "Check Box");
            ////driver.ClickElement(btnAction, "Action");
            //driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            //driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            //driver.ClickElement(btnSave, "Save");
            //driver.sleepTime(2000);
            //driver.ClickElement(viewDropDown, "Dropdown");
            //driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            driver.ClickElement(readers, "Readers");
            driver.MouseHoverByJavaScript(By.XPath("//td[contains(.,' ankur ( 2 / 695 )')]"), "Readers");
            driver.sleepTime(5000);
        }

        /// <summary>
        /// Method to Validate Loaded Route Save
        /// </summary>
        public void ValidateLoadedRouteSave()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectLoadedFrmdropdown, "Loaded");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Unassign Reader");
            //driver.ClickElement(selectReader, "Select Reader");
            ////driver.ClickElement(checkBox, "Check Box");
            ////driver.ClickElement(btnAction, "Action");
            //driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            //driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            //driver.ClickElement(viewDropDown, "Dropdown");
            //driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            //driver.ClickElement(readers, "Readers");
            //driver.MouseHoverByJavaScript(By.XPath("//td[contains(.,' ankur ( 2 / 695 )')]"), "Readers");
            //driver.sleepTime(5000);
            testReport.Info("Route is assigned to the selected Reader ");
        }

        /// <summary>
        /// Method to Validate Loaded Route Save
        /// </summary>
        public void ValidateLoadedRouteSaveHoverOver()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectLoadedFrmdropdown, "Loaded");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(unassignReader, "Unassign Reader");
            //driver.ClickElement(selectReader, "Select Reader");
            ////driver.ClickElement(checkBox, "Check Box");
            ////driver.ClickElement(btnAction, "Action");
            //driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            //driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            //driver.ClickElement(viewDropDown, "Dropdown");
            //driver.ClickElement(selectUnassignedFrmdropdown, "Unassigned");
            driver.ClickElement(readers, "Readers");
            driver.MouseHoverByJavaScript(By.XPath("//td[contains(.,' Unassigned ( 2 / 669 ) ')]"), "Readers");
            driver.sleepTime(5000);
            testReport.Info("Total number of Routes Assigned is updated");
        }


        /// <summary>
        /// Method to Validate Assigned Route Reassigned 
        /// </summary>
        public void ValidateAssignedRouteReassignedMouseHover()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.WaitForElement(editRoute, TimeSpan.FromSeconds(10));
            driver.sleepTime(10000);
            driver.ClickElement(viewDropDown, "Dropdown");
            driver.ClickElement(selectAllFrmdropdown, "All");
            driver.sleepTime(4000);
            driver.ClickElement(editRoute, "Edit");
            driver.sleepTime(4000);
            driver.WaitForElement(checkBox, TimeSpan.FromSeconds(10));
            driver.ClickElement(checkBox, "Check Box");
            driver.ClickElement(btnAction, "Action");
            driver.ClickElement(assignReader, "Assign Reader");
            driver.ClickElement(selectReader, "Select Reader");
            //driver.ClickElement(checkBox, "Check Box");
            //driver.ClickElement(btnAction, "Action");
            driver.ClickElement(By.XPath("//li[contains(.,'Ayan Bhattacharjee')]"), "Reader");
            driver.WaitForElement(btnSave, TimeSpan.FromSeconds(10));
            driver.ClickElement(btnSave, "Save");
            //driver.sleepTime(2000);
            //driver.ClickElement(viewDropDown, "Dropdown");
            //driver.ClickElement(selectAllFrmdropdown, "All");
            //testReport.Info("Assigned Route is displayed in the Route view as the View filter is set to All");
            driver.ClickElement(readers, "Readers");
            driver.MouseHoverByJavaScript(By.XPath("//td[contains(.,' ankur ( 2 / 695 )')]"), "Readers");
            driver.sleepTime(5000);
        }



        /// <summary>
        /// Method to Validate Total Incomplete Meters
        /// </summary>
        public void ValidateTotalIncompleteMeters()
        {
            driver.ClickElement(btnRouteManagement, "Route Management");
            driver.ClickElement(readers, "Readers");
            driver.WaitForElement(totalIncomplete, TimeSpan.FromSeconds(13));
            driver.CheckElementDisplayed(totalIncomplete, "Total Incomplete Meters");
        }
    }
}
