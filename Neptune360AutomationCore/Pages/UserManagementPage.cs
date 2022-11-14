using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using Keys = OpenQA.Selenium.Keys;

namespace Neptune360UIAutomation
{
    public class UserManagementPage : AbstractTemplatePage
    {
        #region UI Object Repository
        private By drpStatus = By.Id("drpStatus");
        private By drpRole = By.Id("drpRole");
        private By ddlRoleCustServOption = By.XPath("//li[contains(.,'Neptune Customer Service Rep')]");
        private By ddlRoleFieldServOption = By.XPath("//li[contains(.,'Neptune Field Service PM')]");
        private By ddlRoleSysAdminOption = By.XPath("//li[contains(.,'Neptune System Administrator')]");
        private By ddlRoleUtilityAdminOption = By.XPath("//li[contains(.,'Utility Administrator')]");
        private By ddlRoleUtilityReadOption = By.XPath("//li[contains(.,'Utility Read Only Access')]");
        private By ddlRoleUtilityUserOption = By.XPath("//li[contains(.,'Utility User')]");
        private By ddlRoleUtilityMeterReaderOption = By.XPath("//li[contains(.,'Utility Meter Reader')]");
        private By ddlRoleNeptuneCustomerSupportOption = By.XPath("//li[contains(.,'Neptune Customer Support')]");
        private By ddlRoleUtilityRemove = By.XPath("//li[contains(.,'[ X ] Remove')]");
        private By drpLanguage = By.Id("drpLanguage");
        private By btnCreate = By.XPath("//button[@id='userCreateButton']");
        private By btnCreateLanding = By.XPath("//button[text()='Create']");
        private By lftLblCreateDate = By.XPath("//label[text() = 'Create Date']/../div/div/input");
        private By txtFirstName = By.Id("txtFirstname");
        private By txtLastName = By.Id("txtLastname");
        private By txtEmailAddress = By.Id("txtEmail");
        private By txtSearchUtility = By.XPath("//kendo-autocomplete[@id='search-utility']//input");
        private By lftTxtSearchUtility = By.XPath("//input[@placeholder='Search Utility Name or ID']");
        private By lstSearchUtilityAtlanta = By.XPath("//span[text() = 'SQA Automation RTesting']");
        private By lstSearchUtilityTest = By.XPath("//span[text() = 'Test12345']");
        private By selectedUserRole = By.XPath("// kendo-dropdownlist[@id='drpRolesMult']//span[@class='k-input-value-text']");
        private By utilityAddBtn = By.XPath(" //span[text() = 'Test12345']//..//span[@class='utility-add']");
        private By lstSearchUtilityDemo = By.XPath("//span[text() = 'V4 Test']");
        private By lblAssignUtility = By.XPath("//span[text() = 'Assign Utility']");
        private By lftdrpUserRole = By.Id("drpRolesMult");
        private By btnSave = By.Id("btnSave");
        private By btnCancel = By.Id("btnCancel");
        private By cancelBtn = By.XPath("//button[text()='Cancel']");
        private By btnCreateSingleUtility = By.XPath("//div/button");
        private By drpSingleUserRole = By.Id("drpUsers");
        private By drpRolesList = By.XPath("//kendo-dropdownlist[@id='drpRolesMult']");
        private By editlink = By.Id("itemlink");
        private By txtSearchEmailAddress = By.Id("txtEmailSearch");
        private By SearchEmailAddress = By.XPath("//button[text()='Search']");

        private By tblValueEmail = By.XPath("//table[@class='k-grid-table']//tr[2]/td[3]");
        private By roleValue = By.XPath("//span[text()='Montgomery - 60222']//ancestor::tr/following-sibling::tr[1]//td[5]");
        private By oneRowRoleValue = By.XPath("//kendo-grid-list//tr//td[5]");
        private By tblValueName = By.XPath("//table[@class='k-grid-table']//tr[2]/td[2]/a");
        private By tblValueTestName = By.XPath("//table[@class='k-grid-table']//tr[2]/td[2]/a[contains(text(),'Account')]");
        private By userManagement_UserHeader = By.XPath("//th[@role='columnheader']//span[text()='User']");
        private By userManagement_UtilityHeader = By.XPath("//th[@role='columnheader']//span[text()='Utility']");
        private By userManagement_EmailAddressHeader = By.XPath("//th[@role='columnheader']//span[text()='Email Address']");
        private By userManagement_StatusHeader = By.XPath("//th[@role='columnheader']//span[text()='Status']");
        private By userManagement_RoleHeader = By.XPath("//th[@role='columnheader']//span[text()='Role']");
        private By tblValueStatus = By.XPath("//table[@class='k-grid-table']//tr[2]/td[4]");
        private By tblValueRole = By.XPath("//table[@class='k-grid-table']//tr[2]/td[5]");
        private By lblErrorMsgEmail = By.XPath("//div[text()='Please enter an Email Address.']");
        private By lblErrorMsgRole = By.XPath("//div[text()='Role is required']");
        private By lblAnyUtilityErrorMsgRole = By.XPath("//div[text()='Please select a Role for each Utility']");
        private By lblErrorMsgUtility = By.XPath("//div[text()='Please Select a Utility']");
        private By lblInvalidEmail = By.XPath("//div[text()='This Email Address is invalid. Please enter another.']");
        private By lblEmailExists = By.XPath("//div[text()='This Email Address already exists. Please enter another.']");
        private By lblEnterEmail = By.XPath("//div[2]/div/div[1]/div[4]/div/div/div/div");
        private By popUpMessage = By.Id("toast-container");
        private By cnfPopUpUserUpdated = By.XPath("//span[contains(text(), 'User has been Updated']");
        private By lblNoResultsFound = By.XPath("//span[text() = 'No Results Found']");
        private By txtUserSearch = By.Id("txtAccountSearch");
        private By btnEdit = By.XPath("//button[text()='Edit']");
        private By txtEditFirstName = By.XPath("//input[@formcontrolname='firstName']");
        private By txtEditLastName = By.XPath("//input[@formcontrolname='lastName']");
        private By txtEditEmail = By.XPath("//input[@formcontrolname='email']");
        private By lstStatusActive = By.XPath("//kendo-list/div/ul/li[1]");
        private By lstStatusInactive = By.XPath("//kendo-list/div/ul/li[2]");
        private By lstStatusLocked = By.XPath("//kendo-list/div/ul/li[3]");
        private By btnEditSave = By.XPath("//button[text()='Save']");
        private By msgDecativeUsers = By.XPath("//label[text()='Status']/../div[2]/div/div");
        private By btnSendPwdReset = By.XPath("//button[text()='Send Password Reset']");
        private By msgSendPwdReset = By.XPath("//span[contains(text(), 'A Password Reset Email has been sent')]");
        private By drplftStatus = By.XPath("//kendo-dropdownlist[@formcontrolname='statusId']");
        private By drplftStatusSelected = By.XPath("//kendo-dropdownlist[@id='drpUsers']//span[@class='k-input-value-text']");
        private By tblLandingUserList = By.ClassName("k-grid-container");
        private By lstUser = By.XPath("//kendo-grid-list//tr[1]");
        private By tblLftNavUserList = By.ClassName("k-grid-table");
        private By lblDisplayUserName = By.XPath("//div[@class='user-display-name']");
        private By lblDisplayEmail = By.XPath("//label[text()='Email Address']");
        private By lblDisplayStatus = By.XPath("//label[text()='Status']");
        private By lblDisplayRole = By.XPath("//label[text()='Role']");
        private By btnSelectFilter = By.XPath("//button[@class='k-button k-primary filter-button']");
        private By drpFilterRole = By.Id("drpRoleSearch");
        private By drpFilterStatus = By.Id("drpStatusSearch");
        private By btnFilterClear = By.XPath("//button[text()='Clear']");
        private By btnFilter = By.XPath("//button[text()='Clear']/preceding-sibling::button[text()='Filter']");
        private By txtFnameGridCol = By.Id("txtFullNameSearch");
        private By txtUtilitySearchGridCol = By.Id("txtUtilitySearch");
        private By lblUtilityName = By.XPath("//sd-menu/ul/li[1]");
        private By headerUser = By.XPath("//th[@aria-colindex='1']");
        private By hearderEmail = By.XPath("//th[@aria-colindex='2']");
        private By headerStatus = By.XPath("//th[@aria-colindex='3']");
        private By headerRole = By.XPath("//th[@aria-colindex='4']");
        private By lblUserUtility = By.ClassName("user-utility");
        private By tblUsersList = By.XPath("//sd-users-list");
        private By sdkAccess = By.Id("chkSDKAccessToggle");

        private By searchPartner = By.XPath("//kendo-searchbar/input");
        private By drpDownRole = By.XPath("//div[2]/div/kendo-dropdownlist/span/span");
        private By roleDrpdown = By.XPath("//td[5]/kendo-dropdownlist/span/span");
        private By neptune360partner = By.XPath("//li[contains(.,'Neptune 360 Partner')]");
        private By thirdpartyVendor = By.XPath("//span[contains(.,'3rd Party Vendor')]");
        #endregion

