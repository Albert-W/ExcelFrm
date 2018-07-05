using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OfficeOpenXml;
using System.IO;

namespace ExcelFrm
{
   public partial class ExcelHelperEpplus
    {

        #region 读取Excel数据到DataSet
        /// <summary>  
        /// 读取Excel数据到DataSet  
        /// </summary>  
        /// <param name="filePath">The file path.</param>  
        /// <returns></returns>  
       public static DataSet ReadExcelToDataSet(string filePath, string sheetName)
        {
            DataSet ds = new DataSet("ds");
            DataRow dr;
            object objCellValue;
            string cellValue;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            using (ExcelPackage package = new ExcelPackage())
            {
                package.Load(fs);
                var sheet = package.Workbook.Worksheets[sheetName];
                
                    
                    var columnCount = sheet.Dimension.End.Column;
                    var rowCount = sheet.Dimension.End.Row;
                    if (rowCount > 0)
                    {
                        DataTable dt = new DataTable(sheet.Name);
                        for (int j = 0; j < columnCount; j++)//设置DataTable列名  
                        {
                            objCellValue = sheet.Cells[1, j + 1].Value;
                            cellValue = objCellValue == null ? "" : objCellValue.ToString();
                            dt.Columns.Add(cellValue, typeof(string));
                        }
                        for (int i = 2; i <= rowCount; i++)
                        {
                            dr = dt.NewRow();
                            for (int j = 1; j <= columnCount; j++)
                            {
                                objCellValue = sheet.Cells[i, j].Value;
                                cellValue = objCellValue == null ? "" : objCellValue.ToString();
                                dr[j - 1] = cellValue;
                            }
                            dt.Rows.Add(dr);
                        }
                        ds.Tables.Add(dt);
                    }
                
            }
            return ds;

        }
    #endregion

    

    #region 读取Excel数据到DataSet
    /// <summary>  
    /// 读取Excel数据到DataSet  
    /// </summary>  
    /// <param name="filePath">The file path.</param>  
    /// <returns></returns>  
    public static DataSet ReadExcelToDataSet(string filePath)
        {
            DataSet ds = new DataSet("ds");
            DataRow dr;
            object objCellValue;
            string cellValue;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            using (ExcelPackage package = new ExcelPackage())
            {
                package.Load(fs);
                foreach (var sheet in package.Workbook.Worksheets)
                {
                    if (sheet.Dimension == null) continue;
                    var columnCount = sheet.Dimension.End.Column;
                    var rowCount = sheet.Dimension.End.Row;
                    if (rowCount > 0)
                    {
                        DataTable dt = new DataTable(sheet.Name);
                        for (int j = 0; j < columnCount; j++)//设置DataTable列名  
                        {
                            objCellValue = sheet.Cells[1, j + 1].Value;
                            cellValue = objCellValue == null ? "" : objCellValue.ToString();
                            dt.Columns.Add(cellValue, typeof(string));
                        }
                        for (int i = 2; i <= rowCount; i++)
                        {
                            dr = dt.NewRow();
                            for (int j = 1; j <= columnCount; j++)
                            {
                                objCellValue = sheet.Cells[i, j].Value;
                                cellValue = objCellValue == null ? "" : objCellValue.ToString();
                                dr[j - 1] = cellValue;
                            }
                            dt.Rows.Add(dr);
                        }
                        ds.Tables.Add(dt);
                    }
                }
            }
            return ds;

        }
        #endregion  


          private static string GetString(object obj)
        {
            try
            {
                return obj.ToString();
            }
            catch (Exception ex)
            {
              throw (ex);
              //return "";
            }
        }

         /// <summary>
        ///将指定的Excel的文件转换成DataTable （Excel的第一个sheet）
        /// </summary>
        /// <param name="fullFielPath">文件的绝对路径</param>
        /// <returns></returns>
        public static DataTable WorksheetToTable(string fullFielPath,string sheet)
        {
            try
            {
                FileInfo existingFile = new FileInfo(fullFielPath);
 
                ExcelPackage package = new ExcelPackage(existingFile);
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheet];//选定 指定页
 
                return WorksheetToTable(worksheet);
            }
            catch (Exception)
            {
                throw;
            }
        }
 
        /// <summary>
        /// 将worksheet转成datatable
        /// </summary>
        /// <param name="worksheet">待处理的worksheet</param>
        /// <returns>返回处理后的datatable</returns>
        public static DataTable WorksheetToTable(ExcelWorksheet worksheet)
        {
            //获取worksheet的行数
            int rows = worksheet.Dimension.End.Row;
            //获取worksheet的列数
            int cols = worksheet.Dimension.End.Column;
 
            DataTable dt = new DataTable(worksheet.Name);
            DataRow dr = null;
            for (int i = 1; i <= rows; i++)
            {
                if (i > 1)
                    dr = dt.Rows.Add();
 
                for (int j = 1; j <= cols; j++)
                {
                    //默认将第一行设置为datatable的标题
                    if (i == 1)
                        dt.Columns.Add(GetString(worksheet.Cells[i, j].Value));
                    //剩下的写入datatable
                    else
                        dr[j - 1] = GetString(worksheet.Cells[i, j].Value);
                }
            }
            return dt;
        }
    }
}

