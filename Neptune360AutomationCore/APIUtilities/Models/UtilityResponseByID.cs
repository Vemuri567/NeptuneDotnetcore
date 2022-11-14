using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptune360UIAutomation.APIUtilities.Models
{
    public class UtilityResponseByID
    {
        public int utilityId { get; set; }
        public string utilityName { get; set; }
        public bool isActive { get; set; }
        public int parentUtilityId { get; set; }
        public string code { get; set; }
        public bool isDstEnabled { get; set; }
        public string timeZone { get; set; }
        public int timestampId { get; set; }
        public bool applyUTCOffset { get; set; }
        public string siteId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public int transmitFrequency { get; set; }
        public int receiveFrequency { get; set; }
        public int systemId { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string uom { get; set; }
        public string importFileVersion { get; set; }
        public bool closeOnExport { get; set; }
        public int autoCompleteDays { get; set; }
        public bool mobileMapping { get; set; }
        public bool handheldSupport { get; set; }
        public bool handheldEulaAccepted { get; set; }
        public int handheldEulaUserId { get; set; }
        public int dataRetentionYears { get; set; }
        public DateTime oldestDataPointDate { get; set; }
        public bool importByLine { get; set; }
        public bool dataTranslation { get; set; }
        public bool skipOpenRoutes { get; set; }
        public bool sftpFileProcessing { get; set; }
        public bool copyImportErrorLogsToSftp { get; set; }
        public bool copyExportToSftp { get; set; }
        public int maxImports { get; set; }
        public string sftpEmail { get; set; }
        public string domainUrl { get; set; }
        public bool autobilling { get; set; }
        public bool geocoding { get; set; }
        public bool cellularDevices { get; set; }
        public string duplicateMiuIds { get; set; }
        public string blankMiuIds { get; set; }
        public bool emailErrorsWarnings { get; set; }
        public bool isTwoFactorEnabled { get; set; }
        public List<UtilityCodeType> utilityCodeTypes { get; set; }
    }
    public class UtilityCodeType
    {
        public int utilityCodeTypeId { get; set; }
        public int typeId { get; set; }
        public int utilityId { get; set; }
        public string type { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public object referenceId { get; set; }
    }

}
