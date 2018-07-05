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
    public static DataSet ReadExcelToDataSet(string filePath, int sheetNum)
    {
      DataSet ds = new DataSet("ds");
      DataRow dr;
      object objCellValue;
      string cellValue;
      using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
      using (ExcelPackage package = new ExcelPackage())
      {
        package.Load(fs);
        var sheet = package.Workbook.Worksheets[sheetNum];


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
  }
}
