using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ExlInterop = Microsoft.Office.Interop.Excel;

namespace Neptune360UIAutomation
{
    /// <summary>
    /// Author: Pavan Parmar | Date: 2-1-2016
    /// This class is used for Excel operations
    /// </summary>
    public class ExcelReader
    {
        /// <summary>
        /// Method to Read excel file
        /// </summary>
        /// <param name="dataFile">name of the file</param>
        /// <param name="sheetname">sheet name</param>
        /// <param name="isOLEDB">'true' for accessing using OLEDB</param></param>
        /// <returns></returns>
        public static DataTable ReadExcelFile(string dataFile, string sheetname, bool isOLEDB = true)
        {
            DataTable tblExcelData = new DataTable();
            string exlFileName = string.Empty;
            try
            {
                string fileName = dataFile + ".xlsx";
                string testDataFolder = AppDomain.CurrentDomain.BaseDirectory.ToString().Replace("net6.0\\", "") + "TestData";
                string[] drTestdataFiles = Directory.GetFiles(testDataFolder).
                    Where(x => x.EndsWith(".xls") || x.EndsWith(".xlsx")).ToArray();

                foreach (string tstDataFile in drTestdataFiles)
                {
                    exlFileName = tstDataFile.Substring(tstDataFile.LastIndexOf("\\") + 1);
                    if (fileName.Equals(exlFileName))
                    {
                        string exlDataSource = Path.Combine(testDataFolder, exlFileName);
                        if (isOLEDB)
                        {
                            //tblExcelData = ReadExcelUsingOLEDB(exlDataSource);
                            tblExcelData = ReadExcelUsingNPOI(exlDataSource, sheetname);
                        }
                        else
                        {
                            tblExcelData = ReadExcelUsingInterop(exlDataSource, sheetname);
                        }
                        break;
                    }
                }
                tblExcelData.TableName = "TestData";
            }
            catch (Exception)
            {
                //Report.Error(ex.Message.ToString() + "Stack Trace:" + ex.StackTrace.ToString());
                //throw ex;
            }
            return tblExcelData;
        }

