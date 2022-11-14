using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Neptune360UIAutomation
{
    public class AlertConfiguration : TestBaseTemplate
    {
        /// <summary>
        /// Test Method to Alert Configuration - Edit Button
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13172_Alert_Configuration_Edit_Button()
        {
            testCaseId = "TC-13172";
            qTestUniqueId = "28840430";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateAlertConfigEditBtn();
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
        /// Test Method to Alert Configuration - Done Button
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests1")]
        [Test]
        public void TC_13173_Alert_Configuration_Done_Button()
        {
            testCaseId = "TC-13173";
            qTestUniqueId = "28840431";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateAlertConfigDoneBtn();
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
        /// Test Method to Alert Configuration - Events - Options
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13174_Alert_Configuration_Events_Options()
        {
            testCaseId = "TC-13174";
            qTestUniqueId = "28840432";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateEventOptions();
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
        /// Test Method to Alert Configuration - Events - Options
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13175_Alert_Configuration_Events_Options()
        {
            testCaseId = "TC-13175";
            qTestUniqueId = "28840433";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateContinousConsumptionVerbiage();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Selected 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13176_Alert_Configuration_Events_Continuous_Consumption_Selected()
        {
            testCaseId = "TC-13176";
            qTestUniqueId = "28840434";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateContinousConsumptionOptions();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Critical - Daily Email  
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13180_Alert_Configuration_Events_Continuous_Consumption_Critical_Daily_Email()
        {
            testCaseId = "TC-13180";
            qTestUniqueId = "28840438";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateCriticalActiveMail();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Critical - Threshold Description    
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13181_Alert_Configuration_Events_Continuous_Consumption_Critical_Threshold_Description()
        {
            testCaseId = "TC-13181";
            qTestUniqueId = "28840439";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateCritiConsumpDescription();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Warning - Alert Active   
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13184_Alert_Configuration_Events_Continuous_Consumption_Warning_Alert_Active()
        {
            testCaseId = "TC-13184";
            qTestUniqueId = "28840442";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningActiveMail();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Warning - Daily Email    
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13185_Alert_Configuration_Events_Continuous_Consumption_Warning_Daily_Email()
        {
            testCaseId = "TC-13185";
            qTestUniqueId = "28840443";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningActiveMail();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Warning - Threshold Descriptio
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13186_Alert_Configuration_Events_Continuous_Consumption_Warning_Threshold_Description()
        {
            testCaseId = "TC-13186";
            qTestUniqueId = "28840444";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningThresholdConsumptionDescription();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Normal - Alert Active 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13189_Alert_Configuration_Events_Continuous_Consumption_Normal_Alert_Active()
        {
            testCaseId = "TC-13189";
            qTestUniqueId = "28840447";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateContinousConsumptionNormal();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Normal - Daily Email  
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13190_Alert_Configuration_Events_Continuous_Consumption_Normal_Daily_Email()
        {
            testCaseId = "TC-13190";
            qTestUniqueId = "28840448";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalActiveMail();
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
        /// Test Method to Alert Configuration - Events - Continuous Consumption - Normal - Threshold Description   
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13191_Alert_Configuration_Events_Continuous_Consumption_Normal_Threshold_Description()
        {
            testCaseId = "TC-13191";
            qTestUniqueId = "28840449";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThresholdConsumptionDescription();
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
        /// Test Method to Alert Configuration - Continuous Consumption - Edit Button -  Cancel/Done Buttons     
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13192_Alert_Configuration_Continuous_Consumption_Edit_Button_Cancel_Done_Buttons()
        {
            testCaseId = "TC-13192";
            qTestUniqueId = "28840455";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateEditButtonCancelButton();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Edit/Done Buttons       
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13193_Alert_Configuration_Continuous_Consumption_Edit_Button_Edit_Done_Buttons()
        {
            testCaseId = "TC-13193";
            qTestUniqueId = "28840456";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateEditButtonDisabled();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Event Selected        
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13194_Alert_Configuration_Continuous_Consumption_Edit_Button_Event_Selected()
        {
            testCaseId = "TC-13194";
            qTestUniqueId = "28840457";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateEventCannotBeChanged();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Event Options      
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13195_Alert_Configuration_Continuous_Consumption_Edit_Button_Event_Options()
        {
            testCaseId = "TC-13195";
            qTestUniqueId = "28840458";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateEventsDisabled();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options     
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13196_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options()
        {
            testCaseId = "TC-13196";
            qTestUniqueId = "28840459";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateAlertOptions();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options - High Continuous Consumption - Threshold Description 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13200_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_High_Continuous_Consumption_Threshold_Description()
        {
            testCaseId = "TC-13200";
            qTestUniqueId = "28840463";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThreshHoldCannotBeEdited();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options  - Continuous Consumption - Critical - Threshold Description/Value 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13201_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Critical_Threshold_Description_Value()
        {
            testCaseId = "TC-13201";
            qTestUniqueId = "28840464";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateThreshHoldValue();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options -  Continuous Consumption - Critical - Threshold Value 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13202_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Critical_Threshold_Value()
        {
            testCaseId = "TC-13202";
            qTestUniqueId = "28840465";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateCriticalThreshHoldValueEditable();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options -  Continuous Consumption - Critical - Threshold Value - Input
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13203_Alert_Configuration_Continuous_Consumption_Edi_Button_Alert_Options_Continuous_Consumption_Critical_Threshold_Value_Input()
        {
            testCaseId = "TC-13203";
            qTestUniqueId = "28840466";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateCriticalThreshHoldValueEditable();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options -  Continuous Consumption - Critical - Threshold Description - Updated
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13204_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Critical_Threshold_Description_Updated()
        {
            testCaseId = "TC-13204";
            qTestUniqueId = "28840467";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateThreshHoldValueUpdated();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options -  Continuous Consumption - Critical - Threshold Value - Blank/Empty
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13205_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Critical_Threshold_Value_Blank_Empty()
        {
            testCaseId = "TC-13205";
            qTestUniqueId = "28840468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateThreshHoldValueCanNotBeEmpty();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options -  Continuous Consumption - Critical - Threshold Value - Range
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13206_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Critical_Threshold_Value_Range()
        {
            testCaseId = "TC-13205";
            qTestUniqueId = "28840468";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateThreshHoldValueRange();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options -  Continuous Consumption - Critical - Threshold Value - Out of Range
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13207_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Critical_Threshold_Value_Out_of_Range()
        {
            testCaseId = "TC-13207";
            qTestUniqueId = "28840470";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateThreshHoldValueRange();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options  - Continuous Consumption - Critical - Send Type/Frequency  of Range
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13208_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Critical_Send_Type_Frequency()
        {
            testCaseId = "TC-13208";
            qTestUniqueId = "28840471";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateCriticalActiveMail();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options - Continuous Consumption - Warning -  Threshold Description 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13209_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Warning_Threshold_Description()
        {
            testCaseId = "TC-13209";
            qTestUniqueId = "28840472";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateThreshHoldValueUpdated();
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
        /// Test Method to Alert Configuration - Continuous Consumption - Warning -  Threshold Description/Value 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13210_Alert_Configuration_Continuous_Consumption_Warning_Threshold_Description_Value()
        {
            testCaseId = "TC-13210";
            qTestUniqueId = "28840473";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateThreshHoldValueDescription();
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
        /// Test Method to Alert Configuration - CContinuous Consumption - Edit Button - Alert Options -  Continuous Consumption - Warning -  Threshold Value
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13211_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Warning_Threshold_Value()
        {
            testCaseId = "TC-13211";
            qTestUniqueId = "28840474";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningThreshHoldValueEditable();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Edit Button - Alert Options -  Continuous Consumption - Warning -  Threshold Value - Input
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13212_Alert_Configuration_Continuous_Consumption_Edit_Button_Alert_Options_Continuous_Consumption_Warning_Threshold_Value_Input()
        {
            testCaseId = "TC-13212";
            qTestUniqueId = "28840475";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningThreshHoldValueArrowEditable();
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
        /// Test Method to Alert Configuration -   Continuous Consumption -  Continuous Consumption - Warning -  Threshold Description - Updated - Input
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13213_Alert_Configuration_Continuous_Consumption_Continuous_Consumption_Warning_Threshold_Description_Updated()
        {
            testCaseId = "TC-13213";
            qTestUniqueId = "28840476";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningThreshHoldValueUpdated();
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
        /// Test Method to Alert Configuration -   Continuous Consumption -  CContinuous Consumption - Warning -  Threshold Value - Blank/Empty
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13214_Alert_Configuration_Continuous_Consumption_Warning_Threshold_Value_Blank_Empty()
        {
            testCaseId = "TC-13214";
            qTestUniqueId = "28840477";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningThreshHoldValueEmpty();
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
        /// Test Method to Alert Configuration Continuous Consumption - Warning -  Threshold Value - Range
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13215_Alert_Configuration_Continuous_Consumption_Warning_Threshold_Value_Range()
        {
            testCaseId = "TC-13215";
            qTestUniqueId = "28840478";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningThreshHoldValueEmpty();
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
        /// Test Method to Alert Configuration Continuous Consumption - Warning -  Threshold Value - Out of Range
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13216_Alert_Configuration_Continuous_Consumption_Warning_Threshold_Value_Out_of_Range()
        {
            testCaseId = "TC-13216";
            qTestUniqueId = "28840479";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningThreshHoldValueEmpty();
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
        /// Test Method to Alert Configuration Continuous Consumption Warning -  Send Type/Frequency 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13217_Alert_Configuration_Continuous_Consumption_Warning_Send_Type_Frequency()
        {
            testCaseId = "TC-13217";
            qTestUniqueId = "28840480";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningActiveMail();
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
        /// Test Method to Alert Configuration Continuous Consumption Normal  - Threshold Description 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13218_Alert_Configuration_Continuous_Consumption_Normal_Threshold_Description()
        {
            testCaseId = "TC-13218";
            qTestUniqueId = "28840481";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThreshHoldCannotBeEdited();
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
        /// Test Method to Alert Configuration Continuous Consumption Normal  - Threshold Description/Value 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13219_Alert_Configuration_Continuous_Consumption_Normal_Threshold_Description_Value()
        {
            testCaseId = "TC-13219";
            qTestUniqueId = "28840482";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateWarningThresholdConsumptionDescription();
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
        /// Test Method to Alert Configuration Continuous Consumption Normal  - Threshold Value 
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13220_Alert_Configuration_Continuous_Consumption_Normal_Threshold_Value()
        {
            testCaseId = "TC-13220";
            qTestUniqueId = "28840483";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThreshHoldValueEditable();
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
        /// Test Method to Alert Configuration Continuous Consumption Normal  - Threshold Value - Input 
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13221_Alert_Configuration_Continuous_Consumption_Normal_Threshold_Value_Input()
        {
            testCaseId = "TC-13221";
            qTestUniqueId = "28840484";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThreshHoldValueEditableUp();
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
        /// Test Method to Alert Configuration Continuous Consumption Normal  - Threshold Description - Updated
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13222_Alert_Configuration_Continuous_Consumption_Normal_Threshold_Description_Updated()
        {
            testCaseId = "TC-13222";
            qTestUniqueId = "28840485";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThreshHoldValueENotEmpty();
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
        /// Test Method to Alert Configuration Continuous Consumption Normal  - Threshold Value_Blank_Empty
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13223_Alert_Configuration_Continuous_Consumption_Normal_Threshold_Value_Blank_Empty()
        {
            testCaseId = "TC-13223";
            qTestUniqueId = "28840486";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThreshHoldValueENotEmpty();
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
        /// Test Method to Alert Configuration Continuous Consumption Normal  - Threshold Value - Range
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13224_Alert_Configuration_Continuous_Consumption_Normal_Threshold_Value_Range()
        {
            testCaseId = "TC-13224";
            qTestUniqueId = "28840487";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThreshHoldValueENotEmpty();
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
        /// Test Method to Alert Configuration Continuous Consumption Normal  - Threshold Value - Out of Range
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13225_Alert_Configuration_Continuous_Consumption_Normal_Threshold_Value_Out_of_Range()
        {
            testCaseId = "TC-13225";
            qTestUniqueId = "28840488";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalThreshHoldValueOutOfRange();
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
        /// Test Method to Alert Configuration Continuous Consumption Low Continuous Consumption - Send Type/Frequency 
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13226_Alert_Configuration_Continuous_Consumption_Low_Continuous_Consumption_Send_Type_Frequency()
        {
            testCaseId = "TC-13226";
            qTestUniqueId = "28840489";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateNormalActiveMail();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Done Button - Selected 
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13227_Alert_Configuration_Continuous_Consumption_Done_Button_Selected()
        {
            testCaseId = "TC-13227";
            qTestUniqueId = "28840490";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateToastMessage();
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
        /// Test Method to Alert Configuration Done Button - Selected - Cancel/Done Buttons
        /// </summary>
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13229_Alert_Configuration_Continuous_Done_Button_Selected_Cancel_Done_Buttons()
        {
            testCaseId = "TC-13229";
            qTestUniqueId = "28840492";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateDoneButtonSelectedCancelButton();
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
        /// Test Method to Alert Configuration Done Button - Selected - Edit/Done Buttons
        /// </summary>
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13230_Alert_Configuration_Continuous_Done_Button_Selected_Edi_Done_Buttons()
        {
            testCaseId = "TC-13230";
            qTestUniqueId = "28840493";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateEditDoneButtonEnabled();
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
        /// Test Method to Alert Configuration Done Button - Selected - Alert Options - Updated 
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13231_Alert_Configuration_Continuous_Done_Button_Selected_Alert_Options_Updated()
        {
            testCaseId = "TC-13231";
            qTestUniqueId = "28840494";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateConitnousConsumptionValueEditableUpdated();
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
        /// Test Method to Alert Configuration Done Button - Selected - Success Toast 
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13232_Alert_Configuration_Continuous_Done_Button_Selected_Success_Toast()
        {
            testCaseId = "TC-13232";
            qTestUniqueId = "28840495";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateToastMessage();
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
        /// Test Method to Alert Configuration Cancel Button - Selected - Changed Abandoned 
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13233_Alert_Configuration_Continuous_Cancel_Button_Selected_Changed_Abandoned()
        {
            testCaseId = "TC-13233";
            qTestUniqueId = "28840496";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateChangeAbandoned();
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
        /// Test Method to Alert Configuration Cancel Button - Selected - Cancel/Done Buttons
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13234_Alert_Configuration_Continuous_Cancel_Button_Selected_Cancel_Done_Buttons()
        {
            testCaseId = "TC-13234";
            qTestUniqueId = "28840497";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateChangeAbandonedCancelDoneBtn();
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
        /// Test Method to Alert Configuration Cancel Button - Selected - Edit/Done Buttons
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13235_Alert_Configuration_Continuous_Cancel_Button_Selected_Edit_Done_Buttons()
        {
            testCaseId = "TC-13235";
            qTestUniqueId = "28840498";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateChangeAbandonedCancelDoneBtn();
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
        /// Test Method to Alert Configuration -   Continuous Consumption - Cancel Button - Selected - Edit/Done Buttons
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13236_Alert_Configuration_Continuous_Consumption_Cancel_Button_Selected_Edit_Done_Buttons()
        {
            testCaseId = "TC-13236";
            qTestUniqueId = "28840499";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateAlertOptionsReverted();
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
        /// Test Method to Alert Notification - Events Name/s - All Caps
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13236_AlertNotification_Events_Names_All_Caps()
        {
            testCaseId = "TC-13236";
            qTestUniqueId = "28840499";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateEventAllCaps();
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
        /// Test Method to Alert Configuration -   Major Reverse Flow - Edit Button Disabled
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13736_Alert_Configuration_Major_Reverse_Flow_Edit_Button_Disabled()
        {
            testCaseId = "TC-13736";
            qTestUniqueId = "29815235";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateMajorReverseFlowEditBtnDisabled();
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
        /// Test Method to Alert Configuration -   Major Reverse Flow - Edit Button Disabled
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13737_Alert_Configuration_Major_Reverse_Flow_Edit_Button_Disabled()
        {
            testCaseId = "TC-13737";
            qTestUniqueId = "29815236";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateMajorReverseFlowCritical();
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
        /// Test Method to Alert Configuration - Major Reverse Flow - Alert Options - ALERT ACTIVE
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13787_Alert_Configuration_Major_Reverse_Flow_Alert_Options_ALERT_ACTIVE()
        {
            testCaseId = "TC-13787";
            qTestUniqueId = "29873656";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateMajorReverseFlowAlertActive();
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
        /// Test Method to Alert Configuration - Major Reverse Flow - Alert Options - Send Type and Frequency
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13788_Alert_Configuration_Major_Reverse_Flow_Alert_Options_Send_Type_and_Frequency()
        {
            testCaseId = "TC-13788";
            qTestUniqueId = "29873673";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateMajorReverseFlowAlertActive();
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
        /// Test Method to Alert Configuration -   Major Reverse Flow - Alert Options - Threshold Description
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13741_Alert_Configuration_Major_Reverse_Flow_Alert_Options_Threshold_Description()
        {
            testCaseId = "TC-13741";
            qTestUniqueId = "29815240";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateMajorReverseFlowThresholdDescription();
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
        /// Test Method to Alert Configuration -   Major Reverse Flow - Alert Options -  Major Reverse Flow - Critical - Threshold Value
        [Category("AlertConfiguration")]
        [Test]
        public void TC_13743_Alert_Configuration_Major_Reverse_Flow_Alert_Options_Major_Reverse_Flow_Critical_Threshold_Value()
        {
            testCaseId = "TC-13743";
            qTestUniqueId = "29815243";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateMajorReverseFlowDefaultThresholdValue();
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
        /// Test Method to Alert Configuration -   Major Reverse Flow - Done Button - Enabled
        [Category("AlertConfiguration")]
        [Category("RegressionTests3_AlertConfiguration")]
        [Test]
        public void TC_13784_Alert_Configuration_Major_Reverse_Flow_Done_Button_Enabled()
        {
            testCaseId = "TC-13784";
            qTestUniqueId = "29872968";
            startDate = DateTime.Now; try
            {
                Dictionary<string, string> testData = TestDataFromExcel(testCaseId);
                url = testData["URL"];
                userName = testData["UserName"];
                password = testData["Password"];
                importFile = testData["ImportFile"];
                home.NavigateToLftAlertConfiguration(url, userName, password);
                alertConfigurationPage.ValidateMajorReverseFlowDoneBtnEnabled();
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
