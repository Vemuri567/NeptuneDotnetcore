using OpenQA.Selenium;

namespace Neptune360UIAutomation
{
    public class NotificationPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By tempNewUserReg = By.XPath("//span[text()='New User Registration']/..");
        private By tempResetPwd = By.XPath("//span[text()='Reset Password']/..");
        private By tempResetPwdAfterUnlock = By.XPath("//span[text()='Reset Password After Unlock']/..");
        private By txtEmailSubject = By.XPath("//div[text()='Email Subject']/following-sibling::div//input");
        private By btnSave = By.XPath("//button[text()='Save']");
        private By btnCancel = By.XPath("//button[text()='Cancel']");
        private By btnEdit = By.XPath("//button[text()='Edit']");
        private By Notification = By.XPath("//i[@class='fa fa-bell-o']");
        private By NotificationClose = By.XPath("//i[@class='fa fa-times close-modal']");
        private By btnNotifications = By.XPath("//img[contains(@src,'Notifications.3D')]");
        private By screenEmailNotification = By.XPath("//h2[text()='Email Notification Templates']");
        private By notificationTemp = By.XPath("//div[@class='template-list-container']");
        //private By /*txtEditBody*/ = By.XPath("//h1");
        private By txt_EditBox = By.XPath("//div[2]/div[2]/sd-email-template-editor/div/div/div/div[1]/div[2]/input");
        private By templateReferenceIdTxt = By.XPath("//input[@formcontrolname='templateReferenceId']");
        private By frameEditor = By.XPath("//iframe[contains(@title, 'Editable area')]");
        private By eventsHeader = By.XPath("//h4[contains(.,'Events')]");
        private By majorReverseFlowEvent=By.XPath("//span[contains(.,'MAJOR REVERSE FLOW')]");
        private By ctrlBold = By.XPath("//a[@title='Bold']");
        private By ctrlItalic = By.XPath("//a[@title='Italic']");
        private By ctrlUnderline = By.XPath("//a[@title='Underline']");
        private By ctrlStrikethrough = By.XPath("//a[@title='Strikethrough']");
        private By ctrlAlignTxtLeft = By.XPath("//a[@title='Align text left']");
        private By ctrlCenterTxt = By.XPath("//a[@title='Center text']");
        private By ctrlAlignTxtRight = By.XPath("//a[@title='Align text right']");
        private By ctrlJustify = By.XPath("//a[@title='Justify']");
        private By ctrlInsertUnorderedList = By.XPath("//a[@title='Insert unordered list']");
        private By ctrlInsertOrderedList = By.XPath("//a[@title='Insert ordered list']");
        private By ctrlIndent = By.XPath("//a[@title='Indent']");
        private By ctrlInsertHyperLink = By.XPath("//a[@title='Insert hyperlink']");
        private By ctrlSubscript = By.XPath("//a[@title='Subscript']");
        private By ctrlSuperscript = By.XPath("//a[@title='Superscript']");
        private By ctrlViewHtml = By.XPath("//a[@title='View HTML']");
        private By ctrlCleanFormatting = By.XPath("//a[@title='Clean formatting']");
        private By ctrlInsertGetLinkPlaceHolder = By.XPath("//a[@title='Insert Get Link placeholder']");
        private By drpFormat = By.CssSelector(".k-state-focused > .k-input");
        private By lstFormatHeading1 = By.XPath("//div[@class='k-animation-container']//li[3]");
        private By lstFormatHeading2 = By.XPath("//div[@class='k-animation-container']//li[4]");
        private By lstFormatHeading3 = By.XPath("//div[@class='k-animation-container']//li[5]");
        private By drpFontFamily = By.XPath("//input[@title='Select font family']//../span[2]");
        private By lstFontArial = By.XPath("//li[text()='Arial']");
        private By lstFontCourierNew = By.XPath("//li[text()='Courier New']");
        private By lstFontGeorgia = By.XPath("//li[text()='Georgia']");
        private By lstFontImpact = By.XPath("//li[text()='Impact']");
        private By lstFontLucidaConsole = By.XPath("//li[text()='Lucida Console']");
        private By lstFontTahoma = By.XPath("//li[text()='Tahoma']");
        private By lstFontTimesNewRoman = By.XPath("//li[text()='Times New Roman']");
        private By lstFontTrebuchetMS = By.XPath("//li[text()='Trebuchet MS']");
        private By drpFontSize = By.XPath("//input[@title='Select font size']//../span[2]");
        private By lstFontSize1 = By.XPath("//li[text()='1 (8pt)']");
        private By lstFontSize2 = By.XPath("//li[text()='2 (10pt)']");
        private By lstFontSize3 = By.XPath("//li[text()='3 (12pt)']");
        private By lstFontSize4 = By.XPath("//li[text()='4 (14pt)']");
        private By lstFontSize5 = By.XPath("//li[text()='5 (18pt)']");
        private By lstFontSize6 = By.XPath("//li[text()='6 (24pt)']");
        private By lstFontSize7 = By.XPath("//li[text()='7 (36pt)']");
        private By screenEditor = By.XPath("//h4[text()='Editor']");
        private By btnGetLink = By.XPath("//span[text()='Get Link']");        
        private By msgEmailTemplateSaved = By.Id("toast-container");
        private By breadcrumb = By.XPath("//sd-toolbar/div/span/span");
        #endregion