        /// <summary>
        /// Method to read excel file using NPOI libraries
        /// </summary>
        /// <param name="exlDataSource">Excel data Source Name</param>
        /// <returns></returns>
        public static DataTable ReadExcelUsingNPOI(string exlDataSource, string sheetName)
        {

            DataTable dt = new DataTable();//dt holds both the empty and data rows of excel sheet
            XSSFWorkbook hssfwb;
            try
            {
                using (FileStream file = new FileStream(exlDataSource, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new XSSFWorkbook(file);
                }

                ISheet sheet = hssfwb.GetSheet(sheetName);
                int rCnt = 0;
                string colValue = string.Empty;
                object cellValue = null;
                for (int row = 0; row <= sheet.LastRowNum; row++)
                {
                    var rowData = sheet.GetRow(row);
                    rCnt++;
                    if (rowData == null)
                        continue;
                    DataRow drow = dt.NewRow();
                    for (int cCnt = 0; cCnt < rowData.LastCellNum; cCnt++)
                    {
                        ICell cellData = rowData.GetCell(cCnt, MissingCellPolicy.RETURN_NULL_AND_BLANK);

                        cellValue = cellData;
                        colValue = cellValue == null ? string.Empty : Convert.ToString(cellValue);
                        //Adding Header Row to DataTable
                        if (rCnt == 1)
                        {
                            dt.Columns.Add(colValue);
                        }
                        else
                        {
                            drow[cCnt] = colValue;
                        }
                    }

                    if (rCnt > 1)
                    {
                        dt.Rows.Add(drow);
                        dt.AcceptChanges();
                    }

                }


            }
            catch (Exception ex)
            {
                //Report.Error(ex.Message.ToString() + "Stack Trace:" + ex.StackTrace.ToString());
                Console.WriteLine("Excelfilenot loading");
                throw ex;
            }

            return dt;
        }

        /// <summary>
        /// Get the name of test case from value of parameters.
        /// </summary>
        /// <param name="diffParam">The difference parameter.</param>
        /// <param name="testParams">The test parameters.</param>
        /// <param name="testCaseName">Name of the test case.</param>
        /// <returns>Test case name</returns>
        /// <exception cref="NullReferenceException">Exception when trying to set test case name</exception>
        private static string TestCaseName(string rowNumber, string[] diffParam, Dictionary<string, string> testParams, string testCaseName)
        {
            foreach (var p in diffParam)
            {
                string keyValue;

                bool keyFlag = testParams.TryGetValue(p, out keyValue);

                if (keyFlag)
                {
                    testCaseName += "_" + Regex.Replace(keyValue, "[^0-9a-zA-Z]+", "_");
                    testCaseName = testCaseName.Replace(",", "_");

                }
                else
                {
                    throw new Exception(p);
                }
            }

            return rowNumber + "_" + testCaseName;
        }

        public static IEnumerable<TestCaseData> ReadXlsxDataDriveFile(string DataDriveFile, string sheetName, [Optional] string[] diffParam, [Optional] string testName)
        {
            XSSFWorkbook wb;
            string rownumber = null;
            using (var fs = new FileStream(DataDriveFile, FileMode.Open, FileAccess.Read))
            {
                wb = new XSSFWorkbook(fs);
            }

            // get sheet
            var sh = (XSSFSheet)wb.GetSheet(sheetName);

            int startRow = 1;
            int startCol = 0;
            int totalRows = sh.LastRowNum;
            int totalCols = sh.GetRow(0).LastCellNum;

            var row = 1;
            for (int i = startRow; i <= totalRows; i++, row++)
            {
                var column = 0;
                var testParams = new Dictionary<string, string>();
                for (int j = startCol; j < totalCols; j++, column++)
                {
                    rownumber = (row + 1).ToString();
                    if (sh.GetRow(0).GetCell(column).CellType != CellType.String)
                    {
                        throw new InvalidOperationException(string.Format("Cell with name of parameter must be string only, file {0} at sheet {1} row {2} column {3}", DataDriveFile, sheetName, 0, column));
                    }
                    if (sh.GetRow(row).GetCell(column).CellType == CellType.Blank)
                    {
                        sh.GetRow(row).GetCell(column).SetCellValue(0);
                    }
                    if (sh.GetRow(row).GetCell(column).CellType == CellType.Boolean)
                    {


                    }
                    var cellType = sh.GetRow(row).GetCell(column).CellType;
                    switch (cellType)
                    {
                        case CellType.Blank:
                            testParams.Add(sh.GetRow(0).GetCell(column).StringCellValue, "");
                            break;
                        case CellType.String:
                            testParams.Add(sh.GetRow(0).GetCell(column).StringCellValue, Convert.ToString(sh.GetRow(row).GetCell(column).StringCellValue));
                            break;
                        case CellType.Numeric:
                            testParams.Add(sh.GetRow(0).GetCell(column).StringCellValue, sh.GetRow(row).GetCell(column).NumericCellValue.ToString(CultureInfo.CurrentCulture));
                            break;
                        default:
                            throw new InvalidOperationException(string.Format("Not supported cell type {0} in file {1} at sheet {2} row {3} column {4}", cellType, DataDriveFile, sheetName, row, column));
                    }
                }
                if (testParams["Execution"] == "Y")
                {
                    // set test name
                    var testCaseName = string.IsNullOrEmpty(testName) ? sheetName : testName;
                    try
                    {
                        testCaseName = TestCaseName(rownumber, diffParam, testParams, testCaseName);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(
                            string.Format(
                                " Exception while reading Excel Data Driven file\n searched key '{0}' not found at sheet '{1}' \n for test {2} in file '{3}' at row {4}",
                                e.Message,
                                sheetName,
                                testName,
                                DataDriveFile,
                                row));
                    }


                    var data = new TestCaseData(testParams);
                    data.SetName(testCaseName);
                    yield return data;
                }
            }
        }

        /// <summary>
        /// Method to read excel file using OLEDB provider
        /// </summary>
        /// <param name="exlDataSource">Excel data Source Name</param>
        /// <returns></returns>
        public static DataTable ReadExcelUsingOLEDB(string exlDataSource)
        {
            OleDbConnection ocon; OleDbDataAdapter oda;
            DataTable tblExcelSchema;
            string sheetName = string.Empty;
            //dt holds both the empty and data rows of excel sheet
            DataTable dt = new DataTable();

            try
            {
                //OLEDB connection string
                string excelConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + exlDataSource + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'";
                ocon = new OleDbConnection(excelConn);
                ocon.Open();
                tblExcelSchema = ocon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                sheetName = tblExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                oda = new OleDbDataAdapter("select * from [" + sheetName + "]", ocon);
                dt.TableName = "TestData";
                oda.Fill(dt);
                ocon.Close();
            }
            catch (Exception)
            {
                //Report.Error(ex.Message.ToString() + "Stack Trace:" + ex.StackTrace.ToString());
                //throw ex;

            }
            return dt;
        }


        /// <summary>
        /// Method to read excel using Interop
        /// </summary>
        /// <param name="exlDataSource">Interop data source</param>
        /// <param name="sheetname">sheet name<object cellValue = null;/param>
        /// <returns></returns>
        public static DataTable ReadExcelUsingInterop(string exlDataSource, string sheetname)
        {
            ExlInterop.Application exlApp = new ExlInterop.Application();
            ExlInterop.Workbook exlWb = null;
            ExlInterop.Worksheet exlSheet;
            object misValue = System.Reflection.Missing.Value;
            int rCnt = 0; int cCnt = 0;

            string colValue = string.Empty;
            object cellValue = null;

            //dt holds both the empty and data rows of excel sheet
            DataTable dt = new DataTable();

            try
            {
                exlWb = exlApp.Workbooks.Open(exlDataSource);

                int numSheets = exlWb.Sheets.Count;
                for (int sheetNum = 1; sheetNum < numSheets + 1; sheetNum++)
                {
                    exlSheet = (ExlInterop.Worksheet)exlWb.Sheets[sheetNum];
                    string strWorksheetName = exlSheet.Name;

                    exlWb.RefreshAll();
                    if (strWorksheetName.Equals(sheetname))
                    {
                        ExlInterop.Range range = exlSheet.UsedRange;
                        //                ExlInterop.Range range = exlSheet.UsedRange.SpecialCells(
                        //                               ExlInterop.XlCellType.xlCellTypeVisible,
                        //                               Type.Missing);
                        for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
                        {
                            DataRow drow = dt.NewRow();
                            for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
                            {
                                cellValue = (range.Cells[rCnt, cCnt] as ExlInterop.Range).Value2;
                                colValue = cellValue == null ? string.Empty : Convert.ToString(cellValue);
                                //Adding Header Row to DataTable
                                if (rCnt == 1)
                                {
                                    dt.Columns.Add(colValue);
                                }
                                else
                                {
                                    drow[cCnt - 1] = colValue;
                                }
                            }
                            if (rCnt > 1)
                            {
                                dt.Rows.Add(drow);
                                dt.AcceptChanges();
                            }
                        }

                    }

                }
            }
            catch (Exception)
            {
                //Report.Error(ex.Message.ToString() + "Stack Trace:" + ex.StackTrace.ToString());
                //throw ex;

            }
            finally
            {
                exlWb.Close(false, misValue, misValue);
                exlApp.Quit();
                releaseProcessObject(exlWb);
                releaseProcessObject(exlApp);
            }
            return dt;

        }


        /// <summary>
        /// Method to release excel objects from memory
        /// </summary>
        /// <param name="obj"></param>
        private static void releaseProcessObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                //obj = null;
                //Report.Error(ex.Message.ToString() + "Stack Trace:" + ex.StackTrace.ToString());
                //throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
