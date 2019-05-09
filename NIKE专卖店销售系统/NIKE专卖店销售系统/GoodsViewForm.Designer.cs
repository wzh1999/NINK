namespace NIKE专卖店销售系统
{
    partial class GoodsViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_rowCount = new System.Windows.Forms.Label();
            this.cb_timeRang = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_goodsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_type2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_type1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_goodsCode = new System.Windows.Forms.TextBox();
            this.dgv_goods = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goods)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "货号/条形码：";
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
            this.groupBox1.Controls.Add(this.txt_goodsName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_type2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_type1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_goodsCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // lbl_rowCount
            // 
            this.lbl_rowCount.AutoSize = true;
            this.lbl_rowCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_rowCount.Location = new System.Drawing.Point(470, 50);
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
            this.cb_timeRang.Location = new System.Drawing.Point(739, 20);
            this.cb_timeRang.Name = "cb_timeRang";
            this.cb_timeRang.Size = new System.Drawing.Size(59, 20);
            this.cb_timeRang.TabIndex = 14;
            this.cb_timeRang.Text = "全部";
            this.cb_timeRang.SelectedIndexChanged += new System.EventHandler(this.cb_timeRang_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(685, 48);
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
            this.dtp_end.Location = new System.Drawing.Point(640, 20);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(93, 21);
            this.dtp_end.TabIndex = 12;
            // 
            // dtp_start
            // 
            this.dtp_start.Enabled = false;
            this.dtp_start.Location = new System.Drawing.Point(524, 20);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(92, 21);
            this.dtp_start.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "入库时间：";
            // 
            // txt_goodsName
            // 
            this.txt_goodsName.Location = new System.Drawing.Point(304, 20);
            this.txt_goodsName.Name = "txt_goodsName";
            this.txt_goodsName.Size = new System.Drawing.Size(141, 21);
            this.txt_goodsName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "商品名称：";
            // 
            // cb_type2
            // 
            this.cb_type2.FormattingEnabled = true;
            this.cb_type2.Location = new System.Drawing.Point(304, 47);
            this.cb_type2.Name = "cb_type2";
            this.cb_type2.Size = new System.Drawing.Size(141, 20);
            this.cb_type2.TabIndex = 5;
            this.cb_type2.Text = "全部";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "二级分类：";
            // 
            // cb_type1
            // 
            this.cb_type1.FormattingEnabled = true;
            this.cb_type1.Location = new System.Drawing.Point(88, 47);
            this.cb_type1.Name = "cb_type1";
            this.cb_type1.Size = new System.Drawing.Size(141, 20);
            this.cb_type1.TabIndex = 3;
            this.cb_type1.Text = "全部";
            this.cb_type1.SelectedIndexChanged += new System.EventHandler(this.cb_type1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "一级分类：";
            // 
            // txt_goodsCode
            // 
            this.txt_goodsCode.Location = new System.Drawing.Point(88, 20);
            this.txt_goodsCode.Name = "txt_goodsCode";
            this.txt_goodsCode.Size = new System.Drawing.Size(141, 21);
            this.txt_goodsCode.TabIndex = 1;
            // 
            // dgv_goods
            // 
            this.dgv_goods.AllowUserToAddRows = false;
            this.dgv_goods.AllowUserToDeleteRows = false;
            this.dgv_goods.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_goods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_goods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_goods.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_goods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_goods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv_goods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_goods.Location = new System.Drawing.Point(3, 84);
            this.dgv_goods.MultiSelect = false;
            this.dgv_goods.Name = "dgv_goods";
            this.dgv_goods.ReadOnly = true;
            this.dgv_goods.RowHeadersVisible = false;
            this.dgv_goods.RowTemplate.Height = 23;
            this.dgv_goods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_goods.Size = new System.Drawing.Size(870, 258);
            this.dgv_goods.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GoodsID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BarCode";
            this.Column2.HeaderText = "货号/条形码";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GoodsName";
            this.Column4.HeaderText = "商品名称";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TypeName";
            this.Column3.HeaderText = "商品类别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StorePrice";
            this.Column5.HeaderText = "进货价";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SalePrice";
            this.Column6.HeaderText = "零售价";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Discount";
            this.Column7.HeaderText = "折扣";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "StockNum";
            this.Column8.HeaderText = "当前库存";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "StockDate";
            this.Column9.HeaderText = "入库时间";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // GoodsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 773);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_goods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsViewForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品浏览";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GoodsViewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_goods;
        private System.Windows.Forms.TextBox txt_goodsCode;
        private System.Windows.Forms.ComboBox cb_type1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_goodsName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_timeRang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label lbl_rowCount;

    }
}