        /// <summary>
        /// Method to Validate Edit Notification
        /// </summary>
        public void ValidateEditNotification()
        {
            driver.sleepTime(10000);
            driver.ClickElement(tempNewUserReg, "New User Registration Template");
            driver.SendKeysToElement(txtEmailSubject, "a", "Email Subject");
            driver.CheckElementExists(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Edit Notification Does Not Exists
        /// </summary>
        public void ValidateEditNotificationDoesNotExists()
        {
            //driver.ClickElement(btnNotifications, "Notifications Widget");
            driver.CheckElementDoesnotExists(btnEdit, "Edit Notification");
        }

        /// <summary>
        /// Method to Validate View Notification
        /// </summary>
        public void ValidateViewNotification()
        {
            //driver.ClickElement(btnNotifications, "Notifications Widget");
            driver.sleepTime(6000);
            driver.ClickElement(tempNewUserReg, "New User Registration");
            driver.CheckElementExists(tempResetPwd, "Reset Password");
            driver.CheckElementExists(tempResetPwdAfterUnlock, "Reset Password After Unlock");
        }

        /// <summary>
        /// Method to Validate View Notification Does Not Exists
        /// </summary>
        public void ValidateViewNotificationDoesNotExists()
        {
            driver.ClickElement(Notification, "Notifications");
            driver.sleepTime(6000);
            driver.ClickElement(NotificationClose, "Close");
            driver.CheckElementDoesnotExists(btnNotifications, "No Notifications displayed");
            
        }
        /// <summary>
        /// Method to Valdiate Notification Widget Diplays
        /// </summary>
        public void ValidateNotificationWidgetDisplays()
        {
            driver.ClickElement(btnNotifications, "Notifications Widget");
        }

        /// <summary>
        /// Method to Validate Email Notification Editor Screen Displays
        /// </summary>
        public void ValidateEmailNotificationEditorScreenDisplays()
        {
            driver.WaitForElement(screenEmailNotification, System.TimeSpan.FromSeconds(10));
            driver.CheckElementExists(screenEmailNotification, "Email Notification Editor Screen");
        }

        /// <summary>
        /// Method to Validate Email Notification Editor Screen
        /// </summary>
        public void ValidateEmailNotificationEditorScreen()
        {
            if(driver.GetElementText(breadcrumb).Contains("EMAIL NOTIFICATION TEMPLATES"))
            {
                testReport.Pass("EMAIL NOTIFICATION EDITOR Page Displayed");
            }else
            {
                ReporterFactory.LogFailure("EMAIL NOTIFICATION EDITOR Page Not Displayed");
            }
        }

        /// <summary>
        /// Method to Validate Email Editor Tempalte Body Preview
        /// </summary>
        public void ValidateEmailEditorTemplateBodyPreview()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            //driver.ClickElement(txtEditBody, "Edit Body");
            //driver.ClickElement(ctrlBold, "Bold");
            //driver.CheckElementExists(ctrlItalic, "Italic");
            //driver.CheckElementExists(ctrlUnderline, "Underline");
            //driver.CheckElementExists(ctrlStrikethrough, "Strike Through");
            //driver.CheckElementExists(ctrlAlignTxtLeft, "Align Text Left");
            //driver.CheckElementExists(ctrlAlignTxtRight, "Align Text Right");
            //driver.CheckElementExists(ctrlJustify, "Justify");
            //driver.CheckElementExists(ctrlInsertOrderedList, "Insert Ordered List");
            //driver.CheckElementExists(ctrlInsertUnorderedList, "Insert Unordered List");
            //driver.CheckElementExists(ctrlIndent, "Indent");
            //driver.CheckElementExists(ctrlInsertHyperLink, "Insert Hyper Link");
            //driver.CheckElementExists(ctrlSubscript, "Subscript");
            //driver.CheckElementExists(ctrlSuperscript, "Superscript");
            //driver.CheckElementExists(ctrlViewHtml, "View Html");
            //driver.CheckElementExists(ctrlCleanFormatting, "Clean Formatting");
            //driver.CheckElementExists(ctrlInsertGetLinkPlaceHolder, "Insert Get Link Place Holder");
        }

        /// <summary>
        /// Method to Validate Body Preview Edit Format
        /// </summary>
        public void ValidateBodyPreviewEditFormat()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            driver.SwitchToFrameByIndex(0);
            //driver.ClickElement(txtEditBody, "Edit Body");
            //driver.ClickElement(drpFormat, "Format");
            //driver.ClickElement(drpFormat, "Format");
            //driver.CheckElementDisplayed(lstFormatHeading1, "Heading1");
            //driver.CheckElementDisplayed(lstFormatHeading2, "Heading2");
            //driver.CheckElementDisplayed(lstFormatHeading3, "Heading3");
            driver.SwitchToDefaultFrame();
        }

