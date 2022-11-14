using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Neptune360AutomationCore.StandardUtilities
{
    public class ConfigReader
    {
        private static string GetProjectRootDirectory()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "") + "TestData";
            return currentDirectory.Split("bin")[0];
        }
        private static JObject GetTestDataJsonObject()
        {
            string path = Path.Combine(GetProjectRootDirectory(), "TestData","AppSettings.json");
            JObject jObject = JObject.Parse(File.ReadAllText(path));
            return jObject;
        }
        public static string GetTestData(string label)
        {
            var jObject = GetTestDataJsonObject();
            return jObject[label].ToString();
        }
    }
}
