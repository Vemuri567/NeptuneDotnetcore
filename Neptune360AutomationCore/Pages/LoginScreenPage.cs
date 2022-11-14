using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class LoginScreenPage : AbstractTemplatePage
    {

        #region UI Object Repository
        private By neptune360Logo = By.XPath("//img[contains(@src,'/images/Neptune_360_Logo')]");
        private By forgotyourPwd = By.LinkText("Forgot your password?");
        #endregion

        /// <summary>
        /// Method to Validate Neptune360Logo
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidateNeptune360Logo()
        {
            driver.WaitForElement(neptune360Logo, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Logo, "Neptune 360 Logo");
        }

        /// <summary>
        /// Method to Validate Password Reset Screen
        /// @Author - Gurudas Puthal
        /// </summary>
        public void ValidatePasswordResetScreen()
        {
            driver.WaitForElement(forgotyourPwd, TimeSpan.FromSeconds(10));
            driver.ClickElement(forgotyourPwd, "Gorgot Your Password");
            driver.WaitForElement(neptune360Logo, TimeSpan.FromSeconds(10));
            driver.CheckElementDisplayed(neptune360Logo, "Neptune 360 Logo");
        }
    }
}
