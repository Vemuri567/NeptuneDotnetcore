using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class UserManagement : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Create User Fields
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3943_User_Management_Create_Create_User_Fields()
        {
            testCaseId = "TC-3943";
            qTestUniqueId = "19323251";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateCreateUserFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create Ability to Update Each Fields
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3944_User_Management_Create_Ability_to_update_each_fields()
        {
            testCaseId = "TC-3944";
            qTestUniqueId = "19323252";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                //userManagement.ValidateCreateUserFields();
                userManagement.EnterTextInCreateUserFields(firstName, lastName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create Selecting Create Button
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3945_User_Management_Create_Selecting_Create_Button()
        {
            testCaseId = "TC-3945";
            qTestUniqueId = "19323253";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateCreateUserFields();
                userManagement.CreateUserFields(firstName, lastName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a Single Utility and Set Role Create New User
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3607_Create_New_User_for_a_single_Utility_and_set_Role_Create_New_User()
        {
            testCaseId = "TC-3607";
            qTestUniqueId = "19238317";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSingleUtilityCreateUserFields();
                userManagement.CreateSingleUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a Single Utility and Set Role Default Creation Date
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3608_Create_New_User_for_a_single_Utility_and_set_Role_Default_Creation_Date()
        {
            testCaseId = "TC-3608";
            qTestUniqueId = "19238318";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSingleUtilityDefaultCreationDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a Single Utility and Set Role Required Fields
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3609_Create_New_User_for_a_single_Utility_and_set_Role_Required_Fields()
        {
            testCaseId = "TC-3609";
            qTestUniqueId = "19238319";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSingleUtilityRequiredFieldsMessage(firstName, lastName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a Single Utility and Set Role Optional Fields
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3610_Create_New_User_for_a_single_Utility_and_set_Role_Optional_Fields()
        {
            testCaseId = "TC-3610";
            qTestUniqueId = "19238320";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = "";
                lastName = "";
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateSingleUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithNameEmpty(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a Single Utility and Set Role Ability to Select Active Role
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3611_Create_New_User_for_a_single_Utility_and_set_Role_Ability_to_select_active_role()
        {
            testCaseId = "TC-3611";
            qTestUniqueId = "19238321";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateSingleUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a Single Utility and Set Role New User Set to Active by Default
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3612_Create_New_User_for_a_single_Utility_and_set_Role_New_User_set_to_active_by_default()
        {
            testCaseId = "TC-3612";
            qTestUniqueId = "19238322";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSingleUtilityStatusFieldDisabled();
                userManagement.CreateSingleUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
                userManagement.ValidateStatusFieldActive();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a single Utility and set Role - Ability to Create User for single utility and set role
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3613_Create_New_User_for_a_single_Utility_and_set_Role_Ability_to_Create_User_for_single_utility_and_set_role()
        {
            testCaseId = "TC-3613";
            qTestUniqueId = "19238323";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateSingleUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a single Utility and set Role - Create user Boundary Testing
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3614_Create_New_User_for_a_single_Utility_and_set_Role_Create_user_Boundary_Testing()
        {
            testCaseId = "TC-3614";
            qTestUniqueId = "19238324";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateMaxCharLengthForSingleUtilityCreateUserFields(firstName, lastName, email);
                userManagement.ValidateAlphaNumericCharsForSingleUtilityCreateUserFields(roleOption);
                userManagement.ValidateSpecialCharsSingleUtilityCreateUserFields(roleOption);
                userManagement.ValidateSpecialCharsForEmailNASingleUtility(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a single Utility and set Role - Messaging - Email Validation
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3615_Create_New_User_for_a_single_Utility_and_set_Role_Messaging_Email_Validation()
        {
            testCaseId = "TC-3615";
            qTestUniqueId = "19238325";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateSingleUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateEmailMessagingSingleUtility(firstName, lastName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a single Utility and set Role -  Verify Confirmation pop-up and verbiage
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3617_Create_New_User_single_Utility_and_set_Role_Verify_Confirmation_popup_and_verbiage()
        {
            testCaseId = "TC-3617";
            qTestUniqueId = "19238327";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateSingleUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateCreateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create New User for a single Utility and set Role - Ability to cancel
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3618_Create_New_User_for_a_single_Utility_and_set_Role_Ability_to_cancel()
        {
            testCaseId = "TC-3618";
            qTestUniqueId = "19238328";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSingleUtilityCreateUserAbilityToCancel(firstName, lastName, email, roleOption);
                userManagement.ValidateNoUserDisplayOnUserList(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Add User
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3664_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Add_User()
        {
            testCaseId = "TC-3664";
            qTestUniqueId = "19238408";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateCreateBtnUserManagementDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Create a New User Modal
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3665_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Create_a_New_User_Modal()
        {
            testCaseId = "TC-3665";
            qTestUniqueId = "19238409";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilityUserFields();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Default Creation Date
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3666_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Default_Creation_Date()
        {
            testCaseId = "TC-3666";
            qTestUniqueId = "19238410";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilityDefaultCreationDate();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Required Fields
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3667_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Required_Fields()
        {
            testCaseId = "TC-3667";
            qTestUniqueId = "19238411";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilityRequiredFieldsMessage(firstName, lastName, email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Optional Fields
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3668_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Optional_Fields()
        {
            testCaseId = "TC-3668";
            qTestUniqueId = "19238412";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = EngineSetup.GetRandomString() + EngineSetup.GetRandomString() + "@gmail.com";
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateAnyUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithNameEmpty(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - New User set to Active by default
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3669_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_New_User_set_to_Active_by_default()
        {
            testCaseId = "TC-3669";
            qTestUniqueId = "19238413";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilityStatusFieldDisabled();
                userManagement.CreateAnyUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
                userManagement.ValidateStatusFieldActive();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Ability to search for Utility
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3670_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Ability_to_search_for_Utility()
        {
            testCaseId = "TC-3670";
            qTestUniqueId = "19238414";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                utilityName = testData["UtilityName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilityAbilityToSearchUtility(utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Ability to set Utility to New User
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3671_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Ability_to_set_Utility_to_New_User()
        {
            testCaseId = "TC-3671";
            qTestUniqueId = "19238415";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilityAbilityToSelectUtility();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Ability to set Role for New User
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3672_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Ability_to_set_Role_for_New_User()
        {
            testCaseId = "TC-3672";
            qTestUniqueId = "19238416";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                utilityName = testData["UtilityName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilitySelectUtilitySelectRole(roleOption,utilityName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Ability to Add multiple Utilities to New User
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3673_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Ability_to_Add_multiple_Utilities_to_New_User()
        {
            testCaseId = "TC-3673";
            qTestUniqueId = "19238417";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilitySelectMultipleUtilitiesRoles(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Ability to Create New User for Utility and set Role
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3675_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Ability_to_Create_New_User_for_Utility_and_set_Role()
        {
            testCaseId = "TC-3675";
            qTestUniqueId = "19238419";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateAnyUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserAllFields(firstName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Boundary Testing
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3676_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Boundary_Testing()
        {
            testCaseId = "TC-3676";
            qTestUniqueId = "19238420";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateMaxCharLengthForAnyUtilityCreateUserFields(firstName, lastName, email);
                userManagement.ValidateAlphaNumericCharsForAnyUtilityCreateUserFields(roleOption);
                userManagement.ValidateSpecialCharsAnyUtilityCreateUserFields(roleOption);
                userManagement.ValidateSpecialCharsAnyUtilityForEmailNA(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Messaging - Email Validation
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3677_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Messaging_Email_Validation()
        {
            testCaseId = "TC-3677";
            qTestUniqueId = "19238421";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateAnyUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateEmailMessagingAlreadyExistsForAnyUtility(firstName, lastName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Verify Confirmation pop-up and verbiage
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3678_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Verify_Confirmation_pop_up_and_verbiage()
        {
            testCaseId = "TC-3678";
            qTestUniqueId = "19238422";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.CreateAnyUtilityUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateCreateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Create a New User Account for Any Utility and Set Role - Ability to Cancel creating a new User for a Utility
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3680_Create_a_New_User_Account_for_Any_Utility_and_Set_Role_Ability_to_Cancel_creating_a_new_User_for_a_Utility()
        {
            testCaseId = "TC-3680";
            qTestUniqueId = "19238424";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateAnyUtilityCreateUserAbilityToCancel(firstName, lastName, email, roleOption);
                userManagement.ValidateNoUserDisplayOnUserList(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit User and Reset Password Button - Edit Mode
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3950_Edit_User_and_Reset_Password_Button_Edit_Mode()
        {
            testCaseId = "TC-3950";
            qTestUniqueId = "19323290";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateSearchUserAccount(firstName);
                userManagement.ValidateEditUser(firstName, lastName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit User and Reset Password Button - Upon Save
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3951_Edit_User_and_Reset_Password_Button_Upon_Save()
        {
            testCaseId = "TC-3951";
            qTestUniqueId = "19323291";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateSearchUserAccount(firstName);
                userManagement.ValidateEditUser(firstName, lastName, email, roleOption);
                userManagement.ValidateEditErrorMessageValidation(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit User - Left Navigation - Active to Inactive
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_7837_Edit_User_Left_Navigation_Active_to_Inactive()
        {
            testCaseId = "TC-7837";
            qTestUniqueId = "19932323";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavEditUserStatusActiveToInactive(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit User - Left Navigation - Inactive to Active
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_7838_Edit_User_Left_Navigation_Inactive_to_Active()
        {
            testCaseId = "TC-7838";
            qTestUniqueId = "19933020";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavEditUserStatusInactiveToActive(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit User - Landing Page - Active to Inactive
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_7860_Edit_User_Landing_Page_Active_to_Inactive()
        {
            testCaseId = "TC-7860";
            qTestUniqueId = "20029611";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateSearchUserAccount(firstName);
                userManagement.ValidateLandPageEditUserStatusActiveToInactive(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Edit User - Landing Page - Inactive to Active
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_7861_Edit_User_Landing_Page_Inactive_to_Active()
        {
            testCaseId = "TC-7861";
            qTestUniqueId = "20029612";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateSearchUserAccount(firstName);
                userManagement.ValidateLandPageEditUserStatusInactiveToActive(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account - Ability to update User Account
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3559_Update_a_User_Account_Ability_to_update_User_Account()
        {
            testCaseId = "TC-3559";
            qTestUniqueId = "19238165";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavUserFields(email);
                userManagement.ValidateToUpdateLftNavUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account - Ability to update User Account
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3560_Update_a_User_Account_Required_Fields()
        {
            testCaseId = "TC-3560";
            qTestUniqueId = "19238166";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateEnterEmailAddressMessage(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account - Optional Fields
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3561_Update_a_User_Account_Optional_Fields()
        {
            testCaseId = "TC-3561";
            qTestUniqueId = "19238167";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateUserOptionalFields(email);
                userManagement.ValidateSearchUserWithNameEmpty(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account - Verify Confirmation Pop-up and verbiage
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3563_Update_a_User_Account_Verify_Confirmation_Pop_up_and_verbiage()
        {
            testCaseId = "TC-3563";
            qTestUniqueId = "19238170";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateUserUpdateFields(firstName, lastName, email, roleOption);
                userManagement.ValidateUpdateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account - Messaging - Validate Email Address
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3564_Update_a_User_Account_Messaging_Validate_Email_Address()
        {
            testCaseId = "TC-3564";
            qTestUniqueId = "19238171";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateUpdateUserAccountEmailMessaging(firstName, lastName, email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account - Updating a User Account can be cancelled
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3566_Update_a_User_Account_Updating_a_User_Account_can_be_cancelled()
        {
            testCaseId = "TC-3566";
            qTestUniqueId = "19238173";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateUpadateUserAccountCancel(firstName, lastName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to View a List of User Accounts - Grid Columns
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3605_View_a_List_of_User_Accounts_Grid_Columns()
        {
            testCaseId = "TC-3605";
            qTestUniqueId = "19238307";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateUserAccountsGridColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User List - User is able to view list of users
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3946_User_List_User_is_able_to_view_list_of_users()
        {
            testCaseId = "TC-3946";
            qTestUniqueId = "19323254";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateUsersToUtility("Naveen");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User List - Default Display
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3947_User_List_Default_Display()
        {
            testCaseId = "TC-3947";
            qTestUniqueId = "19323255";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLandingPageUserListDefaultDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User List - Partial Search
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3948_User_List_Partial_Search()
        {
            testCaseId = "TC-3948";
            qTestUniqueId = "19323256";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateUsersPartialSearch(firstName, lastName, email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User List - Filter
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3949_User_List_Filter()
        {
            testCaseId = "TC-3949";
            qTestUniqueId = "19323257";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                roleOption = testData["RoleOption"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateUsersListFilter(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to View User Across All Available Utilities - Grid Columns
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3662_View_User_Across_All_Available_Utilities_Grid_Columns()
        {
            testCaseId = "TC-3662";
            qTestUniqueId = "19238403";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavUtilitiesGridColumns();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Ability to search by Utility Name
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3645_Search_for_User_Accounts_across_all_Utilities_Ability_to_search_by_Utility_Name()
        {
            testCaseId = "TC-3645";
            qTestUniqueId = "19238384";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByUtilityName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Ability to search by User Name
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3646_Search_for_User_Accounts_across_all_Utilities_Ability_to_search_by_User_Name()
        {
            testCaseId = "TC-3646";
            qTestUniqueId = "19238385";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByUserName(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Ability to search by First, First and Last, Last name
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3647_Search_for_User_Accounts_across_all_Utilities_Ability_to_search_by_First_First_and_Last_Last_name()
        {
            testCaseId = "TC-3647";
            qTestUniqueId = "19238386";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByFNameLname(firstName, lastName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Ability to search by Email Address
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3648_Search_for_User_Accounts_across_all_Utilities_Ability_to_search_by_Email_Address()
        {
            testCaseId = "TC-3648";
            qTestUniqueId = "19238387";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByEmailAddress(userName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Ability to search by Status
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3649_Search_for_User_Account_across_all_Utilities_Ability_to_search_by_Status()
        {
            testCaseId = "TC-3649";
            qTestUniqueId = "19238388";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByStatus();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Ability to search All Active Role Name
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3650_Search_for_User_Accounts_across_all_Utilities_Ability_to_search_All_Active_Role_Name()
        {
            testCaseId = "TC-3650";
            qTestUniqueId = "19238389";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByRole(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Ability to Sort each column (asc/desc)
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3651_Search_for_User_Accounts_across_all_Utilities_Ability_to_Sort_each_column_asc_desc()
        {
            testCaseId = "TC-3651";
            qTestUniqueId = "19238390";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSearchUserToSortEachColAscDesc();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Messaging - No Results returned
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3652_Search_for_User_Accounts_across_all_Utilities_Messaging_No_Results_returned()
        {
            testCaseId = "TC-3652";
            qTestUniqueId = "19238391";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserMessNoResultsFound();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Ability to search partial field name
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3654_Search_for_User_Accounts_across_all_Utilities_Ability_to_search_partial_field_name()
        {
            testCaseId = "TC-3654";
            qTestUniqueId = "19238393";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserstoSearchPartial("test", "Test@gmail.com");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Search by tab/enter/off focus
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3655_Search_for_User_Accounts_across_all_Utilities_Search_by_tab_enter_off_focus()
        {
            testCaseId = "TC-3655";
            qTestUniqueId = "19238394";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByUserName(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Search Results
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3656_Search_for_User_Accounts_across_all_Utilities_Search_Results()
        {
            testCaseId = "TC-3656";
            qTestUniqueId = "19238395";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSearchResults();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - User Name search result
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3657_Search_for_User_Accounts_across_all_Utilities_User_Name_search_result()
        {
            testCaseId = "TC-3657";
            qTestUniqueId = "19238396";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByUserName("test");
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Utility Name/ID search result
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3658_Search_for_User_Accounts_across_all_Utilities_Utility_Name_ID_search_result()
        {
            testCaseId = "TC-3658";
            qTestUniqueId = "19238397";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByUtilityName();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Email Address search result
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3659_Search_for_User_Accounts_across_all_Utilities_Email_Address_search_result()
        {
            testCaseId = "TC-3659";
            qTestUniqueId = "19238398";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByEmailAddress(userName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Accounts across all Utilities - Role search result
        /// </summary>
        [Category("UserManagement")]
        [Category("UserManagement-Regression")]
        [Category("RegressionTests2")]
        [Test]
        public void TC_3660_Search_for_User_Accounts_across_all_Utilities_Role_search_result()
        {
            testCaseId = "TC-3660";
            qTestUniqueId = "19238399";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByRole(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Update User
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3698_Update_a_User_Account_and_Utility_Role_Settings_Update_User()
        {
            testCaseId = "TC-3698";
            qTestUniqueId = "19238444";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavUserFields(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Update User Details
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3699_Update_a_User_Account_and_Utility_Role_Settings_Update_User_Details()
        {
            testCaseId = "TC-3699";
            qTestUniqueId = "19238445";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserFieldClickUser(email);
                userManagement.ValidateToUpdateLftNavUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Update Utility
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3700_Update_a_User_Account_and_Utility_Role_Settings_Update_Utility()
        {
            testCaseId = "TC-3700";
            qTestUniqueId = "19238446";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserFieldClickUser(email);
                userManagement.ValidateUpdateAdditionalUtilities(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Update Role
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3701_Update_a_User_Account_and_Utility_Role_Settings_Update_Role()
        {
            testCaseId = "TC-3701";
            qTestUniqueId = "19238447";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserFieldClickUser(email);
                userManagement.ValidateLftNavUserAccountUpdateRole(email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Saving updated User Account
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3702_Update_a_User_Account_and_Utility_Role_Settings_Saving_updated_User_Account()
        {
            testCaseId = "TC-3702";
            qTestUniqueId = "19238448";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavUserFields(email);
                userManagement.ValidateLftNavSearchUserFieldClickUser(email);
                userManagement.ValidateToUpdateLftNavUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Saving updated User Account (Boundary Testing)
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3703_Update_a_User_Account_and_Utility_Role_Settings_Saving_updated_User_AccountBoundary_Testing()
        {
            testCaseId = "TC-3703";
            qTestUniqueId = "19238449";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateMaxCharLengthForSingleUtilityCreateUserFields(firstName, lastName, email);
                userManagement.ValidateAlphaNumericCharsForSingleUtilityCreateUserFields(roleOption);
                userManagement.ValidateSpecialCharsSingleUtilityCreateUserFields(roleOption);
                userManagement.ValidateSpecialCharsForEmailNASingleUtility(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Email address validation
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3704_Update_a_User_Account_and_Utility_Role_Settings_Email_address_validation()
        {
            testCaseId = "TC-3704";
            qTestUniqueId = "19238450";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavUserAccountUpdateEmailMessaging(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Verify Confirmation pop-up and verbiage
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3706_Update_a_User_Account_and_Utility_Role_Settings_Verify_Confirmation_pop_up_and_verbiage()
        {
            testCaseId = "TC-3706";
            qTestUniqueId = "19238452";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateUserUpdateFields(firstName, lastName, email, roleOption);
                userManagement.ValidateUpdateUserConfirmationPopup();
                userManagement.ValidateSearchUserWithEmail(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Verify if updates are reflected on User View
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3707_Update_a_User_Account_and_Utilitt_Role_Settings_Verify_if_Updates_are_reflected_on_User_View()
        {
            testCaseId = "TC-3707";
            qTestUniqueId = "19238453";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavUserFields(email);
                userManagement.ValidateLftNavSearchUserFieldClickUser(email);
                userManagement.ValidateToUpdateLftNavUserFields(firstName, lastName, email, roleOption);
                userManagement.ValidateSearchUserAllFields(firstName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Update a User Account and Utility/Role Settings - Ability to Cancel saving of an updated User Account
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3708_Update_a_User_Account_and_Utility_Role_Settings_Ability_to_Cancel_saving_of_an_updated_User_Account()
        {
            testCaseId = "TC-3708";
            qTestUniqueId = "19238454";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                lastName = testData["LastName"];
                email = testData["Email"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateUpadateUserAccountCancel(firstName, lastName, email, roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually unlock a user account - Active status is displayed on the Status field
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3739_User_Account_SecurityUI_manually_unlock_a_user_account_Active_status_is_displayed_on_the_Status_field()
        {
            testCaseId = "TC-3739";
            qTestUniqueId = "19238517";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateUserAccountActiveStatusDisplayed();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually unlock a user account - Manually unlock a user account
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3740_User_Account_Security_UI_manually_unlock_a_user_account_Manually_unlock_a_user_account()
        {
            testCaseId = "TC-3740";
            qTestUniqueId = "19238518";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyUnlockUserActive();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually unlock a user account - Verify Confirmation pop-up and verbiage
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3741_User_Account_Security_UI_manually_unlock_a_user_account_Verify_Confirmation_pop_up_and_verbiage()
        {
            testCaseId = "TC-3741";
            qTestUniqueId = "19238519";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyUnlockUserSave();
                userManagement.ValidateUpdateUserConfirmationPopup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually unlock a user account - Data and settings of the locked user are unchanged and maintained
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3743_User_manually_unlock_Data_and_settings_of_the_locked_user_are_unchanged_and_maintained()
        {
            testCaseId = "TC-3743";
            qTestUniqueId = "19238521";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyUnlockUserSettingsUnchanged();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually unlock a user account - Ability to cancel the manual locking of user account
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3744_User_manually_unlock_a_user_account_Ability_to_cancel_the_manual_locking_of_user_account()
        {
            testCaseId = "TC-3744";
            qTestUniqueId = "19238522";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyUnlockUserCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually unlock a user account - Locked status of user accounts should display on view list
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3745_User_manually_unlock_a_user_account_Locked_status_of_user_accounts_should_display_on_view_list()
        {
            testCaseId = "TC-3745";
            qTestUniqueId = "19238523";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyLockedUserStatus();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually lock a user account - Locked status is displayed on the Status field
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3746_User_Account_manually_lock_a_user_account_Locked_status_is_displayed_on_the_Status_field()
        {
            testCaseId = "TC-3746";
            qTestUniqueId = "19238524";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyLockedUserStatus();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually lock a user account - Manually lock a user account
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3747_User_Account_Security_UI_manually_lock_a_user_account_Manually_lock_a_user_account()
        {
            testCaseId = "TC-3747";
            qTestUniqueId = "19238525";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyLockUserSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually lock a user account - Verify Confirmation pop-up and verbiage
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3748_User_UI_manually_lock_a_user_account_Verify_Confirmation_pop_up_and_verbiage()
        {
            testCaseId = "TC-3748";
            qTestUniqueId = "19238526";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyLockUserSave();
                userManagement.ValidateUpdateUserConfirmationPopup();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account manually lock a user account - Data and settings of the locked user are unchanged and maintained
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3750_User_Account_manually_lock_a_user_account_Data_and_settings_of_the_locked_user_are_unchanged_and_maintained()
        {
            testCaseId = "TC-3750";
            qTestUniqueId = "19238528";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyLockUserSave();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account Security: UI - manually lock a user account - Ability to cancel the manual locking of user account
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3751_User_Account_Security_UI_manually_lock_a_user_account_Ability_to_cancel_the_manual_locking_of_user_account()
        {
            testCaseId = "TC-3751";
            qTestUniqueId = "19238529";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyLockUserCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Account manually lock a user account - Locked status of user accounts should display on view utilities
        /// </summary>
        [Category("UserManagement")]
        [Test]
        public void TC_3752_User_Account_manually_lock_a_user_account_Locked_status_of_user_accounts_should_display_on_view_utilities()
        {
            testCaseId = "TC-3752";
            qTestUniqueId = "19238530";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateManuallyLockUserCancel();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }

            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Account - Ability to search by Username
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3682_Search_for_User_Account_Ability_to_search_by_Username()
        {
            testCaseId = "TC-3682";
            qTestUniqueId = "19238426";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByUserName(firstName);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Account Ability to search by email address
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3684_Search_for_User_Account_Ability_to_search_by_email_address()
        {
            testCaseId = "TC-3684";
            qTestUniqueId = "19238428";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByEmailAddress(email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Account Ability to search by Status
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3685_Search_for_User_Account_Ability_to_search_by_Status()
        {
            testCaseId = "TC-3685";
            qTestUniqueId = "19238429";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByStatus();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Account Ability to search by All Active Role Name
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3686_Search_for_User_Account_Ability_to_search_by_All_Active_Role_Name()
        {
            testCaseId = "TC-3686";
            qTestUniqueId = "19238430";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                roleOption = testData["RoleOption"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserByRole(roleOption);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User AccountAbility to sort each column (asc/desc)
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3687_Search_for_User_Account_Ability_to_sort_each_column_asc_desc()
        {
            testCaseId = "TC-3687";
            qTestUniqueId = "19238431";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSearchUserToSortEachColAscDesc();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Account Messaging - No Results returned
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3689_Search_for_User_Account_Messaging_No_Results_returned()
        {
            testCaseId = "TC-3689";
            qTestUniqueId = "19238433";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserMessNoResultsFound();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Search for User Account Ability to search by partial field name
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_3690_Search_for_User_Account_Ability_to_search_by_partial_field_name()
        {
            testCaseId = "TC-3690";
            qTestUniqueId = "19238434";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                firstName = testData["FirstName"];
                email = testData["Email"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateLftNavSearchUserstoSearchPartial(firstName, email);
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Platform Management_User Management_Create User_SDK Access Only_Toggle_Display
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16821_Platform_Management_User_Management_Create_User_SDK_Access_Only_Toggle_Display()
        {
            testCaseId = "TC-16821";
            qTestUniqueId = "35839296";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSdkAccesstoggleDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_User Management_Create User_SDK Access Only_Toggle_Not Available
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16822_Landing_Page_User_Management_Create_User_SDK_Access_Only_Toggle_Not_Available()
        {
            testCaseId = "TC-16822";
            qTestUniqueId = "35839298";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSdkAccesstoggleDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Platform Management_User Management_Create User_SDK Access Only_Toggle_Default State
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16823_Platform_Management_User_Management_Create_User_SDK_Access_Only_Toggle_Default_State()
        {
            testCaseId = "TC-16823";
            qTestUniqueId = "35839299";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSdkAccesstoggleDisplay();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Platform Management_User Management_Create User_SDK Access Only_Toggle_Editable
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16824_Platform_Management_User_Management_Create_User_SDK_Access_Only_Toggle_Editable()
        {
            testCaseId = "TC-16824";
            qTestUniqueId = "35839301";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSdkAccesstoggleEditable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Platform Management_User Management_Create User SDK Access Only_Enabled_Search Partners
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16825_Platform_Management_User_Management_Create_User_SDK_Access_Only_Enabled_Search_Partners()
        {
            testCaseId = "TC-16825";
            qTestUniqueId = "35839302";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSdkAccessSearchPartner();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Platform Management_User Management_SDK Access Only_Enabled_Only One Partner Paired
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16826_Platform_Management_User_Management_Create_User_SDK_Access_Only_Enabled_Only_One_Partner_Paired()
        {
            testCaseId = "TC-16826";
            qTestUniqueId = "35839303";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSdkAccessSearchPartnerPaired();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_User Management_Edit User_SDK Access Only_Toggle_Not Available
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16829_Landing_Page_User_Management_Edit_User_SDK_Access_Only_Toggle_Not_Available()
        {
            testCaseId = "TC-16829";
            qTestUniqueId = "35839311";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.ValidateSdkAccessToggleNotAvailable();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_User Management_Create User_Neptune 360 Partner Role_Cannot Apply
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16830_Landing_Page_User_Management_Create_User_Neptune_360_Partner_Role_Cannot_Apply()
        {
            testCaseId = "TC-16830";
            qTestUniqueId = "35839312";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNeptune360PartnerRoleCannotApply();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Landing Page_User Management_Edit_Neptune 360 Partner Role_Cannot Apply
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16831_Landing_Page_User_Management_Edit_Neptune_360_Partner_Role_Cannot_Apply()
        {
            testCaseId = "TC-16831";
            qTestUniqueId = "35839350";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNeptune360PartnerRoleCannotApply();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to Platform Management_User Management_SDK Access Only_Disabled_Neptune 360 Partner Role_Cannot Select
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16832_Platform_Management_User_Management_SDK_Access_Only_Disabled_Neptune_360_Partner_Role_Cannot_Select()
        {
            testCaseId = "TC-16832";
            qTestUniqueId = "35840335";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateLanPageUserManagement(url, userName, password);
                userManagement.ValidateNeptune360PartnerRoleCannotApply();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Management_3rd Party Vendor_Header_Display
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16986_User_Management_3rd_Party_Vendor_Header_Display()
        {
            testCaseId = "TC-16986";
            qTestUniqueId = "36271912";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.Validate3rdPartyVendorHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Management_3rd Party Vendor_Header_Except Neptune 360 Partner Role User_Display
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16987_User_Management_3rd_Party_Vendor_Header_Except_Neptune_360_Partner_Role_User_Display()
        {
            testCaseId = "TC-16987";
            qTestUniqueId = "36271914";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.Validate3rdPartyVendorHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Test Method to User Management_3rd Party Vendor_Header_Neptune 360 Partner Role User_Display
        /// </summary>
        [Category("UserManagement")]
        [Category("RegressionTests")]
        [Test]
        public void TC_16988_User_Management_3rd_Party_Vendor_Header_Neptune_360_Partner_Role_User_Display()
        {
            testCaseId = "TC-16988";
            qTestUniqueId = "36271915";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                home.NavigateToLftUserManagement(url, userName, password);
                userManagement.Validate3rdPartyVendorHeader();
                home.UserLogOut();
                QTest.PublishQtestResults(qTestUniqueId, ReporterFactory.TestReport.Status.ToString(), startDate, DateTime.Now);
            }
            catch (Exception ex)
            {
                ReporterFactory.LogFailure("Test Failed - " + ex.Message+ex.StackTrace, EngineSetup.GetScreenShotPath(), false);
                QTest.PublishQtestResults(qTestUniqueId, "Fail", startDate, DateTime.Now);
                Assert.Fail(ex.Message);
            }
        }


    }
}