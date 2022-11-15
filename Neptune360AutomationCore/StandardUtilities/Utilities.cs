using EAAutoFramework.Config;
using Neptune360AutomationCore.StandardUtilities;
using System;
using System.Configuration;

namespace Neptune360UIAutomation
{
    public class Utilities
    {

		/// <summary>
		/// Read appSettings section of AppSettings.Json configuration file
		/// </summary>
		/// <param name="Key">appSettings key</param>
		/// <returns>appSettings value</returns>
		public static string ReadConfigFile(string Key)
		{
			try
			{
				return ConfigReader.GetTestData(Key);
			}
			catch(Exception ex)
			{
                throw new Exception(ex.Message);
                return null;
			}
		}

        /// <summary>
		/// Method to encode string to Base64 format
		/// </summary>
		/// <param name="plainText"></param>
		/// <returns></returns>
		public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
