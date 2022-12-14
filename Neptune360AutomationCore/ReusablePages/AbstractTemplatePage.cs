using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace Neptune360UIAutomation
{
    public abstract class AbstractTemplatePage
    {
        protected IWebDriver driver = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractTemplatePage"/> class.
        /// </summary>
        protected AbstractTemplatePage()
        {
            this.driver = WebDriverFactory.getWebDriver();
        }

        /// <summary>
        /// Gets the testreport.
        /// </summary>
        /// <value>
        /// The testreport.
        /// </value>
        protected ExtentTest testReport
        {
            get { return ReporterFactory.TestReport; }
        }

        /// <summary>
        /// Gets the screenshotfile.
        /// </summary>
        /// <value>
        /// The screenshotfile.
        /// </value>
        protected string SCREENSHOTFILE
        {
            get { return EngineSetup.GetScreenShotPath(); }
        }


        /// <summary>
        /// Method used for reporting API results
        /// </summary>
        /// <param name="fieldName">API field Name</param>
        /// <param name="expectedValue">Expected Value</param>
        /// <param name="actualValue">LO Transaction Value</param>
        /// <param name="status">Pass/Fail</param>
        private void logResult(string fieldName, string expectedValue, string actualValue, string status = "Pass")
        {
            //if (status.Equals("Pass"))
            //    this.TESTREPORT.LogSuccess("VerifyUserTransaction - " + fieldName, String.Format("{0}: <mark>{1}</mark> matches with the L.O transaction {2}: <mark>{3}</mark>", fieldName, expectedValue, fieldName, actualValue));
            //else
            //    this.TESTREPORT.LogFailure("VerifyUserTransaction - " + fieldName, String.Format("{0}: <mark>{1}</mark> does not match with the L.O transaction {2}: <mark>{3}</mark>", fieldName, expectedValue, fieldName, actualValue));

        }

        /// <summary>
        /// Validates the not null or empty.
        /// </summary>
        /// <param name="text">The text.</param>
        protected void ValidateNotNullOrEmpty(string text)
        {
            //this.TESTREPORT.LogInfo(String.Format("Text - {0} Will Be Verified For Not Null And Empty", text));
            //if (string.IsNullOrEmpty(text)) //fail
            //{
            //    this.TESTREPORT.LogFailure("ValidateNotNullOrEmpty", String.Format("Expected Text - NotNullOrEmpty, Actual Text - <mark>{0}</mark> ", text), this.SCREENSHOTFILE);
            //}
            //else
            //{
            //    this.TESTREPORT.LogSuccess("ValidateNotNullOrEmpty", String.Format("Expected Text - NotNullOrEmpty, Actual Text - <mark>{0}</mark> ", text));
            //}
            //this.TESTREPORT.LogInfo(String.Format("Text - {0} Was Verified For Not Null And Empty", text));
        }


        /// <summary>
        /// Waits the till element exists.
        /// </summary>
        /// <param name="by">The by.</param>
        /// <param name="locator">The locator.</param>
        /// <param name="timeOutInSecs">The time out in secs.</param>
        protected void WaitTillElementExists(By by, string locator = "", int timeOutInSecs = EngineSetup.TimeOutConstant)
        {
            try
            {
                OpenQA.Selenium.Support.UI.WebDriverWait webDriverCondWait = new OpenQA.Selenium.Support.UI.WebDriverWait(this.driver, TimeSpan.FromSeconds(timeOutInSecs));
                try
                {
                    webDriverCondWait.Until(ExpectedConditions.ElementExists(by));
                    this.driver.Highlight(by);

                    // this.TESTREPORT.LogSuccess("WaitTillElementExists", String.Format("Control <mark>{0}</mark> - <mark>{1}</mark> Was Found Within <mark>{2}</mark> Secs", locator, by.ToString(), timeOutInSecs));

                }
                catch (WebDriverTimeoutException)
                {

                    //this.TESTREPORT.LogInfo(String.Format("Control <mark>{0}</mark> - <mark>{1}</mark> Was Not Found Within <mark>{2}</mark> Secs", locator, by.ToString(), timeOutInSecs));
                }

            }
            catch (Exception)
            {

                //this.TESTREPORT.LogException(ex, this.SCREENSHOTFILE);
            }
        }

        /// <summary>
        /// Waits the till element disappeared.
        /// </summary>
        /// <param name="by">The by.</param>
        /// <param name="locator">The locator.</param>
        /// <param name="timeOut">The time out.</param>
        protected void WaitTillElementDisappeared(By by, string locator = "", int timeOut = EngineSetup.TimeOutConstant)
        {
            try
            {
                //if locator english form not provided then convert given object identification to english form
                locator = locator.Trim().Equals("") ? by.ToString() : locator;

                OpenQA.Selenium.Support.UI.WebDriverWait webDriverCondWait = new OpenQA.Selenium.Support.UI.WebDriverWait(this.driver, TimeSpan.FromSeconds(timeOut));
                try
                {
                    webDriverCondWait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));

                    //this.TESTREPORT.LogSuccess("WaitTillElementDisappeared", String.Format("Expected Element <mark>{0}</mark> Disappeared Within <mark>{1}</mark> Secs", locator, timeOut));

                }
                catch (WebDriverTimeoutException)
                {

                    //this.TESTREPORT.LogFailure("WaitTillElementDisappeared", String.Format("Expected Element To Disappear, but Element <mark>{0}</mark> still exists After <mark>{1}</mark> Secs", locator, timeOut), this.SCREENSHOTFILE);

                }
            }
            catch (Exception)
            {

                //this.TESTREPORT.LogException(ex);
            }


        }

        /// <summary>
        /// Verifies the values against by objects.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyPairTemplateNameExpectedValue">The key pair template name expected value.</param>
        /// <param name="objectIdPattern">The object identifier pattern.</param>
        /// <param name="timeOutInSecs">The time out in secs.</param>
        /// <param name="isPageRefreshRequired">if set to <c>true</c> [is page refresh required].</param>
        protected virtual void VerifyValuesAgainstByObjects<T>(Dictionary<T, string> keyPairTemplateNameExpectedValue, string objectIdPattern, int timeOutInSecs = 5, bool isPageRefreshRequired = false)
        {

            foreach (KeyValuePair<T, string> kvPair in keyPairTemplateNameExpectedValue)
            {

                try
                {
                    //get labelName from keyvalue pair                
                    object label = kvPair.Key;
                    //create By Locator at runtime
                    By by = null;
                    if (label is string)
                    {
                        by = By.XPath(String.Format(objectIdPattern, (string)label));
                    }
                    else if (label is By)
                    {
                        by = (By)label;
                    }

                    //get expected value from keyvalue pair
                    string expectedValue = kvPair.Value;
                    this.WaitTillElementExists(by, "", timeOutInSecs);
                    if (this.driver.FindElements(by).Count > 0)
                    {
                        this.driver.Highlight(by);
                        try
                        {
                            //get actual value
                            string actualValue = this.driver.GetElementText(by);

                            //log the result
                            if (!actualValue.Trim().Contains(expectedValue.Trim()) && isPageRefreshRequired == false) //fail
                            {

                                //this.TESTREPORT.LogFailure("VerifyValuesAgainstByObjects", String.Format("Content In Control - <mark>{0}</mark> Does Not Match With Expected Within <mark>{3}</mark> Secs. Expected - <mark>{1}</mark> , Actual - <mark>{2}</mark>", by.ToString(), expectedValue, actualValue, timeOutInSecs), this.SCREENSHOTFILE);
                            }
                            else if (!actualValue.Trim().Contains(expectedValue.Trim()) && isPageRefreshRequired == true)
                            {
                                int MAXTIMEOUT = timeOutInSecs * 1000;
                                int elapsedTimeout = 0;
                                while (!actualValue.Trim().Contains(expectedValue.Trim()) && elapsedTimeout < MAXTIMEOUT)
                                {
                                    this.driver.RefreshPage();
                                    this.WaitTillElementExists(by, "", timeOutInSecs);
                                    actualValue = this.driver.GetElementText(by);
                                    elapsedTimeout = elapsedTimeout + 1000;
                                }
                                if (!actualValue.Trim().Contains(expectedValue.Trim()))
                                {
                                    //this.TESTREPORT.LogFailure("VerifyValuesAgainstByObjects", String.Format("Content In Control - <mark>{0}</mark> Does Not Match With Expected Within <mark>{3}</mark> Secs. Expected - <mark>{1}</mark> , Actual - <mark>{2}</mark>", by.ToString(), expectedValue, actualValue, timeOutInSecs), this.SCREENSHOTFILE);
                                }
                            }
                            else //pass
                            {

                                //this.TESTREPORT.LogSuccess("VerifyValuesAgainstByObjects", String.Format("Content In Control - <mark>{0}</mark> Matches With Expected Within <mark>{3}</mark> Secs. Expected - <mark>{1}</mark> , Actual - <mark>{2}</mark>", by.ToString(), expectedValue, actualValue, timeOutInSecs));
                            }
                        }
                        catch (Exception)
                        {

                            //this.TESTREPORT.LogException(ex);
                        }
                    }
                    else
                    {

                        //this.TESTREPORT.LogFailure("VerifyValuesAgainstByObjects", String.Format("The Element - <mark>{0}</mark> Was Not Found", by.ToString()), this.SCREENSHOTFILE);
                    }
                }
                catch (Exception)
                {
                    //this.TESTREPORT.LogException(ex);
                }

            }
            keyPairTemplateNameExpectedValue.Clear();
        }

        /// <summary>
        /// Verifies the objects presence.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listObjects">The list objects.</param>
        /// <param name="timeOutInSecs">The time out in secs.</param>
        /// <param name="isPageRefreshRequired">if set to <c>true</c> [is page refresh required].</param>
        protected virtual void VerifyObjectsPresence<T>(List<T> listObjects, int timeOutInSecs = 5, bool isPageRefreshRequired = false)
        {
            foreach (T listItem in listObjects)
            {

                try
                {

                    By by = null;
                    if (listItem is string)
                    {
                        by = By.XPath(String.Format("{0}", listItem));
                    }
                    else if (listItem is By)
                    {
                        object o = listItem;
                        by = (By)o;
                    }

                    //get expected value from keyvalue pair

                    this.WaitTillElementExists(by, by.ToString(), timeOutInSecs);
                    if (this.driver.FindElements(by).Count > 0)
                    {
                        this.driver.Highlight(by);
                        try
                        {

                            //log the result
                            if (!this.driver.ElementPresent(by, by.ToString()) && isPageRefreshRequired == false) //fail
                            {

                                //this.TESTREPORT.LogFailure("VerifyObjectsPresence", String.Format("Object -  <mark>{0}</mark> Was Not Found  Within <mark>{1}</mark> Secs.", by.ToString(), timeOutInSecs), this.SCREENSHOTFILE);
                            }
                            else if (!this.driver.ElementPresent(by, by.ToString()) && isPageRefreshRequired == true)
                            {
                                int MAXTIMEOUT = timeOutInSecs * 1000;
                                int elapsedTimeout = 0;
                                while (!this.driver.ElementPresent(by, by.ToString()) && elapsedTimeout < MAXTIMEOUT)
                                {
                                    this.driver.RefreshPage();
                                    this.WaitTillElementExists(by, by.ToString(), timeOutInSecs);

                                    elapsedTimeout = elapsedTimeout + 1000;
                                }
                                if (!this.driver.ElementPresent(by, by.ToString()))
                                {
                                    //this.TESTREPORT.LogFailure("VerifyObjectsPresence", String.Format("Object -  <mark>{0}</mark> Was Not Found  Within <mark>{1}</mark> Secs.", by.ToString(), timeOutInSecs), this.SCREENSHOTFILE);
                                }
                            }
                            else //pass
                            {

                                // this.TESTREPORT.LogSuccess("VerifyObjectsPresence", String.Format("Object -  <mark>{0}</mark> Was Found  Within <mark>{1}</mark> Secs.", by.ToString(), timeOutInSecs));
                            }
                        }
                        catch (Exception)
                        {

                            //this.TESTREPORT.LogException(ex);
                        }
                    }
                    else
                    {

                        //this.TESTREPORT.LogFailure("VerifyObjectsPresence", String.Format("Object - <mark>{0}</mark> Was Not Found  Within <mark>{1}</mark> Secs.", by.ToString(), timeOutInSecs), this.SCREENSHOTFILE);
                    }
                }
                catch (Exception)
                {
                    //this.TESTREPORT.LogException(ex);
                }

            }
            listObjects.Clear();

        }

        /// <summary>
        /// Simulates the think time in milli secs.
        /// </summary>
        /// <param name="milliSecs">The milli secs.</param>
        protected void SimulateThinkTimeInMilliSecs(int milliSecs)
        {
            Thread.Sleep(milliSecs);
            // this.TESTREPORT.LogSuccess("SimulateThinkTimeInMilliSecs", String.Format("Wait Introduced For <mark>{0}</mark> milliseconds", milliSecs));
        }

        /// <summary>
        /// Simulates the send keys.
        /// </summary>
        /// <param name="chars">The chars.</param>
        protected void SimulateSendKeys(string chars)
        {
            try
            {
                Actions action = new Actions(driver);
                action.SendKeys(chars);
                //SendKeys.SendWait(chars);
                //this.TESTREPORT.LogSuccess("SimulateSendKeys", String.Format("Invoked SendKeys.SendWait for input - <mark>{0}</mark>", chars));
            }

            catch (Exception)
            {

                //this.TESTREPORT.LogFailure("SimulateSendKeys", String.Format("Error While Invoking SendKeys.SendWait for input - <mark>{0}</mark>", chars));
                //this.TESTREPORT.LogException(ex, this.SCREENSHOTFILE);
            }
        }


        /// <summary>
        /// Verify the presence of text in a read only collection
        /// </summary>
        /// <param name="table">table</param>
        /// <param name="findtext">search text</param>
        protected bool CheckTextPresenceInTable(IReadOnlyCollection<IWebElement> table, string findtext)
        {
            try
            {
                bool flag = false;
                foreach (var txt in table)
                {
                    if (txt.Text.Contains(findtext))
                    {
                        //this.TESTREPORT.LogSuccess("CheckTextPresenceInTable", String.Format("Found <mark>{0}</mark> in the table successfully", findtext));
                        flag = true;
                        return true;
                    }

                }

                if (!flag)
                {
                    //this.TESTREPORT.LogFailure("CheckTextPresenceInTable", String.Format("Unable to find text in table - <mark>{0}</mark>", findtext));
                }

                return false;

            }
            catch (Exception)
            {
                //this.TESTREPORT.LogFailure("CheckTextPresenceInTable", String.Format("Error While finding text in table - <mark>{0}</mark>", findtext));
                //this.TESTREPORT.LogException(ex, this.SCREENSHOTFILE);
                return false;
            }

        }
    }
}
