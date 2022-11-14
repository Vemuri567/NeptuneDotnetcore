using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation
{
    public class DeviceManagementPage : AbstractTemplatePage
    {

        #region UI Object Repository
        private By breadcrumb = By.XPath("//span[text()='Device Activations']");
        #endregion
        // <summary>
        /// Method to Validate Group Select
        /// </summary>
        public void ValidateDeviceActivation()
        {
            driver.CheckElementDisplayed(breadcrumb, "Device Activations");
        }
    }
}