        /// <summary>
        /// Method to Validate Create User Fields
        /// </summary>
        public void ValidateCreateUserFields()
        {
            driver.ClickElement(btnCreateLanding, "Create");
            //driver.ClickElement(lstUser, "Select User");
            driver.CheckElementExists(txtEditFirstName, "FirstName");
            driver.CheckElementExists(txtEditLastName, "LastName");
            driver.CheckElementExists(txtEditEmail, "EmailAddress");
            driver.CheckElementExists(drpStatus, "Status");
            driver.CheckElementExists(drpRole, "Role");
            driver.CheckElementExists(drpLanguage, "Language");
            driver.ClickElement(cancelBtn, "Cancel");
        }

        // <summary>
        /// Method to Validate Create User Does Not Exists
        /// </summary>
        public void ValidateCreateUserDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnCreateLanding, "Create");
        }

        /// <summary>
        /// Method to Enter Text in Create User Fields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="text"></param>
        public void EnterTextInCreateUserFields(string firstName, string lastName, string email, string text)
        {
            driver.ClickElement(btnCreateLanding, "Create");
            driver.SendKeysToElement(txtEditFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtEditLastName, lastName, "LastName");
            driver.SendKeysToElement(txtEditEmail, email, "EmailAddress");
            driver.ClickElement(drpRole, "Role");
            SelectRoleOption(text);
        }

        /// <summary>
        /// Method to Enter Text in Create User Fields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="text"></param>
        public void CreateUserFields(string firstName, string lastName, string email, string text)
        {
            driver.SendKeysToElement(txtEditFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtEditLastName, lastName, "LastName");
            driver.SendKeysToElement(txtEditEmail, email, "EmailAddress");
            driver.ClickElement(drpRole, "Role");
            SelectRoleOption(text);
            driver.ClickElement(btnEditSave, "Save");
            driver.sleepTime(5000);
        }

        /// <summary>
        /// Method to Select Role Option
        /// </summary>
        /// <param name="text"></param>
        public void SelectRoleOption(string text)
        {
            switch (text.ToUpper())
            {
                case "NEPTUNE CUSTOMER SERVICE REP":
                    driver.ClickElement(ddlRoleCustServOption, "Neptune Customer Service Rep");
                    break;

                case "NEPTUNE FIELD SERVICE PM":
                    driver.ClickElement(ddlRoleFieldServOption, "Neptune Field Service PM");
                    break;

                case "NEPTUNE SYSTEM ADMINISTRATOR":
                    driver.ClickElement(ddlRoleSysAdminOption, "Neptune System Administrator");
                    break;
                case "UTILITY ADMINISTRATOR":
                    driver.ClickElement(ddlRoleUtilityAdminOption, "Utility Administrator");
                    break;
                case "UTILITY READ ONLY ACCESS":
                    driver.ClickElement(ddlRoleUtilityReadOption, "Utility Read Only Access");
                    break;
                case "UTILITY USER":
                    driver.ClickElement(ddlRoleUtilityUserOption, "Utility User");
                    break;
                case "UTILITY METER READER":
                    driver.ClickElement(ddlRoleUtilityMeterReaderOption, "Utility Meter Reader");
                    break;
                case "NEPTUNE CUSTOMER SUPPORT":
                    driver.ClickElement(ddlRoleNeptuneCustomerSupportOption, "Neptune Customer Support");
                    break;
            }
        }

        /// <summary>
        /// Method to Validate Single Utility Create User Fields
        /// </summary>
        public void ValidateSingleUtilityCreateUserFields()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementExists(txtEditFirstName, "FirstName");
            driver.CheckElementExists(txtEditLastName, "LastName");
            driver.CheckElementExists(txtEditEmail, "EmailAddress");
            driver.CheckElementExists(drpSingleUserRole, "Role");
            driver.CheckElementExists(btnSave, "Save");
            driver.CheckElementExists(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }
        /// <summary>
        /// Method to Enter Text in Create User Fields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void CreateSingleUtilityUserFields(string firstName, string lastName, string email, string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtEditFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtEditLastName, lastName, "LastName");
            driver.SendKeysToElement(txtEditEmail, email, "EmailAddress");
            driver.ClickElement(drpSingleUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Search User with Email Address
        /// </summary>
        /// <param name="email"></param>
        public void ValidateSearchUserWithEmail(string email)
        {
            
            driver.sleepTime(10000);
            string value = "";
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "EmailAddress");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(10000);
            value = driver.GetElementText(tblValueEmail);
            if (value.Contains(email))
                testReport.Pass("Single User Created Successsfully with Email Address: <mark>" + value + "</mark>");
            else
                ReporterFactory.LogFailure("Single User not Created Successsfully with Email Address: <mark>" + value + "</mark>");
        }

        /// <summary>
        /// Method to Validate Search User with Name Empty
        /// </summary>
        /// <param name="email"></param>
        public void ValidateSearchUserWithNameEmpty(string email)
        {
            string name = "";
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "EmailAddress");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            name = driver.GetElementText(tblValueName);
            if (name.Contains(""))
            {
                testReport.Pass("Single User Created Successsfully without First and Last Name: <mark>" + name + "</mark>");
            }
            else
            {
                ReporterFactory.LogFailure("Single User not Created Successsfully without First and Last Name: <mark>" + name + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Single Utility Default Creation Date
        /// </summary>
        public void ValidateSingleUtilityDefaultCreationDate()
        {
            string createDate = "";
            driver.ClickElement(btnCreate, "Create");
            createDate = driver.GetElementAttribute(lftLblCreateDate, "value");

            if (createDate.Contains(DateTime.Now.ToString("dd yyyy")))
            {
                testReport.Pass("Create Date field is pre-populated with Today's Date: <mark>" + createDate + "</mark>");
            }
            else
            {
                ReporterFactory.LogFailure("Create Date field is not pre-populated with Today's Date: <mark>" + createDate + "</mark>");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Single Utility Required Fields Message
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void ValidateSingleUtilityRequiredFieldsMessage(string firstName, string lastName)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtEditFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtEditLastName, lastName, "LastName");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblErrorMsgEmail, "EmailAddress");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "gabbar125@gmail.com", "Email");
            driver.SendKeysToElement(txtSearchUtility, "12345", "Search Utility");
            driver.FindElement(lstSearchUtilityTest).Click();
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblAnyUtilityErrorMsgRole, "Role");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Single Utility Status Field Disabled
        /// </summary>
        public void ValidateSingleUtilityStatusFieldDisabled()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDoesnotExists(drpStatus, "Status");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Status  Field is Active
        /// </summary>
        public void ValidateStatusFieldActive()
        {
            string status = "";
            status = driver.GetElementText(tblValueStatus);
            if (status.Contains("Active"))
                testReport.Pass("Status Field Default Value is set to : <mark>" + status + "</mark>");
            else
                ReporterFactory.LogFailure("Status Field Default Value is not Active and is set to : <mark>" + status + "</mark>");
        }

        /// <summary>
        /// Method to Validate Max Char Length for Single Utility Create User Fields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public void ValidateMaxCharLengthForSingleUtilityCreateUserFields(string firstName, string lastName, string email)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtEditFirstName, firstName, "FirstName");

            string fName = driver.GetElementAttribute(txtEditFirstName, "value");
            if (fName.Length == 32)
                testReport.Pass("Max number of characters accepted for First Name is 32 <mark>" + fName + "</mark>");
            else
                ReporterFactory.LogFailure("Max number of characters accepted for First Name is lessthan 32 <mark>" + fName + "</mark>");

            driver.SendKeysToElement(txtEditLastName, lastName, "LastName");
            string lName = driver.GetElementAttribute(txtEditLastName, "value");
            if (lName.Length == 32)
                testReport.Pass("Max number of characters accepted for Last Name is 32 <mark>" + lName + "</mark>");
            else
                ReporterFactory.LogFailure("Max number of characters accepted for Last Name is lessthan 32 <mark>" + lName + "</mark>");

            driver.SendKeysToElement(txtEditEmail, email, "Email");
            string valEmail = driver.GetElementAttribute(txtEditEmail, "value");
            if (valEmail.Length == 128)
                testReport.Pass("Max number of characters accepted for Email is 128 <mark>" + valEmail + "</mark>");
            else
                ReporterFactory.LogFailure("Max number of characters accepted for Email is lessthan 128 <mark>" + valEmail + "</mark>");
        }

        /// <summary>
        /// Method to Validate Alpha Numeric Chars Accepted for Single Utility Create User Fields
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateAlphaNumericCharsForSingleUtilityCreateUserFields(string roleOption)
        {
            driver.SendKeysToElementClearFirst(txtEditFirstName, "CD12", "FirstName");
            driver.SendKeysToElementClearFirst(txtEditLastName, "HJ45", "LastName");
            driver.SendKeysToElementClearFirst(txtEditEmail, "sgtyh125@gmail.com", "Email");
            driver.ClickElement(drpSingleUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Special Chars Entered Accepted for Single Utility Create User Fields
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateSpecialCharsSingleUtilityCreateUserFields(string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtEditFirstName, "!@#$&&", "FirstName");
            driver.SendKeysToElement(txtEditLastName, "#$%#&", "LastName");
            driver.SendKeysToElement(txtEditEmail, "u.k@gmail.com", "Email");
            driver.ClickElement(drpSingleUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Special Chars Not Allowed for Email Field
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateSpecialCharsForEmailNASingleUtility(string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtEditFirstName, "Test", "FirstName");
            driver.SendKeysToElement(txtEditLastName, "TestEnv", "LastName");
            driver.SendKeysToElement(txtEditEmail, "#%^&@gmail.com", "Email");
            driver.ClickElement(drpSingleUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblInvalidEmail, "Email Address Invalid");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Email Messaging for Single Utility
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateEmailMessagingSingleUtility(string firstName, string lastName, string email, string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtEditFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtEditLastName, lastName, "LastName");
            driver.SendKeysToElement(txtEditEmail, "test1.com", "Email");
            driver.ClickElement(drpSingleUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblInvalidEmail, "Email Address Invalid");
            driver.SendKeysToElementClearFirst(txtEditEmail, email, "Email");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblEmailExists, "Email Already Exists");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Confirmation Pop-up after User Creation
        /// </summary>
        public void ValidateCreateUserConfirmationPopup()
        {
            driver.WaitForElement(popUpMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementExists(popUpMessage, "User Added Pop-up Display");
        }

        /// <summary>
        /// Method to Validate Confirmation Pop-up after User Creation
        /// </summary>
        public void ValidateUpdateUserConfirmationPopup()
        {
            driver.WaitForElement(popUpMessage, TimeSpan.FromSeconds(10));
            driver.CheckElementExists(popUpMessage, "User Updated Pop-up Display");
        }

        /// <summary>
        /// Method to Validate Single Utility Create User Ability to Cancel
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateSingleUtilityCreateUserAbilityToCancel(string firstName, string lastName, string email, string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtEditFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtEditLastName, lastName, "LastName");
            driver.SendKeysToElement(txtEditEmail, email, "EmailAddress");
            driver.SendKeysToElement(txtSearchUtility, "12345", "Search Utility");
            driver.FindElement(lstSearchUtilityTest).Click();
            driver.ClickElement(drpRolesList, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Search User with Email Address
        /// </summary>
        /// <param name="email"></param>
        public void ValidateNoUserDisplayOnUserList(string email)
        {
            driver.SendKeysToElement(txtSearchEmailAddress, email, "EmailAddress");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.CheckElementExists(lblNoResultsFound, "No Results Found");
        }

        /// <summary>
        /// Method to Validate Create button displayed on User Management
        /// </summary>
        public void ValidateCreateBtnUserManagementDisplay()
        {
            driver.CheckElementExists(btnCreate, "Create");
        }

        /// <summary>
        /// Method to Validate any Utility User Fields on User Management
        /// </summary>
        public void ValidateAnyUtilityUserFields()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementExists(lftLblCreateDate, "Create Date");
            driver.CheckElementExists(txtFirstName, "FirstName");
            driver.CheckElementExists(txtLastName, "LastName");
            driver.CheckElementExists(txtEmailAddress, "Email");
            driver.CheckElementExists(searchPartner, "Search Utility");
            driver.CheckElementExists(lblAssignUtility, "Assign Utility");
            driver.CheckElementExists(btnSave, "Save");
            driver.CheckElementExists(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Any Utility Default Creation Date
        /// </summary>
        public void ValidateAnyUtilityDefaultCreationDate()
        {
            string createDate = "";
            driver.ClickElement(btnCreate, "Create");
            createDate = driver.GetElementAttribute(lftLblCreateDate, "value");

            if (createDate.Contains(System.DateTime.Now.ToString("dd yyyy")))
            {
                testReport.Pass("Create Date field is pre-populated with Today's Date: <mark>" + createDate + "</mark>");
            }
            else
            {
                ReporterFactory.LogFailure("Create Date field is not pre-populated with Today's Date: <mark>" + createDate + "</mark>");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Any Utility Required Fields Message
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public void ValidateAnyUtilityRequiredFieldsMessage(string firstName, string lastName, string email)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtLastName, lastName, "LastName");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblErrorMsgEmail, "EmailAddress");
            driver.SendKeysToElement(txtEmailAddress, email, "EmailAddress");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblErrorMsgUtility, "Search Utility");
            driver.SendKeysToElement(lftTxtSearchUtility, "SQA Automation RTesting", "Search Utility");
            driver.ClickElement(lstSearchUtilityAtlanta, "List Value for Search Utility");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblAnyUtilityErrorMsgRole, "Role");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Enter Text in Create User Fields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void CreateAnyUtilityUserFields(string firstName, string lastName, string email, string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtLastName, lastName, "LastName");
            driver.SendKeysToElement(txtEmailAddress, email, "EmailAddress");
            driver.SendKeysToElement(txtSearchUtility, "12345", "Search Utility");
            driver.FindElement(lstSearchUtilityTest).Click();
            driver.ClickElement(drpRolesList, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Any Utility Status Field Disabled
        /// </summary>
        public void ValidateAnyUtilityStatusFieldDisabled()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDoesnotExists(drpStatus, "Status");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Any Utility to Search Utility
        /// </summary>
        public void ValidateAnyUtilityAbilityToSearchUtility(string utilityName)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtSearchUtility, "12345", "Search Utility");
            driver.CheckElementExists(lstSearchUtilityTest, "Test12345");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Any Utility to Search Utility and able to Select Utility
        /// </summary>
        public void ValidateAnyUtilityAbilityToSelectUtility()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtSearchUtility, "12345", "Search Utility");
            driver.CheckElementExists(lstSearchUtilityTest, "Test12345");
            driver.ClickElement(utilityAddBtn, "Add button");
            if (!(driver.GetElementText(lblUserUtility) == "Test12345"))
            {
                ReporterFactory.LogFailure("Unable to add the utility by clicking on Add button");
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Any Utility to Search Utility and able to Select Utility and to Select Role
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateAnyUtilitySelectUtilitySelectRole(string roleOption, string utilityName)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtSearchUtility, "12345", "Search Utility");
            driver.CheckElementExists(lstSearchUtilityTest, "Test12345");
            driver.ClickElement(utilityAddBtn, "Add button");
            if (!(driver.GetElementText(lblUserUtility) == "Test12345"))
            {
                ReporterFactory.LogFailure("Unable to add the utility by clicking on Add button");
            }
            driver.ClickElement(drpRolesList, "Role");           
            SelectRoleOption(roleOption);

            if (!(driver.GetElementText(selectedUserRole) == "Neptune System Administrator"))
            {
                ReporterFactory.LogFailure("Unable to select the User Role in Create new user");
            }

            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Any Utility Select Multiple Utilities and Roles
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateAnyUtilitySelectMultipleUtilitiesRoles(string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(lftTxtSearchUtility, "SQA Automation RTesting", "Search Utility");
            driver.ClickElement(lstSearchUtilityAtlanta, "SQA Automation RTesting");
            driver.SendKeysToElement(lftTxtSearchUtility, "V4 Test", "Search Utility");
            driver.ClickElement(lstSearchUtilityDemo, "V4 Test");
            IReadOnlyCollection<IWebElement> elements = driver.FindElements(lftdrpUserRole);
            foreach (var item in elements)
            {
                if (item.TagName == "span")
                    continue;
                item.Click();
                SelectRoleOption(roleOption);
            }
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Search User All Fields
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateSearchUserAllFields(string name, string email, string roleOption)
        {
            string value = "";
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "EmailAddress");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            value = driver.GetElementText(tblValueName);
            if (value.Contains(name))
                testReport.Pass("User is displayed with User Name: <mark>" + value + "</mark>");
            else
                ReporterFactory.LogFailure("User is not displayed with User Name: <mark>" + value + "</mark>");
            value = driver.GetElementText(tblValueEmail);
            if (value.Contains(email))
                testReport.Pass("User is displayed with Email Address: <mark>" + value + "</mark>");
            else
                ReporterFactory.LogFailure("User is not displayed with Email Address: <mark>" + value + "</mark>");
            value = driver.GetElementText(tblValueStatus);
            if (value.Contains("Active"))
                testReport.Pass("Created User is displayed with Status Active");
            else
                ReporterFactory.LogFailure("Created User is not displayed with Status Active, displayed Status: <mark>" + value + "</mark>");
            driver.WaitForElement(tblValueRole, TimeSpan.FromSeconds(5));
            value = driver.GetElementText(tblValueRole);
            if (value.Contains(roleOption))
                testReport.Pass("User is displayed with Assigned Role: <mark>" + value + "</mark>");
            else
                ReporterFactory.LogFailure("User is not displayed with Assigned Role: <mark>" + value + "</mark>");
        }

        /// <summary>
        /// Method to Validate Max Char Length for Any Utility Create User Fields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public void ValidateMaxCharLengthForAnyUtilityCreateUserFields(string firstName, string lastName, string email)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElementClearFirst(txtFirstName, firstName, "FirstName");
            string fName = driver.GetElementAttribute(txtFirstName, "value");
            if (fName.Length == 32)
                testReport.Pass("Max number of characters accepted for First Name is 32 <mark>" + fName + "</mark>");
            else
                ReporterFactory.LogFailure("Max number of characters accepted for First Name is lessthan 32 <mark>" + fName + "</mark>");

            driver.SendKeysToElementClearFirst(txtLastName, lastName, "LastName");
            string lName = driver.GetElementAttribute(txtLastName, "value");
            if (lName.Length == 32)
                testReport.Pass("Max number of characters accepted for First Name is 32 <mark>" + lName + "</mark>");
            else
                ReporterFactory.LogFailure("Max number of characters accepted for First Name is lessthan 32 <mark>" + lName + "</mark>");

            driver.SendKeysToElementClearFirst(txtEmailAddress, email, "Email");
            string valEmail = driver.GetElementAttribute(txtEmailAddress, "value");
            if (valEmail.Length == 128)
                testReport.Pass("Max number of characters accepted for Email is 128 <mark>" + valEmail + "</mark>");
            else
                ReporterFactory.LogFailure("Max number of characters accepted for First Name is lessthan 128 <mark>" + valEmail + "</mark>");
        }

        /// <summary>
        /// Method to Validate Alpha Numeric Chars Accepted for Create User Fields
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateAlphaNumericCharsForAnyUtilityCreateUserFields(string roleOption)
        {
            driver.SendKeysToElementClearFirst(txtFirstName, "Ac12", "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, "BQ45", "LastName");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "gabbar125@gmail.com", "Email");
            driver.SendKeysToElement(lftTxtSearchUtility, "SQA Automation RTesting", "Search Utility");
            driver.ClickElement(lstSearchUtilityAtlanta, "SQA Automation RTesting");
            driver.ClickElement(lftdrpUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Special Chars Entered Accepted for Any UtilityCreate User Fields
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateSpecialCharsAnyUtilityCreateUserFields(string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElementClearFirst(txtFirstName, "!@#$*&", "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, "#$%^&", "LastName");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "a.@gmail.com", "Email");
            driver.SendKeysToElementClearFirst(lftTxtSearchUtility, "SQA Automation RTesting", "Search Utility");
            driver.ClickElement(lstSearchUtilityAtlanta, "SQA Automation RTesting");
            driver.ClickElement(lftdrpUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Special Chars for Any Utility Not Allowed for Email Field
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateSpecialCharsAnyUtilityForEmailNA(string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElementClearFirst(txtFirstName, "Test", "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, "TestEnv", "LastName");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "#%%^&@gmail.com", "Email");
            driver.SendKeysToElementClearFirst(lftTxtSearchUtility, "SQA Automation RTesting", "Search Utility");
            driver.ClickElement(lstSearchUtilityAtlanta, "SQA Automation RTesting");
            driver.ClickElement(lftdrpUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblInvalidEmail, "Invalid Email Address");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Email Messaging Already Exists for Any Utility
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateEmailMessagingAlreadyExistsForAnyUtility(string firstName, string lastName, string email, string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElementClearFirst(txtFirstName, firstName, "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, lastName, "LastName");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "test1.com", "EmailAddress");
            driver.SendKeysToElementClearFirst(lftTxtSearchUtility, "SQA Automation RTesting", "Search Utility");
            driver.ClickElement(lstSearchUtilityAtlanta, "SQA Automation RTesting");
            driver.ClickElement(lftdrpUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblInvalidEmail, "Invalid Email");
            driver.SendKeysToElementClearFirst(txtEmailAddress, email, roleOption);
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblEmailExists, "Email Already Exists");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Create User Ability to Cancel
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateAnyUtilityCreateUserAbilityToCancel(string firstName, string lastName, string email, string roleOption)
        {
            driver.ClickElement(btnCreate, "Create");
            driver.SendKeysToElement(txtFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtLastName, lastName, "LastName");
            driver.SendKeysToElement(txtEmailAddress, email, "EmailAddress");
            driver.SendKeysToElement(lftTxtSearchUtility, "SQA Automation RTesting", "Search Utility");
            driver.ClickElement(lstSearchUtilityAtlanta, "SQA Automation RTesting");
            driver.ClickElement(lftdrpUserRole, "Role");
            //driver.ClickElement(By.XPath("//div/ul/li[5]"), "Register Type");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Search User Account
        /// </summary>
        /// <param name="user"></param>
        public void ValidateSearchUserAccount(string user)
        {
            driver.SendKeysToElement(txtUserSearch, user, "User Account");
            driver.SendKeysToElement(txtUserSearch, Keys.Enter, "User Account");
            driver.sleepTime(5000);
        }

        /// <summary>
        /// Method to Validate Edit User and Save
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateEditUser(string firstName, string lastName, string email, string roleOption)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(txtEditFirstName, firstName, "FirstName");
            driver.SendKeysToElementClearFirst(txtEditLastName, lastName, "LastName");
            driver.SendKeysToElementClearFirst(txtEditEmail, email, "Email");
            driver.ClickElement(drpStatus, "Status");
            driver.ClickElement(lstStatusActive, "Active");
            driver.ClickElement(drpRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnEditSave, "Save");
        }

        /// <summary>
        /// Method to Validate Edit Error Message Validation
        /// </summary>
        /// <param name="email"></param>
        public void ValidateEditErrorMessageValidation(string email)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.SendKeysToElementClearFirst(txtEditEmail, "test.com", "Email");
            driver.ClickElement(btnEditSave, "Save");
            driver.CheckElementExists(lblInvalidEmail, "Email Invalid");
            driver.SendKeysToElementClearFirst(txtEditEmail, email, "Email");
            driver.ClickElement(btnEditSave, "Save");

        }

        /// <summary>
        /// Method to Validate Password Reset Message
        /// </summary>
        public void ValidatePasswordResetMessage()
        {
            driver.ClickElement(btnSendPwdReset, "SendPasswordReset");
            driver.CheckElementExists(msgSendPwdReset, "Password Reset Message");
        }

        /// <summary>
        /// Method to Validate Left Navigation Edit User Status Active to Inactive
        /// </summary>
        /// <param name="email"></param>
        public void ValidateLftNavEditUserStatusActiveToInactive(string email)
        {
            string expectedStatus;
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "EmailAddress");
            driver.ClickElement(SearchEmailAddress, "Search Email Address");
            driver.WaitForElement(tblValueTestName, TimeSpan.FromSeconds(30));
            driver.ClickElement(tblValueTestName, "Select User");
            driver.ClickElement(drplftStatus, "Status");

            if (driver.GetElementText(drplftStatusSelected) == "Active")
            {
                expectedStatus = "Inactive";

                driver.ClickElement(lstStatusInactive, "Inactive");
            }
            else
            {
                expectedStatus = "Active";
                driver.ClickElement(lstStatusActive, "Active");
            }

            driver.ClickElement(btnSave, "Save");
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "EmailAddress");
            driver.ClickElement(SearchEmailAddress, "Search Email Address");

            driver.sleepTime(5000);
            string value = driver.GetElementText(tblValueStatus);
            if (value.Contains(expectedStatus))
                testReport.Pass("Corresponding User status is changed from Active to Inactive");
            else
                ReporterFactory.LogFailure("Corresponding User status is not changed from Active to Inactive");
        }

        /// <summary>
        /// Method to Validate Left Navigation Edit User Status Inactive to Active
        /// </summary>
        /// <param name="email"></param>
        public void ValidateLftNavEditUserStatusInactiveToActive(string email)
        {
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "EmailAddress");
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "Select User");
            driver.ClickElement(drplftStatus, "Status");
            driver.ClickElement(lstStatusActive, "Active");
            driver.ClickElement(btnSave, "Save");
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "EmailAddress");
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            string value = driver.GetElementText(tblValueStatus);
            if (value.Contains("Active"))
                testReport.Pass("Corresponding User status is changed from Inactive to Active");
            else
                ReporterFactory.LogFailure("Corresponding User status is not changed from Inactive to Active");
        }

        /// <summary>
        /// Method to Validate Landing Page Edit User Status Active to Inactive
        /// </summary>
        /// <param name="user"></param>
        public void ValidateLandPageEditUserStatusActiveToInactive(string user)
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(drpStatus, "Status");
            driver.ClickElement(lstStatusInactive, "Inactive");
            driver.ClickElement(btnEditSave, "Save");
            driver.SendKeysToElement(txtUserSearch, "", "User Account");
            driver.ClickElement(btnSelectFilter, "Filter Select");
            driver.ClickElement(drpFilterStatus, "Status");
            driver.ClickElement(lstStatusInactive, "Inactive");
            driver.ClickElement(btnFilter, "Filter");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit");
            string value = driver.GetElementText(drpStatus);
            if (value.Contains("INACTIVE"))
                testReport.Pass("Corresponding User status is changed from Active to Inactive");
            else
                ReporterFactory.LogFailure("Corresponding User status is not changed from Active to Inactive");
        }

        /// <summary>
        /// Method to Validate Landing Page Edit User Status Inactive to Active
        /// </summary>
        /// <param name="user"></param>
        public void ValidateLandPageEditUserStatusInactiveToActive(string user)
        {
            driver.ClickElement(btnSelectFilter, "Filter Select");
            driver.ClickElement(drpFilterStatus, "Status");
            driver.ClickElement(lstStatusInactive, "Inactive");
            driver.ClickElement(btnFilter, "Filter");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(drpStatus, "Status");
            driver.ClickElement(lstStatusActive, "Active");
            driver.ClickElement(btnEditSave, "Save");
            driver.ClickElement(btnSelectFilter, "Filter Select");
            driver.ClickElement(btnFilterClear, "Filter Clear");
            driver.SendKeysToElementClearFirst(txtUserSearch, user, "User Account");
            driver.SendKeysToElementClearFirst(txtUserSearch, Keys.Enter, "User Account");
            driver.sleepTime(5000);
            driver.ClickElement(btnEdit, "Edit");
            string value = driver.GetElementText(drpStatus);
            if (value.Contains("ACTIVE"))
                testReport.Pass("Corresponding User status is changed from Inactive to Active");
            else
                ReporterFactory.LogFailure("Corresponding User status is not changed from Inactive to Active");
        }

        /// <summary>
        /// Method to Validate Left Navigation Search User Field and Click User
        /// </summary>
        public void ValidateLftNavSearchUserFieldClickUser(string email)
        {
            driver.SendKeysToElement(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.CheckElementExists(tblValueName, "First Name and Last Name");
            driver.ClickElement(tblValueName, "Name");
        }

        /// <summary>
        /// Method to Validate Left Navigation User Fields
        /// </summary>
        /// <param name="email"></param>
        public void ValidateLftNavUserFields(string email)
        {
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.CheckElementExists(tblValueName, "First Name and Last Name");
            driver.ClickElement(tblValueName, "Name");
            driver.CheckElementExists(lftLblCreateDate, "Create Date");
            driver.CheckElementExists(txtFirstName, "FirstName");
            driver.CheckElementExists(txtLastName, "LastName");
            driver.CheckElementExists(txtEmailAddress, "EmailAddress");
            driver.CheckElementExists(drpSingleUserRole, "Status");
            driver.CheckElementExists(btnSave, "Save");
            driver.CheckElementExists(btnCancel, "Cancel");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate to Update Left Navigation User Fields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateToUpdateLftNavUserFields(string firstName, string lastName, string email, string roleOption)
        {
            //driver.ClickElement(tblValueName, "Name");
            driver.SendKeysToElementClearFirst(txtFirstName, firstName, "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, lastName, "LastName");
            driver.SendKeysToElementClearFirst(txtEmailAddress, email, "Email");
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Enter Email Address Message
        /// </summary>
        /// <param name="email"></param>
        public void ValidateEnterEmailAddressMessage(string email)
        {
            driver.SendKeysToElement(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "Name");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "", "Email");
            driver.SendKeysToElementClearFirst(txtEmailAddress, Keys.Backspace, "Email");
            //driver.sleepTime(5000);
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblEnterEmail, "Enter Email Address");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate User Optional Fields
        /// </summary>
        /// <param name="email"></param>
        public void ValidateUserOptionalFields(string email)
        {
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "Name");
            driver.SendKeysToElementClearFirst(txtFirstName, Keys.Tab, "FirstName");
            //driver.SendKeysToElement(txtFirstName, Keys.Backspace, "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, Keys.Tab, "LastName");
            //driver.SendKeysToElement(txtLastName, Keys.Backspace, "LastName");
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate User Update Fields
        /// </summary>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="roleOption"></param>
        public void ValidateUserUpdateFields(string firstName, string lastName, string email, string roleOption)
        {
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "Name");
            driver.SendKeysToElementClearFirst(txtFirstName, firstName, "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, lastName, "LastName");
            driver.SendKeysToElementClearFirst(txtEmailAddress, email, "EmailAddress");
            driver.ClickElement(lftdrpUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Update User Account Email Messaging
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public void ValidateUpdateUserAccountEmailMessaging(string firstName, string lastName, string email)
        {
            driver.SendKeysToElement(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "Name");
            driver.SendKeysToElementClearFirst(txtFirstName, firstName, "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, lastName, "LastName");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "test1.com", "Email");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblInvalidEmail, "Email Address Invalid");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "neptune@domain.com", "Email");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblEmailExists, "Email Already Exists");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Update User Account Cancel
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateUpadateUserAccountCancel(string firstName, string lastName, string email, string roleOption)
        {
            driver.SendKeysToElement(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "Name");
            driver.SendKeysToElementClearFirst(txtFirstName, firstName, "FirstName");
            driver.SendKeysToElementClearFirst(txtLastName, lastName, "LastName");
            driver.SendKeysToElementClearFirst(txtEmailAddress, email, "EmailAddress");
            driver.SendKeysToElementClearFirst(searchPartner, "Montgomery", "Utility Name");
            driver.ClickElement(By.XPath("//a[@id='itemlink']/span[1]"), "Utility");
            driver.ClickElement(lftdrpUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate User Accounts Grid Columns
        /// </summary>
        public void ValidateUserAccountsGridColumns()
        {
            driver.WaitForElement(userManagement_UserHeader, TimeSpan.FromSeconds(30));
            driver.CheckElementExists(userManagement_UserHeader, "UserName");
            driver.CheckElementExists(userManagement_UtilityHeader, "Utility");
            driver.CheckElementExists(userManagement_EmailAddressHeader, "Email");
            driver.CheckElementExists(userManagement_StatusHeader, "Status");
            driver.CheckElementExists(userManagement_RoleHeader, "Role");
        }

        /// <summary>
        /// Method to Validate User List Default Display
        /// </summary>
        public void ValidateLandingPageUserListDefaultDisplay()
        {
            try
            {
                string str = "";
                List<IWebElement> lstTrElem = new List<IWebElement>(driver.FindElement(tblLandingUserList).FindElements(By.TagName("tr")));
                List<string> lstUnSort = new List<string>();
                foreach (var item in lstTrElem)
                {
                    string[] value = item.Text.Split('\r');
                    if (value[0].Length > 0)
                    {
                        int i = value[0].IndexOf(" ") + 1;
                        str = value[0].Substring(i);
                    }
                    lstUnSort.Add(str);
                }
                List<string> lstSort = lstUnSort;
                lstSort.Sort();
                lstUnSort.Where(b => lstSort.Any(a => b.Equals(a)));
                testReport.Pass("Users are with default display");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                ReporterFactory.LogFailure("Users are not with default display, Error Message: <mark>" + ex + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Users List
        /// </summary>
        /// <param name="firstName"></param>
        public void ValidateUsersToUtility(string firstName)
        {
            driver.SendKeysToElement(txtUserSearch, firstName, "FirstName");
            driver.SendKeysToElement(txtUserSearch, Keys.Enter, "FirstName");
            driver.sleepTime(5000);
            driver.CheckElementExists(lblDisplayUserName, "UserName");
            driver.CheckElementExists(lblDisplayEmail, "Email");
            driver.CheckElementExists(lblDisplayStatus, "Status");
            driver.CheckElementExists(lblDisplayRole, "Role");
        }

        /// <summary>
        /// Method to Validate Users Partial Search
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public void ValidateUsersPartialSearch(string firstName, string lastName, string email)
        {
            driver.SendKeysToElementClearFirst(txtUserSearch, firstName, "FirstName");
            driver.SendKeysToElementClearFirst(txtUserSearch, Keys.Enter, "FirstName");
            driver.SendKeysToElementClearFirst(txtUserSearch, lastName, "LastName");
            driver.SendKeysToElementClearFirst(txtUserSearch, Keys.Enter, "LastName");
            driver.SendKeysToElementClearFirst(txtUserSearch, email, "Email");
            driver.SendKeysToElementClearFirst(txtUserSearch, Keys.Enter, "Email");
        }

        /// <summary>
        /// Method to Validate Users List Filter
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateUsersListFilter(string roleOption)
        {
            driver.ClickElement(btnSelectFilter, "Select Filter");
            driver.ClickElement(drpFilterRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(drpFilterStatus, "Select Status");
            driver.ClickElement(lstStatusActive, "Active");
            driver.ClickElement(btnFilter, "Filter");
            List<IWebElement> lstTrElem = new List<IWebElement>(driver.FindElement(tblLandingUserList).FindElements(By.TagName("tr")));
            foreach (var item in lstTrElem)
            {
                string[] value = item.Text.Split('\r');
                if (item.Text.Contains(roleOption))
                    testReport.Pass("User Account: <mark>" + value[0] + "</mark> Displayed assosiated with Selected Utility: <mark>" + roleOption + "</mark>");
                else
                    ReporterFactory.LogFailure("User Account: <mark>" + value[0] + "</mark> Displayed not assosiated with Selected Utility: <mark>" + roleOption + "</mark>");
            }
            driver.ClickElement(btnSelectFilter, "Select Filter");
            driver.ClickElement(btnFilterClear, "Clear");
        }

        /// <summary>
        /// Method to Validate Left Navigation Utilities Grid Columns
        /// </summary>
        public void ValidateLftNavUtilitiesGridColumns()
        {
            driver.CheckElementExists(txtFnameGridCol, "UserName");
            driver.CheckElementExists(txtUtilitySearchGridCol, "Utility");
            driver.CheckElementExists(txtSearchEmailAddress, "Email");
            driver.CheckElementExists(drpFilterStatus, "Status");
            driver.CheckElementExists(drpFilterRole, "Role");
        }

        /// <summary>
        /// Method to Validate Left Navigation Search User by Utility Name
        /// </summary>
        /// <param name="utilityName"></param>
        public void ValidateLftNavSearchUserByUtilityName()
        {
            driver.SendKeysToElement(txtUtilitySearchGridCol, "12345", "UtilityName");
            driver.SendKeysToElement(txtUtilitySearchGridCol, Keys.Enter, "UtilityName");
            driver.sleepTime(5000);
            driver.CheckElementExists(lblUtilityName, "Utility");
        }

        /// <summary>
        /// Method to Validate Left Navigation Search User by User Name
        /// </summary>
        /// <param name="userName"></param>
        public void ValidateLftNavSearchUserByUserName(string userName)
        {
            driver.SendKeysToElement(txtFnameGridCol, userName, "UserName");
            driver.SendKeysToElement(txtFnameGridCol, Keys.Enter, "UserName");
            driver.WaitForElement(tblValueName, TimeSpan.FromSeconds(30));
            driver.CheckElementDisplayed(tblValueName, "");
            //string name = driver.GetElementText(tblValueName);
            //if (name.Contains(userName))
            //    testReport.Pass("User Displayed matched with the Search Name: <mark>" + userName + "</mark>");
            //else
            //    ReporterFactory.LogFailure("User Displayed not matched with the Search Name: <mark>" + userName + "</mark>");
        }

        /// <summary>
        /// Method to Validate Left Navigation Search User by FirstName and LastName
        /// </summary>
        public void ValidateLftNavSearchUserByFNameLname(string firstName, string lastName)
        {
            string name = "";
            driver.SendKeysToElement(txtFnameGridCol, firstName, "UserName");
            driver.SendKeysToElement(txtFnameGridCol, Keys.Enter, "UserName");
            driver.sleepTime(25000);
            name = driver.GetElementText(tblValueName);
            if (name.Contains(firstName))
                testReport.Pass("User Displayed matched with the Search by FirstName: <mark>" + firstName + "</mark>");
            else
                ReporterFactory.LogFailure("User Displayed not matched with the Search by FirstName: <mark>" + firstName + "</mark>");

            driver.SendKeysToElementClearFirst(txtFnameGridCol, lastName, "UserName");
            driver.SendKeysToElement(txtFnameGridCol, Keys.Enter, "UserName");
            driver.sleepTime(25000);
            name = driver.GetElementText(tblValueName);
            if (name.Contains(lastName))
                testReport.Pass("User Displayed matched with the Search by LastName: <mark>" + lastName + "</mark>");
            else
                ReporterFactory.LogFailure("User Displayed not matched with the Search by LastName: <mark>" + lastName + "</mark>");

            driver.SendKeysToElementClearFirst(txtFnameGridCol, firstName + " " + lastName, "UserName");
            driver.SendKeysToElement(txtFnameGridCol, Keys.Enter, "UserName");
            driver.sleepTime(25000);
            name = driver.GetElementText(tblValueName);
            if (name.Contains(firstName) && name.Contains(lastName))
                testReport.Pass("User Displayed matched with the Search by FirstName and LastName: <mark>" + firstName + " " + lastName + "</mark>");
            else
                ReporterFactory.LogFailure("User Displayed not matched with the Search by FirstName and LastName: <mark>" + firstName + " " + lastName + "</mark>");
        }

        /// <summary>
        /// Method to Validate Left Navigation Search User By Email Address
        /// </summary>
        /// <param name="email"></param>
        public void ValidateLftNavSearchUserByEmailAddress(string email)
        {
            string value = "";
            driver.SendKeysToElement(txtSearchEmailAddress, email, "EmailAddress");
            driver.sleepTime(2000);

            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            //value = driver.GetElementText(tblValueEmail);
            //if (value.Contains(email))
            //    testReport.Pass("User Displayed matched with the Search by Email Address: <mark>" + email + "</mark>");
            //else
            //    ReporterFactory.LogFailure("User Displayed not matched with the Search by Email Address: <mark>" + email + "</mark>");
            driver.CheckElementDisplayed(tblValueEmail, "User");

        }

        /// <summary>
        /// Method to Validate Left Navigation Search User by Status
        /// </summary>
        public void ValidateLftNavSearchUserByStatus()
        {
            string value = "";
            driver.ClickElement(drpFilterStatus, "Status");
            driver.ClickElement(lstStatusActive, "Active");
            driver.sleepTime(5000);
            value = driver.GetElementText(tblValueStatus);
            if (value.Contains("Active"))
                testReport.Pass("Users Displayed with Status: <mark>" + value + "</mark>");
            else
                ReporterFactory.LogFailure("Users is not Displayed with Status: <mark>" + value + "</mark>");
            driver.ClickElement(drpFilterStatus, "Status");
            driver.ClickElement(lstStatusInactive, "Inactive");
            driver.sleepTime(5000);
            value = driver.GetElementText(tblValueStatus);
            if (value.Contains("Inactive"))
                testReport.Pass("Users Displayed with Status: <mark>" + value + "</mark>");
            else
                ReporterFactory.LogFailure("Users is not Displayed with Status: <mark>" + value + "</mark>");
            driver.ClickElement(drpFilterStatus, "Status");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.sleepTime(5000);
            value = driver.GetElementText(tblValueStatus);
            if (value.Contains("Locked"))
                testReport.Pass("Users Displayed with Status: <mark>" + value + "</mark>");
            else
                ReporterFactory.LogFailure("Users is not Displayed with Status: <mark>" + value + "</mark>");
        }

        /// <summary>
        /// Method to Validate Left Navigation Search User by Role
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateLftNavSearchUserByRole(string roleOption)
        {
            string value = "";
            driver.ClickElement(drpFilterRole, "Role");
            SelectRoleOption(roleOption);
            driver.sleepTime(5000);
            value = driver.GetElementText(tblValueRole);
            if (value.Contains(roleOption))
                testReport.Pass("Users Displayed with RoleOption: <mark>" + value + "</mark>");
            else
                ReporterFactory.LogFailure("Users is not Displayed with RoleOption: <mark>" + value + "</mark>");
        }

        /// <summary>
        /// Method to Select role for selected user
        /// </summary>
        /// <param name="email">Email Id</param>
        /// <param name="roleOption">Role to select</param>
        public void SelectUserRole(string email, string roleOption)
        {
            driver.WaitForElement(txtSearchEmailAddress, TimeSpan.FromSeconds(180));
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "EmailAddress");
            driver.sleepTime(2000);

            driver.ClickElement(SearchEmailAddress, "Search");

            try
            {
                if (driver.GetElementText(oneRowRoleValue, 10) != roleOption)
                {
                    driver.ClickElement(editlink, "User Link");
                    driver.ClickElement(lftdrpUserRole, "Role");
                    SelectRoleOption(roleOption);
                    driver.ClickElement(btnSave, "Save");
                }
            }
            catch (Exception ex)
            {
                if (driver.GetElementText(oneRowRoleValue, 10) != roleOption)
                {
                    driver.ClickElement(editlink, "User Link");
                    driver.ClickElement(lftdrpUserRole, "Role");
                    SelectRoleOption(roleOption);
                    driver.ClickElement(btnSave, "Save");
                }
            }
        }

        /// <summary>
        /// Method to Validate Left Navigation Search User Messaging No Results Found
        /// </summary>
        public void ValidateLftNavSearchUserMessNoResultsFound()
        {
            driver.SendKeysToElementAndPressEnter(txtFnameGridCol, EngineSetup.GetRandomString(), "UserName");
            //driver.SendKeysToElement(txtFnameGridCol, Keys.Enter, "UserName");
            driver.WaitForElement(lblNoResultsFound, TimeSpan.FromSeconds(30));
            driver.CheckElementExists(lblNoResultsFound, "No Results Found");
        }

        /// <summary>
        /// Method to Validate Left Navigation Search Users to Search Partial Search
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="email"></param>
        public void ValidateLftNavSearchUserstoSearchPartial(string firstName, string email)
        {
            ValidateLftNavSearchUserByUserName(firstName);
            ValidateLftNavSearchUserByUtilityName();
            ValidateLftNavSearchUserByEmailAddress(email);
        }

        /// <summary>
        /// Method to Validate Search User to Sort each column Ascending and Descending order
        /// </summary>
        public void ValidateSearchUserToSortEachColAscDesc()
        {
            try
            {
                string name = "", email = "", status = "", role = "";
                #region Validation for Ascending
                driver.ClickElement(headerUser, "User&Utility");
                List<IWebElement> lstTrElem = new List<IWebElement>(driver.FindElement(tblLftNavUserList).FindElements(By.TagName("tr")));
                List<string> lstUserUtility = new List<string>();
                List<string> lstEmail = new List<string>();
                List<string> lstStatus = new List<string>();
                List<string> lstRole = new List<string>();
                foreach (var item in lstTrElem)
                {
                    //if (item.Text.Contains("\r"))
                    //    continue;
                    string[] value = item.Text.Split(' ');
                    foreach (var str in value)
                    {
                        if (str.Contains("@") && str.Contains("."))
                            email = str;
                        else if (str.Contains("Active") || str.Contains("Inactive") || str.Contains("Locked"))
                            status = str;
                        else if (email.Length == 0)
                            name = name + " " + str;
                        if (str == "Active" || str == "Inactive" || str == "Locked")
                            role = item.Text.Substring(item.Text.IndexOf(str) + str.Length);
                    }

                    lstUserUtility.Add(name);
                    lstEmail.Add(email);
                    lstStatus.Add(status);
                    lstRole.Add(role);
                }
                List<string> lstSortUser = lstUserUtility;
                lstSortUser.Sort();
                lstUserUtility.Where(b => lstSortUser.Any(a => b.Equals(a)));
                testReport.Pass("All User records under each Utility are sorted in ascending order of the User Name");

                driver.ClickElement(hearderEmail, "Email");
                List<string> lstSortEmail = lstEmail;
                lstSortEmail.Sort();
                lstEmail.Where(b => lstSortEmail.Any(a => b.Equals(a)));
                testReport.Pass("All User records under each Utility are sorted in ascending order of the Email Address");

                driver.ClickElement(headerStatus, "Status");
                List<string> lstSortStatus = lstStatus;
                lstSortStatus.Sort();
                lstStatus.Where(b => lstSortStatus.Any(a => b.Equals(a)));
                testReport.Pass("All User records under each Utility are sorted in ascending order of the Status");

                driver.ClickElement(headerRole, "Role");
                List<string> lstSortRole = lstRole;
                lstSortRole.Sort();
                lstRole.Where(b => lstSortRole.Any(a => b.Equals(a)));
                testReport.Pass("All User records under each Utility are sorted in ascending order of the Role");
                #endregion

                #region Clear Lists
                lstTrElem.Clear();
                lstUserUtility.Clear();
                lstEmail.Clear();
                lstStatus.Clear();
                lstRole.Clear();
                #endregion

                #region Validation for Decending
                driver.ClickElement(headerUser, "User&Utility");
                lstTrElem = new List<IWebElement>(driver.FindElement(tblLftNavUserList).FindElements(By.TagName("tr")));
                foreach (var item in lstTrElem)
                {
                    //if (item.Text.Contains("\r"))
                    //    continue;
                    string[] value = item.Text.Split(' ');
                    foreach (var str in value)
                    {
                        if (str.Contains("@") && str.Contains("."))
                            email = str;
                        else if (str.Contains("Active") || str.Contains("Inactive") || str.Contains("Locked"))
                            status = str;
                        else if (email.Length == 0)
                            name = name + " " + str;
                        if (str == "Active" || str == "Inactive" || str == "Locked")
                            role = item.Text.Substring(item.Text.IndexOf(str) + str.Length);
                    }
                    lstUserUtility.Add(name);
                    lstEmail.Add(email);
                    lstStatus.Add(status);
                    lstRole.Add(role);
                }

                lstSortUser.Reverse();
                lstUserUtility.Where(b => lstSortUser.Any(a => b.Equals(a)));
                testReport.Pass("All User records under each Utility are sorted in descending order of the User Name");

                lstSortEmail.Reverse();
                lstEmail.Where(b => lstSortEmail.Any(a => b.Equals(a)));
                testReport.Pass("All User records under each Utility are sorted in descending order of the Email Address");

                lstSortStatus.Reverse();
                lstStatus.Where(b => lstSortStatus.Any(a => b.Equals(a)));
                testReport.Pass("All User records under each Utility are sorted in descending order of the Status");

                lstSortRole.Reverse();
                lstRole.Where(b => lstSortRole.Any(a => b.Equals(a)));
                testReport.Pass("All User records under each Utility are sorted in descending order of the Role");
                #endregion
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("All Users are failed to Sort Each column, Error Message: <mark>" + ex + "</mark>");
            }
        }

        /// <summary>
        /// Method to Validate Search Results
        /// </summary>
        public void ValidateSearchResults()
        {
            driver.CheckElementExists(tblLftNavUserList, "User List");
        }

        /// <summary>
        /// Method to Validate Update Additional Utilities and Roles
        /// </summary>
        /// <param name="roleOption"></param>
        public void ValidateUpdateAdditionalUtilities(string roleOption)
        {
            driver.SendKeysToElement(lftTxtSearchUtility, "SQA Automation RTesting", "Search Utility");
            driver.ClickElement(lstSearchUtilityAtlanta, "SQA Automation RTesting");
            driver.SendKeysToElement(lftTxtSearchUtility, "Demo34711", "Search Utility");
            driver.ClickElement(lstSearchUtilityDemo, "Demo34711");
            IReadOnlyCollection<IWebElement> elements = driver.FindElements(lftdrpUserRole);
            foreach (var item in elements)
            {
                if (item.TagName == "span")
                    continue;
                item.Click();
                SelectRoleOption(roleOption);
            }
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Left Navigation User Accpunt Update Role
        /// </summary>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateLftNavUserAccountUpdateRole(string email, string roleOption)
        {
            driver.ClickElement(lftdrpUserRole, "Role");
            driver.ClickElement(ddlRoleUtilityRemove, "Remove");
            driver.ClickElement(lftdrpUserRole, "Role");
            SelectRoleOption(roleOption);
            driver.ClickElement(btnSave, "Save");
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            string value = driver.GetElementText(tblValueRole);
            if (value.Contains(roleOption))
                testReport.Pass("User is NOT displayed on the Utility where his/her role access has been removed and Updated User is displayed under the Utility where he/she is assigned");
            else
                ReporterFactory.LogFailure("User is displayed on the Utility where his/her role access has been removed and Updated User is not displayed under the Utility where he/she is assigned");
        }

        /// <summary>
        /// Method to Validate Left Navigation Update Email Messaging
        /// </summary>
        /// <param name="email"></param>
        public void ValidateLftNavUserAccountUpdateEmailMessaging(string email)
        {
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, "Test11@gmail.com", "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "Name");
            driver.SendKeysToElementClearFirst(txtEmailAddress, "test1.com", "Email");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblInvalidEmail, "Email Address Invalid");
            driver.SendKeysToElementClearFirst(txtEmailAddress, email, "Email");
            driver.ClickElement(btnSave, "Save");
            driver.CheckElementExists(lblEmailExists, "Email Already Exists");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Update on User Account Active Status Displayed
        /// </summary>
        public void ValidateUserAccountActiveStatusDisplayed()
        {
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "Name");
            driver.ClickElement(drpSingleUserRole, "Status");
            driver.CheckElementExists(lstStatusActive, "Active");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Manually Unlock User
        /// </summary>
        public void ValidateManuallyUnlockUserActive()
        {
            string email = "", status = "";
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.sleepTime(5000);
            email = driver.GetElementText(tblValueEmail);
            driver.ClickElement(tblValueName, "UserName");
            driver.ClickElement(drpSingleUserRole, "Status");
            driver.ClickElement(lstStatusActive, "Active");
            driver.ClickElement(btnSave, "Save");
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusActive, "Active");
            driver.SendKeysToElement(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            status = driver.GetElementText(tblValueStatus);
            if (status.Contains("Active"))
                testReport.Pass("Updated Status: <mark>" + status + "</mark> for user account: <mark>" + email + "</mark> is displayed on view user screen");
            else
                ReporterFactory.LogFailure("Updated Status: <mark>" + status + "</mark> for user account: <mark>" + email + "</mark> is not displayed on view user screen");
        }

        /// <summary>
        /// Method to Validate Manually Unlock User Save
        /// </summary>
        public void ValidateManuallyUnlockUserSave()
        {
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "UserName");
            driver.ClickElement(drpSingleUserRole, "Status");
            driver.ClickElement(lstStatusActive, "Active");
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Manually Unlock User Settings Unchanged
        /// </summary>
        public void ValidateManuallyUnlockUserSettingsUnchanged()
        {
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "UserName");
            driver.CheckElementExists(lblUserUtility, "Utility");
            driver.CheckElementExists(lftdrpUserRole, "Role");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Manually Unlock User Cancel
        /// </summary>
        public void ValidateManuallyUnlockUserCancel()
        {
            string emailBeforeUpdate = "", emailAfterCancel = "";
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.sleepTime(5000);
            emailBeforeUpdate = driver.GetElementText(tblValueEmail);
            driver.ClickElement(tblValueName, "UserName");
            driver.ClickElement(drpSingleUserRole, "Status");
            driver.ClickElement(lstStatusActive, "Active");
            driver.ClickElement(btnCancel, "Cancel");
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusActive, "Active");
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.sleepTime(5000);
            emailAfterCancel = driver.GetElementText(tblValueEmail);
            if (emailBeforeUpdate == emailAfterCancel)
                testReport.Pass("User Account Status is Locked and Updates made are NOT dispalyed on view user screen");
            else
                ReporterFactory.LogFailure("User Account Status is not Locked and Updates made are dispalyed on view user screen");
        }

        /// <summary>
        /// Method to Validate Manually Locked User
        /// </summary>
        public void ValidateManuallyLockedUserStatus()
        {
            string email = "", status = "";
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusActive, "Active");
            driver.sleepTime(5000);
            email = driver.GetElementText(tblValueEmail);
            driver.ClickElement(tblValueName, "UserName");
            driver.ClickElement(drpSingleUserRole, "Status");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.ClickElement(btnSave, "Save");
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.SendKeysToElementClearFirst(txtSearchEmailAddress, email, "Email Address");
            driver.SendKeysToElement(txtSearchEmailAddress, Keys.Enter, "EmailAddress");
            driver.sleepTime(5000);
            status = driver.GetElementText(tblValueStatus);
            if (status.Contains("Locked"))
                testReport.Pass("Updated Status: <mark>" + status + "</mark> for user account: <mark>" + email + "</mark> is displayed on view user screen");
            else
                ReporterFactory.LogFailure("Updated Status: <mark>" + status + "</mark> for user account: <mark>" + email + "</mark> is not displayed on view user screen");
        }

        /// <summary>
        /// Method to Validate Manually Lock User Save
        /// </summary>
        public void ValidateManuallyLockUserSave()
        {
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusActive, "Active");
            driver.sleepTime(5000);
            driver.ClickElement(tblValueName, "UserName");
            driver.ClickElement(drpSingleUserRole, "Status");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.ClickElement(btnSave, "Save");
        }

        /// <summary>
        /// Method to Validate Manually Lock User Cancel
        /// </summary>
        public void ValidateManuallyLockUserCancel()
        {
            string emailBeforeUpdate = "", emailAfterCancel = "";
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusActive, "Active");
            driver.sleepTime(5000);
            emailBeforeUpdate = driver.GetElementText(tblValueEmail);
            driver.ClickElement(tblValueName, "UserName");
            driver.ClickElement(drpSingleUserRole, "Status");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.ClickElement(btnCancel, "Cancel");
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusLocked, "Locked");
            driver.ClickElement(drpFilterStatus, "Status Search");
            driver.ClickElement(lstStatusActive, "Active");
            driver.sleepTime(5000);
            emailAfterCancel = driver.GetElementText(tblValueEmail);
            if (emailBeforeUpdate.Contains(emailAfterCancel))
                testReport.Pass("User Account Status is Active and Updates made are NOT dispalyed on view user screen");
            else
                ReporterFactory.LogFailure("User Account Status is not Active and Updates made are dispalyed on view user screen");
        }

        /// <summary>
        /// Method to Validate Edit User Display on User Management Widget
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="roleOption"></param>
        public void ValidateEditUserDisplay()
        {
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementExists(txtEditFirstName, "FirstName");
            driver.CheckElementExists(txtEditLastName, "LastName");
            driver.CheckElementExists(txtEditEmail, "EmailAddress");
            driver.CheckElementExists(drpStatus, "Status");
            driver.CheckElementExists(drpRole, "Role");
            driver.CheckElementExists(drpLanguage, "Language");
        }

        /// <summary>
        /// Method to Validate Edit Button Does not Exists
        /// </summary>
        public void ValidateEditButtonDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnEdit, "Edit");
        }

        /// <summary>
        /// Method to Validate Users List for Utility on User Management Widget
        /// </summary>
        public void ValidateUsersListForUtility()
        {
            driver.CheckElementExists(tblUsersList, "Users List");
        }

        /// <summary>
        /// Method to Validate Deactive User on User Management Widget
        /// </summary>
        public void ValidateDeactiveUser()
        {
            driver.ClickElement(lstUser, "First User in the List");
            driver.ClickElement(btnEdit, "Edit");
            driver.ClickElement(drpStatus, "Status");
            driver.CheckElementExists(lstStatusInactive, "Inactive");
        }

        /// <summary>
        /// Method to Validate Deactive User Does Not Existss on User Management Widget
        /// </summary>
        public void ValidateDeactiveUserDoesNotExists()
        {
            driver.CheckElementDoesnotExists(btnEdit, "Inactive User");
        }

        /// <summary>
        /// Method to Validate Landing Page Password Reset Displays and Enabled
        /// </summary>
        public void ValidateLandingPagePwdResetDisplays()
        {
            driver.ClickElement(lstUser, "First User in the List");
            driver.ClickElement(btnEdit, "Edit");
            driver.CheckElementExists(btnSendPwdReset, "Password Reset");
            driver.IsElementEnabled(btnSendPwdReset, "Send Password Reset");
        }

        /// <summary>
        /// Method to Validate Landing Page Password Reset Does Not Displays
        /// </summary>
        public void ValidateLandingPagePwdResetDoesNotDisplays()
        {
            driver.CheckElementDoesnotExists(btnSendPwdReset, "Password Reset");
        }

        /// <summary>
        /// Method to Validate New User Role
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="role"></param>
        public void ValidateNewUserRole(string firstName, string lastName, string email, string role)
        {
            driver.ClickElement(btnCreateLanding, "Create");
            driver.SendKeysToElement(txtEditFirstName, firstName, "FirstName");
            driver.SendKeysToElement(txtEditLastName, lastName, "LastName");
            driver.SendKeysToElement(txtEditEmail, email, "EmailAddress");
            driver.ClickElement(drpRole, "Role");
            SelectRoleOption(role);
            driver.ClickElement(btnEditSave, "Save");
        }

        /// <summary>
        /// Method to Validate sdk Access toggle Display
        /// </summary>
        public void ValidateSdkAccesstoggleDisplay()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.CheckElementDisplayed(sdkAccess, "SDK Access Toggle");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate sdk Access toggle editable
        /// </summary>
        public void ValidateSdkAccesstoggleEditable()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(sdkAccess, "SDK Access Toggle");
            testReport.Pass("SDK Access Only toggle is editable");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate sdk Access toggle Search Partner
        /// </summary>
        public void ValidateSdkAccessSearchPartner()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(sdkAccess, "SDK Access Toggle");
            driver.SendKeysToElement(searchPartner, "test", "Partner");
            driver.ClickElement(By.XPath("//span[contains(.,'test')]"), "Partner");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate sdk Access toggle Search Partner Paired
        /// </summary>
        public void ValidateSdkAccessSearchPartnerPaired()
        {
            driver.ClickElement(btnCreate, "Create");
            driver.ClickElement(sdkAccess, "SDK Access Toggle");
            driver.SendKeysToElement(searchPartner, "test", "Partner");
            driver.ClickElement(By.XPath("//span[contains(.,'test')]"), "Partner");
            driver.sleepTime(2000);
            driver.SendKeysToElement(searchPartner, "test", "Partner");
            driver.ClickElement(By.XPath("//span[contains(.,'test')]"), "Partner");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate sdk Access Toggle Not Available
        /// </summary>
        public void ValidateSdkAccessToggleNotAvailable()
        {
            driver.SendKeysToElement(txtFnameGridCol, "Ayan", "UserName");
            driver.SendKeysToElement(txtFnameGridCol, Keys.Enter, "UserName");
            driver.WaitForElement(tblValueName, TimeSpan.FromSeconds(30));
            driver.ClickElement(By.LinkText("Ayan Bhattacharjee"), "User");
            driver.WaitForElement(sdkAccess,TimeSpan.FromSeconds(30));
            driver.IsElementDisabled(sdkAccess, "SDK Access Toggle");
            testReport.Pass("SDK Access Only toggle is not displayed");
            driver.ClickElement(btnCancel, "Cancel");
        }

        /// <summary>
        /// Method to Validate Neptune 360 Partner Role_Cannot Apply
        /// </summary>
        public void ValidateNeptune360PartnerRoleCannotApply()
        {
            driver.sleepTime(5000);
            driver.ClickElement(btnCreateLanding, "Create");
            driver.sleepTime(5000);
            driver.ClickElement(drpDownRole, "Role");
        }

        /// <summary>
        /// Method to Validate 3rd_Party_Vendor_Header
        /// </summary>
        public void Validate3rdPartyVendorHeader()
        {
            driver.ClickElement(roleDrpdown, "Dropdown");
            driver.ClickElement(neptune360partner, "Neptune 360 Partner");
            driver.CheckElementDisplayed(thirdpartyVendor, "3rd Party Vendor");
        }

    }
}