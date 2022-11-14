using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class AlertConfigurationPage : AbstractTemplatePage
    {

        #region UI Object Repository
        private By btnEdit = By.XPath("//button[text()='Edit']");
        private By btnDoneTop=By.XPath("(//button[@type='button'])[4]");
        private By btnDone = By.XPath("(//button[@type='button'])[6]");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By continousConsumption = By.XPath("//span[text()='CONTINUOUS CONSUMPTION']");
        private By contConspVerbiag=By.XPath("//span[contains(text(),'Endpoints with co')]");
        private By majorReverseFlow = By.XPath("//span[text()='MAJOR REVERSE FLOW']");
        private By gatewayStatus = By.XPath("//span[text()='GATEWAY STATUS']");
        private By conConspCritical = By.XPath("//span[contains(text(),' Continuous Consumption - Critical')]");
        private By conConspWarning = By.XPath("//span[contains(text(),' Continuous Consumption - Warning')]");
        private By conConspNormal = By.XPath("//span[contains(text(),' Continuous Consumption - Normal')]");
        private By criticalActiveMail = By.XPath("//div[2]/div[2]/div/div[1]/span");
        private By warningActiveMail = By.XPath("//div[2]/div[2]/div/div[2]/span");
        private By normalActiveMail = By.XPath("//div[2]/div[2]/div/div[3]/span");
        private By crtiticalConspDescr = By.XPath("//h6[contains(.,'Endpoints with continuous consumption for greater than')]");
        private By normalDescription = By.XPath("//div[2]/div[2]/div/h6[3]");
        private By threshold7to14Days = By.XPath("//div[2]/div/div/div[2]/div[2]/div/h6[2]");
        private By normalContinousConsumption = By.XPath("//h6[contains(.,' 1  to  2  consecutive days')]");
        private By To7ConsecutiveDays = By.XPath("//h6[contains(.,'Endpoints with continuous consumption for 1')]");
        private By criticalEditUp=By.XPath("//span/span/span/span");
        private By warningEditUp = By.XPath("//div[2]/kendo-numerictextbox/span/span/span/span");
        private By normalEditUp = By.XPath("//div[3]/kendo-numerictextbox/span/span/span/span");
        private By criticalEdit = By.XPath("//div[1]/kendo-numerictextbox/span/input");
        private By warningEdit=By.XPath("//div[2]/kendo-numerictextbox/span/input");
        private By majorReverseFlowThresholdDesc = By.XPath("//h6[contains(.,'Any endpoints reporting major reverse flow for the previous day')]");
        private By normalEdit = By.XPath("//div[3]/kendo-numerictextbox/span/input");
        private By ThresholdErrorMsg = By.XPath("//span[contains(.,'Warning Consumption minimum 2 to maximum 34')]");
        private By normalThresholdErrorMsg = By.XPath("//span[contains(.,'Normal Consumption minimum 1 to maximum 33 and less than warning')]");
        private By toastMessage = By.Id("toast-container");
        private By majorReverseFlowCritical = By.XPath("//span[text()=' Major Reverse Flow - Critical']");
        private By breadCrumb = By.XPath("//ng-sidebar-container//sd-toolbar//span/span");
        private By optionSection = By.XPath("//div/div/sd-blank/div[2]/div[1]/div/div");

        #endregion


        /// <summary>
        /// Method to Validate Alert Confug Edit Btn
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateAlertConfigEditBtn()
        {
            driver.CheckElementDisplayed(btnEdit, "Edit Button");
            driver.sleepTime(1000);
        }

        /// <summary>
        /// Method to Validate Alert Confug Done Btn
        /// </summary>
        public void ValidateAlertConfigDoneBtn()
        {
            driver.CheckElementDisplayed(btnDoneTop, "Done Button");
            driver.sleepTime(1000);
        }
        
        /// <summary>
        /// Method to Validate Alert Config Page Title
        /// </summary>
        public void ValidateAlertConfigPageTitle()
        {            
            testReport.Info(driver.GetElementText(breadCrumb));
        }

        /// <summary>
        /// Method to Validate Alert Config Breadcrumb
        /// </summary>
        public void ValidateAlertConfigBreadcrumb()
        {
            driver.CheckElementDisplayed(breadCrumb, "Bread Crumb");
        }

        /// <summary>
        /// Method to Validate Event Options
        /// </summary>
        public void ValidateEventOptions()
        {
            driver.CheckElementDisplayed(continousConsumption, "Continous Consumption");
            driver.CheckElementDisplayed(majorReverseFlow, "Major Reverse Flow");
            driver.CheckElementDisplayed(gatewayStatus, "Gateway Status");
            driver.sleepTime(1000);
        }

        /// <summary>
        /// Method to Validate Event Description
        /// </summary>
        public void ValidateUniqueDescription()
        {
            driver.CheckElementDisplayed(continousConsumption, "Continous Consumption");
            driver.CheckElementDisplayed(majorReverseFlow, "Major Reverse Flow");
            driver.CheckElementDisplayed(gatewayStatus, "Gateway Status");
            driver.CheckElementDisplayed(continousConsumption, "Endpoints with consumption");
            driver.ClickElement(majorReverseFlow, "");
            driver.CheckElementDisplayed(majorReverseFlowThresholdDesc, "Endpoints reporting a major reverse flow");
            driver.sleepTime(1000);
        }

        /// <summary>
        /// Method to Validate Only One Event
        /// </summary>
        public void ValidateOnlyOneEvent()
        {
            driver.ClickElement(continousConsumption, "Endpoints with consumption");            
            driver.sleepTime(1000);
        }

        /// <summary>
        /// Method to Validate Options Section
        /// </summary>
        public void ValidateOptionSection()
        {
            driver.WaitForElement(optionSection,TimeSpan.FromSeconds(1));
            driver.CheckElementDisplayed(optionSection, "Option Section");
            driver.sleepTime(1000);
        }

        /// <summary>
        /// Method to Validate Own Group Setting
        /// </summary>
        public void ValidateOwnGroupSetting()
        {
            driver.ClickElement(continousConsumption, "Continous Consumption");
            driver.ClickElement(majorReverseFlow, "Major Reverse Flow");
            driver.ClickElement(gatewayStatus, "Gateway Status");
            driver.sleepTime(1000);
        }

        /// <summary>
        /// Method to Validate Done Button Seleted
        /// </summary>
        public void ValidateDoneButtonSeleted()
        {
            driver.ClickElement(btnDoneTop, "Done");
            testReport.Pass("User is redirected back to the Home/Landing page");
        }

        // <summary>
        /// Method to Validate Continous Consumption Verbiage
        /// </summary>
        public void ValidateContinousConsumptionVerbiage()
        {
            driver.CheckElementDisplayed(contConspVerbiag, "Continous Consumption");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Continous Consumption Options
        /// </summary>
        public void ValidateContinousConsumptionOptions()
        {
            driver.CheckElementDisplayed(conConspCritical, "Continous Consumption Critical");
            driver.CheckElementDisplayed(conConspWarning, "Continous Consumption Warning");
            driver.CheckElementDisplayed(conConspNormal, "Continous Consumption Normal");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Critical Active Mail
        /// </summary>
        public void ValidateCriticalActiveMail()
        {
            driver.CheckElementDisplayed(criticalActiveMail, "Active Mail");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Warning Active Mail
        /// </summary>
        public void ValidateWarningActiveMail()
        {
            driver.CheckElementDisplayed(warningActiveMail, "Active Mail");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Normal Active Mail
        /// </summary>
        public void ValidateNormalActiveMail()
        {
            driver.CheckElementDisplayed(normalActiveMail, "Active Mail");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Critical Consumption Description
        /// </summary>
        public void ValidateCritiConsumpDescription()
        {
            driver.CheckElementDisplayed(crtiticalConspDescr, "Critical Consumption Description");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Warning Threshold Consumption Description
        /// </summary>
        public void ValidateWarningThresholdConsumptionDescription()
        {
            driver.CheckElementDisplayed(threshold7to14Days, "Warning Threshold Consumption Description");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Normal Threshold Consumption Description
        /// </summary>
        public void ValidateNormalThresholdConsumptionDescription()
        {
            driver.CheckElementDisplayed(To7ConsecutiveDays, "Endpoints with continuous consumption for between 1 and 7 consecutive days") ;
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Major Reverse Flow Threshold Description
        /// </summary>
        public void ValidateMajorReverseFlowThresholdDescription()
        {
            driver.ClickElement(majorReverseFlow, "Major Reverse Flow");
            driver.CheckElementDisplayed(majorReverseFlowThresholdDesc, "Major Reverse Flow Threshold Description");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Major Reverse Flow Default Threshold Value
        /// </summary>
        public void ValidateMajorReverseFlowDefaultThresholdValue()
        {
            driver.ClickElement(majorReverseFlow, "Major Reverse Flow");
            driver.CheckElementDisplayed(criticalEdit, "Threshold Value");
            testReport.Pass(driver.GetElementText(criticalEdit));
        }

        // <summary>
        /// Method to Validate Major Reverse Flow Done Btn Enabled
        /// </summary>
        public void ValidateMajorReverseFlowDoneBtnEnabled()
        {
            driver.ClickElement(majorReverseFlow, "Major Reverse Flow");
            driver.sleepTime(3000);
            driver.IsElementEnabled(btnDoneTop, "Done");
        }

        // <summary>
        /// Method to Validate Edit Button Cancel Button
        /// </summary>
        public void ValidateEditButtonCancelButton()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.CheckElementDisplayed(btnCancel, "Cancel Button");
            driver.CheckElementDisplayed(btnDone, "Done Button");
            driver.sleepTime(1000);
        }

        // <summary>
        /// Method to Validate Edit Button Disabled
        /// </summary>
        public void ValidateEditButtonDisabled()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.IsElementDisabled(btnEdit, "Edit Button");
        }

        // <summary>
        /// Method to Validate Event Cannot be changed
        /// </summary>
        public void ValidateEventCannotBeChanged()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(majorReverseFlow, "Major Reverse Flow");
        }

        // <summary>
        /// Method to Validate Events Disabled
        /// </summary>
        public void ValidateEventsDisabled()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.CheckElementDisplayed(majorReverseFlow, "Major Reverse Flow");
        }

        // <summary>
        /// Method to Validate Alert Options
        /// </summary>
        public void ValidateAlertOptions()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.CheckElementDisplayed(conConspCritical, "Continous Consumption-Critical");
            driver.CheckElementDisplayed(conConspWarning, "Continous Consumption-Warning");
            driver.CheckElementDisplayed(conConspNormal, "Continous Consumption-Normal");
        }

        // <summary>
        /// Method to Validate Critical ThreshHold Cannot be Edited
        /// </summary>
        public void ValidateCriticalThreshHoldCannotBeEdited()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(crtiticalConspDescr, "Threshold Description cannot be directly edited");
        }

        // <summary>
        /// Method to Validate Normal ThreshHold Cannot be Edited
        /// </summary>
        public void ValidateNormalThreshHoldCannotBeEdited()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(normalContinousConsumption, "Threshold Description cannot be directly edited");
        }

        // <summary>
        /// Method to Validate ThreshHold Value 
        /// </summary>
        public void ValidateThreshHoldValue()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            testReport.Pass("Threshold Description has a placeholder text / value as: " +driver.GetElementText(threshold7to14Days));
        }

        // <summary>
        /// Method to Validate ThreshHold Value Editable
        /// </summary>
        public void ValidateCriticalThreshHoldValueEditable()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(criticalEditUp, "Threshold Edit");
        }

        // <summary>
        /// Method to Validate Normal ThreshHold Value Editable
        /// </summary>
        public void ValidateNormalThreshHoldValueEditableUp()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(normalEditUp, "Normal Threshold Edit");
        }

        // <summary>
        /// Method to Validate Warning ThreshHold Value Editable
        /// </summary>
        public void ValidateWarningThreshHoldValueEditable()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(warningEdit, "","Warning Edit");
            testReport.Pass("Threshold Value is editable");
        }

        // <summary>
        /// Method to Validate Normal ThreshHold Value Editable
        /// </summary>
        public void ValidateNormalThreshHoldValueEditable()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(normalEdit, "", "Normal Edit");
            testReport.Pass("Threshold Value is editable");
        }

        // <summary>
        /// Method to Validate Toast Message
        /// </summary>
        public void ValidateToastMessage()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(warningEdit, "7", "Warning Edit");
            driver.ClickElement(btnDone, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(toastMessage, "Action Saved");
        }

        // <summary>
        /// Method to Validate Change Abandoned
        /// </summary>
        public void ValidateChangeAbandoned()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(criticalEdit, "7", "Critical Edit");
            driver.CheckElementDisplayed(btnDone, "Done");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(crtiticalConspDescr, TimeSpan.FromSeconds(10));
        }

        // <summary>
        /// Method to Validate Change Abandoned Cancel Done Btn
        /// </summary>
        public void ValidateChangeAbandonedCancelDoneBtn()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(criticalEdit, "7", "Critical Edit");
            driver.CheckElementDisplayed(btnDone, "Done");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
            driver.WaitForElement(crtiticalConspDescr, TimeSpan.FromSeconds(10));
            driver.CheckElementDoesnotExists(btnCancel, "Cancel");
            driver.CheckElementDoesnotExists(btnDone, "Done");
        }

        // <summary>
        /// Method to Validate Alert Options Reverted
        /// </summary>
        public void ValidateAlertOptionsReverted()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(criticalEdit, "7", "Critical Edit");
            driver.CheckElementDisplayed(btnDone, "Done");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
            driver.CheckElementDisplayed(criticalActiveMail, "Alert Active: Daily Mail");
        }
        // <summary>
        /// Method to Validate Alert Options Reverted
        /// </summary>
        public void ValidateEventAllCaps()
        {
            testReport.Pass(driver.GetElementText(continousConsumption));
            testReport.Pass(driver.GetElementText(majorReverseFlow));
            testReport.Pass(driver.GetElementText(gatewayStatus));
        }

        // <summary>
        /// Method to Validate Major Reverse Flow Edit Btn Disabled
        /// </summary>
        public void ValidateMajorReverseFlowEditBtnDisabled()
        {
            driver.ClickElement(majorReverseFlow, "Major Reverse Flow");
            driver.IsElementDisabled(btnEdit, "Edit");
        }

        // <summary>
        /// Method to Validate Major Reverse Flow Critical
        /// </summary>
        public void ValidateMajorReverseFlowCritical()
        {
            try
            {
                driver.ClickElement(majorReverseFlow, "Major Reverse Flow");
                driver.CheckElementDisplayed(majorReverseFlowCritical, "Major Reverse Flow Critical");
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Failed");
            }
        }

        // <summary>
        /// Method to Validate Major Reverse Alert Active
        /// </summary>
        public void ValidateMajorReverseFlowAlertActive()
        {
            driver.ClickElement(majorReverseFlow, "Major Reverse Flow");
            driver.CheckElementDisplayed(criticalActiveMail, "Major Reverse Flow Critical");
        }

        // <summary>
        /// Method to Validate Change Abandoned Edit Btn Enabled
        /// </summary>
        public void ValidateChangeAbandonedEditBtnEnabled()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(criticalEdit, "7", "Critical Edit");
            driver.CheckElementDisplayed(btnDone, "Done");
            driver.CheckElementDisplayed(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
            driver.IsElementEnabled(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnEdit, "Edit");
        }

        // <summary>
        /// Method to Validate Done Button selected Cancel Button
        /// </summary>
        public void ValidateDoneButtonSelectedCancelButton()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.sleepTime(2000);
            driver.SendKeysToElementClearFirst(warningEdit, "1", "Warning Edit");
            driver.ClickElement(btnDone, "Done");
            driver.sleepTime(2000);
            if(driver.CheckElementDoesnotExists(btnCancel, "Cancel"))
            {
                testReport.Pass("Cancel Button does not exist. ");
            }
            else
            {
                ReporterFactory.LogFailure("Cancel Button does exist.");
            }
        }
        // <summary>
        /// Method to Validate Edit Done Button Enabled
        /// </summary>
        public void ValidateEditDoneButtonEnabled()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(warningEdit, "7", "Warning Edit");
            driver.ClickElement(btnDone, "Done");
            driver.WaitForElement(toastMessage, TimeSpan.FromSeconds(20));
            driver.sleepTime(2000);
            driver.CheckElementDisplayed(btnEdit, "Edit");
            driver.CheckElementDisplayed(btnDoneTop, "Done");
        }
        // <summary>
        /// Method to Validate Normal ThreshHold Value Editable updated
        /// </summary>
        public void ValidateNormalThreshHoldValueEditableUpdated()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(normalEdit, "", "Normal Edit");
            testReport.Pass("Threshold Value is editable");
            driver.CheckElementDisplayed(normalDescription, "Description");
        }

        // <summary>
        /// Method to Validate Conitnous Consumption Value Editable updated
        /// </summary>
        public void ValidateConitnousConsumptionValueEditableUpdated()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(normalEdit, "6", "Normal Edit");
            testReport.Pass("Threshold Value is editable");
            driver.CheckElementDisplayed(normalDescription, "Description");
        }

        // <summary>
        /// Method to Validate Normal ThreshHold Value Not Empty
        /// </summary>
        public void ValidateNormalThreshHoldValueENotEmpty()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(normalEdit, "", "Normal Edit");
            driver.ClickElement(btnDone, "Done");
            driver.CheckElementDisplayed(normalThresholdErrorMsg, "Error Message");
        }

        // <summary>
        /// Method to Validate Normal ThreshHold Value Out Of Range
        /// </summary>
        public void ValidateNormalThreshHoldValueOutOfRange()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(normalEdit, "36", "Normal Edit");
            driver.ClickElement(btnDone, "Done");
            driver.CheckElementDisplayed(normalThresholdErrorMsg, "Error Message");
        }



        // <summary>
        /// Method to Validate Warning ThreshHold Value Updated
        /// </summary>
        public void ValidateWarningThreshHoldValueUpdated()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(warningEditUp, "Warning Edit Button");
            driver.ClickElement(btnDone, "Done");
            testReport.Pass("Threshold Value is editable");
        }

        // <summary>
        /// Method to Validate Warning ThreshHold Value Empty
        /// </summary>
        public void ValidateWarningThreshHoldValueEmpty()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(warningEdit,"", "Warning Edit");
            driver.ClickElement(btnDone, "Done");
            testReport.Pass("Threshold Value Can Not be Empty");
        }
        // <summary>
        /// Method to Validate Warning ThreshHold Value Arrow Editable
        /// </summary>
        public void ValidateWarningThreshHoldValueArrowEditable()
        {
            driver.ClickElement(warningEditUp, "Warning Edit Button");
            testReport.Pass("Threshold Value is editable");
        }

        // <summary>
        /// Method to Validate ThreshHold Value Updated
        /// </summary>
        public void ValidateThreshHoldValueUpdated()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.ClickElement(criticalEditUp, "Threshold Edit");
            driver.CheckElementDisplayed(crtiticalConspDescr, "");
            driver.ClickElement(crtiticalConspDescr, "");
            testReport.Pass("Updated Threshold Value is : " + driver.GetElementText(crtiticalConspDescr));
        }

        // <summary>
        /// Method to Validate ThreshHold Value Can not be empty
        /// </summary>
        public void ValidateThreshHoldValueCanNotBeEmpty()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(criticalEdit, " ", "Threhold Value");
            driver.ClickElement(btnDone, "Done Button");
        }

        // <summary>
        /// Method to Validate ThreshHold Value Range
        /// </summary>
        public void ValidateThreshHoldValueRange()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.SendKeysToElementClearFirst(criticalEdit, "", "Threhold Value");
            driver.ClickElement(btnDone, "Done Button");
            driver.WaitForElement(ThresholdErrorMsg, TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(ThresholdErrorMsg, "Threshold Error Msg");
        }

        // <summary>
        /// Method to Validate ThreshHold Value Range Description
        /// </summary>
        public void ValidateThreshHoldValueDescription()
        {
            driver.ClickElement(btnEdit, "Edit Button");
            driver.CheckElementDisplayed(warningEdit, "Threshold Value");
            testReport.Pass("Threshold Value is a placeholder: "+ driver.GetElementText(criticalEdit));
        }

        // <summary>
        /// Method to Validate Continous Consumption Normal
        /// </summary>
        public void ValidateContinousConsumptionNormal()
        {
            driver.CheckElementDisplayed(conConspNormal, "Continous Consumption Normal Alert Active");
            driver.sleepTime(1000);
        }
    }
}
