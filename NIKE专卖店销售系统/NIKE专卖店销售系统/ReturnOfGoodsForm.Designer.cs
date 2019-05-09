namespace NIKE专卖店销售系统
{
    partial class ReturnOfGoodsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ReceiptsCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_goodDetail = new System.Windows.Forms.DataGridView();
            this.lbl_returnMoney = new System.Windows.Forms.Label();
            this.lbl_totalMoney = new System.Windows.Forms.Label();
            this.lbl_returnMoney1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_totalMoney1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goodDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_ReceiptsCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 60);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(710, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ReceiptsCode
            // 
            this.txt_ReceiptsCode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ReceiptsCode.Location = new System.Drawing.Point(431, 14);
            this.txt_ReceiptsCode.MaxLength = 14;
            this.txt_ReceiptsCode.Name = "txt_ReceiptsCode";
            this.txt_ReceiptsCode.Size = new System.Drawing.Size(229, 33);
            this.txt_ReceiptsCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(275, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "购物小票流水号:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_goodDetail);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_returnMoney);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_totalMoney);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_returnMoney1);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_totalMoney1);
            this.splitContainer1.Size = new System.Drawing.Size(941, 249);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgv_goodDetail
            // 
            this.dgv_goodDetail.AllowUserToAddRows = false;
            this.dgv_goodDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_goodDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_goodDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_goodDetail.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_goodDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_goodDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_goodDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.col_price,
            this.col_Quantity,
            this.Column6,
            this.Column5,
            this.col_SalesID,
            this.col_SDID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_goodDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_goodDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_goodDetail.Location = new System.Drawing.Point(0, 0);
            this.dgv_goodDetail.Name = "dgv_goodDetail";
            this.dgv_goodDetail.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_goodDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_goodDetail.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_goodDetail.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_goodDetail.RowTemplate.Height = 23;
            this.dgv_goodDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_goodDetail.Size = new System.Drawing.Size(941, 185);
            this.dgv_goodDetail.TabIndex = 0;
            this.dgv_goodDetail.SelectionChanged += new System.EventHandler(this.dgv_goodDetail_SelectionChanged);
            // 
            // lbl_returnMoney
            // 
            this.lbl_returnMoney.BackColor = System.Drawing.Color.Khaki;
            this.lbl_returnMoney.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_returnMoney.ForeColor = System.Drawing.Color.Black;
            this.lbl_returnMoney.Location = new System.Drawing.Point(525, 0);
            this.lbl_returnMoney.Name = "lbl_returnMoney";
            this.lbl_returnMoney.Size = new System.Drawing.Size(135, 60);
            this.lbl_returnMoney.TabIndex = 9;
            this.lbl_returnMoney.Text = "0.00";
            // 
            // lbl_totalMoney
            // 
            this.lbl_totalMoney.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_totalMoney.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_totalMoney.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalMoney.Location = new System.Drawing.Point(181, 1);
            this.lbl_totalMoney.Name = "lbl_totalMoney";
            this.lbl_totalMoney.Size = new System.Drawing.Size(163, 60);
            this.lbl_totalMoney.TabIndex = 8;
            this.lbl_totalMoney.Text = "0.00";
            // 
            // lbl_returnMoney1
            // 
            this.lbl_returnMoney1.BackColor = System.Drawing.Color.Khaki;
            this.lbl_returnMoney1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_returnMoney1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_returnMoney1.ForeColor = System.Drawing.Color.Black;
            this.lbl_returnMoney1.Location = new System.Drawing.Point(344, 0);
            this.lbl_returnMoney1.Name = "lbl_returnMoney1";
            this.lbl_returnMoney1.Size = new System.Drawing.Size(316, 60);
            this.lbl_returnMoney1.TabIndex = 7;
            this.lbl_returnMoney1.Text = "退款金额：￥";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(823, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(710, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "退货";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_totalMoney1
            // 
            this.lbl_totalMoney1.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_totalMoney1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_totalMoney1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_totalMoney1.ForeColor = System.Drawing.Color.Black;
            this.lbl_totalMoney1.Location = new System.Drawing.Point(0, 0);
            this.lbl_totalMoney1.Name = "lbl_totalMoney1";
            this.lbl_totalMoney1.Size = new System.Drawing.Size(344, 60);
            this.lbl_totalMoney1.TabIndex = 5;
            this.lbl_totalMoney1.Text = "交易金额：￥";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BarCode";
            this.Column1.HeaderText = "货号\\条形码";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GoodsName";
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.DataPropertyName = "AloneAmount";
            this.col_price.HeaderText = "实收价格";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_Quantity
            // 
            this.col_Quantity.DataPropertyName = "Quantity";
            this.col_Quantity.HeaderText = "数量";
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SalesmanName";
            this.Column6.HeaderText = "导购员";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SalesDate";
            this.Column5.HeaderText = "购买日期";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // col_SalesID
            // 
            this.col_SalesID.DataPropertyName = "SalesID";
            this.col_SalesID.HeaderText = " SalesID";
            this.col_SalesID.Name = "col_SalesID";
            this.col_SalesID.ReadOnly = true;
            this.col_SalesID.Visible = false;
            // 
            // col_SDID
            // 
            this.col_SDID.DataPropertyName = "SDID";
            this.col_SDID.HeaderText = "SDID";
            this.col_SDID.Name = "col_SDID";
            this.col_SDID.ReadOnly = true;
            this.col_SDID.Visible = false;
            // 
            // ReturnOfGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 309);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReturnOfGoodsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NIKE专卖店销售系统-商品退货";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_goodDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ReceiptsCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_goodDetail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_returnMoney1;
        private System.Windows.Forms.Label lbl_totalMoney;
        private System.Windows.Forms.Label lbl_returnMoney;
        private System.Windows.Forms.Label lbl_totalMoney1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDID;
    }
}