        /// <summary>
        /// Method to Validate Body Preview Edit Font List
        /// </summary>
        public void ValidateBodyPreviewEditFontList()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            //driver.ClickElement(txtEditBody, "Edit Body");
            //driver.CheckElementExists(drpFontFamily, "Font");
            //driver.ClickElement(drpFontFamily, "Font");
            //driver.CheckElementExists(lstFontArial, "Arial");
            //driver.CheckElementExists(lstFontCourierNew, "Courier New");
            //driver.CheckElementExists(lstFontGeorgia, "Georgia");
            //driver.CheckElementExists(lstFontImpact, "Impact");
            //driver.CheckElementExists(lstFontLucidaConsole, "Lucida Console");
            //driver.CheckElementExists(lstFontTahoma, "Tahoma");
            //driver.CheckElementExists(lstFontTimesNewRoman, "TImes New Roman");
            //driver.CheckElementExists(lstFontTrebuchetMS, "Trebuchet");
        }

        /// <summary>
        /// Method to Validate Body Preview Edit Font Size
        /// </summary>
        public void ValidateBodyPreviewEditFontSize()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            //driver.ClickElement(txtEditBody, "Edit Body");
            //driver.CheckElementExists(drpFontSize, "Font Size");
            //driver.ClickElement(drpFontSize, "Font Size");
            //driver.CheckElementExists(lstFontSize1, "1 (8pt)");
            //driver.CheckElementExists(lstFontSize2, "2 (10pt)");
            //driver.CheckElementExists(lstFontSize3, "3 (12pt)");
            //driver.CheckElementExists(lstFontSize4, "4 (14pt)");
            //driver.CheckElementExists(lstFontSize5, "5 (18pt)");
            //driver.CheckElementExists(lstFontSize6, "6 (24pt)");
            //driver.CheckElementExists(lstFontSize7, "7 (36pt)");
        }

        /// <summary>
        /// Method to Validate Editor Screen Displays
        /// </summary>
        public void ValidateEditorScreenDisplays()
        {
            driver.CheckElementExists(screenEditor, "Editor Screen");
        }

        /// <summary>
        /// Method to Validate Get Link Button Displays
        /// </summary>
        public void ValidateGetLinkBtnDisplays()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            //driver.ClickElement(txtEditBody, "Edit Body");
            //driver.CheckElementExists(btnGetLink, "Get Link");
        }

        /// <summary>
        /// Method to Validate Editor Edit Cancel
        /// </summary>
        public void ValidateEditorEditCancel()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            driver.ClickElement(templateReferenceIdTxt, "Edit Body");
            driver.SendKeysToElement(templateReferenceIdTxt, "Hi", "Edit Text");
            driver.CheckElementExists(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Editor Edit Save
        /// </summary>
        public void ValidateEditorEditSave()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            driver.ClickElement(templateReferenceIdTxt, "Edit Body");
            driver.SendKeysToElement(templateReferenceIdTxt, "Hi", "Edit Text");
            driver.CheckElementExists(btnSave, "Save");
            driver.ClickElement(btnSave, "Save");
            driver.sleepTime(2000);
            driver.WaitForElement(msgEmailTemplateSaved, System.TimeSpan.FromSeconds(10));
            if(driver.CheckElementExists(msgEmailTemplateSaved, "Email Template Saved"))
            {
                testReport.Pass("Email Template Saved");
            }
            else
            {
                ReporterFactory.LogFailure("Email Template Not Saved");
            }
        }

        /// <summary>
        /// Method to Validate Template Selection Displays
        /// </summary>
        public void ValidateTemplateSelectionDisplayed()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            //driver.ClickElement(txtEditBody, "New User Registration Selection Details");
        }

        /// <summary>
        /// Method to Validate Email Subject Editable
        /// </summary>
        public void ValidateEmailSubjectEditable()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            driver.ClickElement(templateReferenceIdTxt, "Email Subject");
            driver.SendKeysToElement(templateReferenceIdTxt, "Edit Subject", "Email Subject");
        }

        /// <summary>
        /// Method to Validate Email Body Editable
        /// </summary>
        public void ValidateEmailBodyEditable()
        {
            driver.ClickElement(tempNewUserReg, "New User Registration");
            //driver.ClickElement(txtEditBody, "Edit Body");
            //driver.SendKeysToElementClearFirst(txtEditBody, "xyz", "Edit Body");
        }


        /// <summary>
        /// Method to Validate Notification Section
        /// </summary>
        public void ValidateNotificationSection()
        {
            //driver.ClickElement(btnNotifications, "Notification");
            driver.WaitForElement(notificationTemp, System.TimeSpan.FromSeconds(20));
            driver.CheckElementDisplayed(notificationTemp,"Notifications Section");
        }

        /// <summary>
        /// Method to Validate Events Header
        /// </summary>
        public void ValidateEventsHeader()
        {
            driver.CheckElementDisplayed(eventsHeader, "Events Header");
        }

        /// <summary>
        /// Method to Validate Major Reverse Flow Event
        /// </summary>
        public void ValidateMajorReverseFlowEvent()
        {
            driver.CheckElementDisplayed(majorReverseFlowEvent, "Major Reverse Flow Event");
        }



    }
}
