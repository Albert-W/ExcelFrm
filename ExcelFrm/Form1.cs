using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelFrm
{
  public partial class Form1 : Form
  {
    private static DataTable dtexcel = null;
    //private static string rowsnumber = "";
    private static int number = 0;


    public Form1()
    {
      InitializeComponent();
    }

    private void BtnChoose_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog dialog = new OpenFileDialog())
      {
        dialog.Multiselect = true;
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          try
          {
            this.txtExcel.Text = dialog.FileName;
            if (this.txtExcel.Text != "")
            {
              string path = this.txtExcel.Text;
              dtexcel = ExcelHelperEpplus.ReadExcelToDataSet(path, 1).Tables[0];
              //dtexcel = ExcelHelperEpplus.ReadExcelToDataSet(path, "Sheet1").Tables[0];
              //rowsnumber = Settings.Instance.RowsNumber;

              string SQL = "SELECT * FROM excelInfo WHERE excelName =@excelName";
              SQLiteParameter p = new SQLiteParameter("@excelName", this.txtExcel.Text);
              DataTable dt = DBUtility.DbHelperSQLite.Query(SQL, p).Tables[0];
              if (dt.Rows.Count == 0)
              {
                string SQLinsert = "INSERT INTO excelInfo (excelName,excelNumber) VALUES (@excelName,0)";
                dt = DBUtility.DbHelperSQLite.Query(SQLinsert, p).Tables[0];
              }
              else
              {
                number = Convert.ToInt32(dt.Rows[0][1]);
                //number = (int)dt.Rows[0][1]; 报IO异常；
              }
              
            }
          }
          catch (Exception ex)
          {
            throw (ex);
          }
        }
      }
    }

    private void BtnOpen_Click(object sender, EventArgs e)
    {
      Excel.Application excel = new Excel.Application();
      string strPath = this.txtExcel.Text;
      Excel.Workbook wBook = excel.Application.Workbooks.Add(strPath);
      excel.Visible = true;
    }

    private void BtnReview_Click(object sender, EventArgs e)
    {
      if (this.txtExcel.Text != "")
      {

        //number = Convert.ToInt32(rowsnumber);
        //DataTable dtExcel = ExcelHelperEpplus.ReadExcelToDataSet(path, "Sheet1").Tables[0];
        this.LblHint.Text = dtexcel.Rows[number][0].ToString();
        this.LblAnswer.Text = "";
        //this.LblAnswer.Text = dtexcel.Rows[number][1].ToString();

      }
    }

    private void BtnPre_Click(object sender, EventArgs e)
    {
      if (number >= 1)
      {
        number--;
        this.LblHint.Text = dtexcel.Rows[number][0].ToString();
        this.LblAnswer.Text = "";
        //this.LblAnswer.Text = dtexcel.Rows[number][1].ToString();
      }
      
    }

    private void BtnNext_Click(object sender, EventArgs e)
    {
      number++;
      this.LblHint.Text = dtexcel.Rows[number][0].ToString();
      this.LblAnswer.Text = "";
      //this.LblAnswer.Text = dtexcel.Rows[number][1].ToString();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      //Settings.setConfig("RowsNumber", number.ToString());
      string SQLupdate = "UPDATE excelInfo set excelNumber= @excelNumber WHERE excelName = @excelName";
      SQLiteParameter p = new SQLiteParameter("@excelName", this.txtExcel.Text);
      SQLiteParameter p1 = new SQLiteParameter("@excelNumber", number);
      DBUtility.DbHelperSQLite.ExecuteSql(SQLupdate, p1, p);
      //DataTable dt2= DBUtility.DbHelperSQLite.Query(SQLupdate, p1, p).Tables[0];

    }

    private void BtnAnswer_Click(object sender, EventArgs e)
    {
      this.LblAnswer.Text = dtexcel.Rows[number][1].ToString();
    }

    private void Btnrestart_Click(object sender, EventArgs e)
    {
      number = 0;
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
