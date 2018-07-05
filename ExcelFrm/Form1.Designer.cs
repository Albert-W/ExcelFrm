namespace ExcelFrm
{
  partial class Form1
  {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.txtExcel = new System.Windows.Forms.TextBox();
            this.BtnChoose = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPre = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnAnswer = new System.Windows.Forms.Button();
            this.LblHint = new System.Windows.Forms.Label();
            this.BtnReview = new System.Windows.Forms.Button();
            this.Btnrestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择Excel文件";
            // 
            // txtExcel
            // 
            this.txtExcel.Location = new System.Drawing.Point(216, 21);
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Size = new System.Drawing.Size(231, 25);
            this.txtExcel.TabIndex = 2;
            // 
            // BtnChoose
            // 
            this.BtnChoose.Location = new System.Drawing.Point(469, 22);
            this.BtnChoose.Name = "BtnChoose";
            this.BtnChoose.Size = new System.Drawing.Size(90, 25);
            this.BtnChoose.TabIndex = 3;
            this.BtnChoose.Text = "选择文件";
            this.BtnChoose.UseVisualStyleBackColor = true;
            this.BtnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(699, 21);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(98, 25);
            this.BtnOpen.TabIndex = 4;
            this.BtnOpen.Text = "打开文件";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Location = new System.Drawing.Point(213, 152);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(159, 15);
            this.LblAnswer.TabIndex = 6;
            this.LblAnswer.Text = "                   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "提示：";
            // 
            // BtnPre
            // 
            this.BtnPre.Location = new System.Drawing.Point(66, 236);
            this.BtnPre.Name = "BtnPre";
            this.BtnPre.Size = new System.Drawing.Size(91, 31);
            this.BtnPre.TabIndex = 9;
            this.BtnPre.Text = "上一项";
            this.BtnPre.UseVisualStyleBackColor = true;
            this.BtnPre.Click += new System.EventHandler(this.BtnPre_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(216, 236);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 31);
            this.BtnNext.TabIndex = 10;
            this.BtnNext.Text = "下一项";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(66, 152);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(91, 25);
            this.BtnAnswer.TabIndex = 11;
            this.BtnAnswer.Text = "显示答案";
            this.BtnAnswer.UseVisualStyleBackColor = true;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // LblHint
            // 
            this.LblHint.AutoSize = true;
            this.LblHint.Location = new System.Drawing.Point(213, 94);
            this.LblHint.Name = "LblHint";
            this.LblHint.Size = new System.Drawing.Size(63, 15);
            this.LblHint.TabIndex = 6;
            this.LblHint.Text = "Default";
            // 
            // BtnReview
            // 
            this.BtnReview.Location = new System.Drawing.Point(580, 22);
            this.BtnReview.Name = "BtnReview";
            this.BtnReview.Size = new System.Drawing.Size(98, 25);
            this.BtnReview.TabIndex = 12;
            this.BtnReview.Text = "开始复习";
            this.BtnReview.UseVisualStyleBackColor = true;
            this.BtnReview.Click += new System.EventHandler(this.BtnReview_Click);
            // 
            // Btnrestart
            // 
            this.Btnrestart.Location = new System.Drawing.Point(580, 84);
            this.Btnrestart.Name = "Btnrestart";
            this.Btnrestart.Size = new System.Drawing.Size(98, 25);
            this.Btnrestart.TabIndex = 12;
            this.Btnrestart.Text = "重新复习";
            this.Btnrestart.UseVisualStyleBackColor = true;
            this.Btnrestart.Click += new System.EventHandler(this.Btnrestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 452);
            this.Controls.Add(this.Btnrestart);
            this.Controls.Add(this.BtnReview);
            this.Controls.Add(this.BtnAnswer);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblHint);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnChoose);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtExcel;
    private System.Windows.Forms.Button BtnChoose;
    private System.Windows.Forms.Button BtnOpen;
    private System.Windows.Forms.Label LblAnswer;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button BtnPre;
    private System.Windows.Forms.Button BtnNext;
    private System.Windows.Forms.Button BtnAnswer;
    private System.Windows.Forms.Label LblHint;
    private System.Windows.Forms.Button BtnReview;
    private System.Windows.Forms.Button Btnrestart;
  }
}

