namespace NIKE专卖店销售系统
{
    partial class SaleInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_rowCount = new System.Windows.Forms.Label();
            this.cb_timeRang = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_guider = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_saleInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_rows = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_rowCount);
            this.groupBox1.Controls.Add(this.cb_timeRang);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtp_end);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_guider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计条件";
            // 
            // lbl_rowCount
            // 
            this.lbl_rowCount.AutoSize = true;
            this.lbl_rowCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_rowCount.Location = new System.Drawing.Point(414, 50);
            this.lbl_rowCount.Name = "lbl_rowCount";
            this.lbl_rowCount.Size = new System.Drawing.Size(0, 22);
            this.lbl_rowCount.TabIndex = 15;
            // 
            // cb_timeRang
            // 
            this.cb_timeRang.FormattingEnabled = true;
            this.cb_timeRang.Items.AddRange(new object[] {
            "全部",
            "本日",
            "本周",
            "本月",
            "本年"});
            this.cb_timeRang.Location = new System.Drawing.Point(479, 20);
            this.cb_timeRang.Name = "cb_timeRang";
            this.cb_timeRang.Size = new System.Drawing.Size(59, 20);
            this.cb_timeRang.TabIndex = 14;
            this.cb_timeRang.Text = "全部";
            this.cb_timeRang.SelectedIndexChanged += new System.EventHandler(this.cb_timeRang_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(575, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_end
            // 
            this.dtp_end.Enabled = false;
            this.dtp_end.Location = new System.Drawing.Point(380, 20);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(93, 21);
            this.dtp_end.TabIndex = 12;
            // 
            // dtp_start
            // 
            this.dtp_start.Enabled = false;
            this.dtp_start.Location = new System.Drawing.Point(264, 20);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(92, 21);
            this.dtp_start.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "日期：";
            // 
            // cb_guider
            // 
            this.cb_guider.FormattingEnabled = true;
            this.cb_guider.Location = new System.Drawing.Point(112, 20);
            this.cb_guider.Name = "cb_guider";
            this.cb_guider.Size = new System.Drawing.Size(88, 20);
            this.cb_guider.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "导购员：";
            // 
            // lv_saleInfo
            // 
            this.lv_saleInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_saleInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lv_saleInfo.FullRowSelect = true;
            this.lv_saleInfo.Location = new System.Drawing.Point(2, 57);
            this.lv_saleInfo.Name = "lv_saleInfo";
            this.lv_saleInfo.Size = new System.Drawing.Size(729, 149);
            this.lv_saleInfo.TabIndex = 3;
            this.lv_saleInfo.UseCompatibleStateImageBehavior = false;
            this.lv_saleInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "小票流水号";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "购物日期";
            this.columnHeader2.Width = 149;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "购物金额";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "单笔利润";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "导购员";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "收银员";
            this.columnHeader5.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lbl_info);
            this.groupBox2.Controls.Add(this.lbl_rows);
            this.groupBox2.Location = new System.Drawing.Point(2, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "统计结果";
            // 
            // lbl_rows
            // 
            this.lbl_rows.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_rows.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_rows.Location = new System.Drawing.Point(6, 17);
            this.lbl_rows.Name = "lbl_rows";
            this.lbl_rows.Size = new System.Drawing.Size(149, 24);
            this.lbl_rows.TabIndex = 2;
            this.lbl_rows.Text = "销售记录0条";
            // 
            // lbl_info
            // 
            this.lbl_info.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_info.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_info.Location = new System.Drawing.Point(6, 52);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(359, 23);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "销售金额￥0.00元，利润￥0.00元";
            // 
            // SaleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lv_saleInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleInfoForm";
            this.Text = "SaleInfoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_rowCount;
        private System.Windows.Forms.ComboBox cb_timeRang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_guider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lv_saleInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_rows;
    }
}