namespace NIKE专卖店销售系统
{
    partial class EmployeeManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lv_employee = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CommissionRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_baseSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lv_employee);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(725, 235);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.TabIndex = 2;
            // 
            // lv_employee
            // 
            this.lv_employee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_employee.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_employee.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lv_employee.FullRowSelect = true;
            this.lv_employee.Location = new System.Drawing.Point(0, 0);
            this.lv_employee.MultiSelect = false;
            this.lv_employee.Name = "lv_employee";
            this.lv_employee.Size = new System.Drawing.Size(453, 235);
            this.lv_employee.TabIndex = 0;
            this.lv_employee.UseCompatibleStateImageBehavior = false;
            this.lv_employee.View = System.Windows.Forms.View.Details;
            this.lv_employee.SelectedIndexChanged += new System.EventHandler(this.lv_employee_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "员工ID";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "员工姓名";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "手机号码";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "基本工资";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "提成比例";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "角色";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_role);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_CommissionRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_baseSalary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_mobile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cb_gender);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // cb_role
            // 
            this.cb_role.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "导购员",
            "收银员",
            "店长"});
            this.cb_role.Location = new System.Drawing.Point(97, 162);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(132, 30);
            this.cb_role.TabIndex = 12;
            this.cb_role.Text = "--请选择--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "员工角色：";
            // 
            // txt_CommissionRate
            // 
            this.txt_CommissionRate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_CommissionRate.Location = new System.Drawing.Point(97, 134);
            this.txt_CommissionRate.Name = "txt_CommissionRate";
            this.txt_CommissionRate.Size = new System.Drawing.Size(132, 29);
            this.txt_CommissionRate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "提成比例：";
            // 
            // txt_baseSalary
            // 
            this.txt_baseSalary.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_baseSalary.Location = new System.Drawing.Point(97, 106);
            this.txt_baseSalary.Name = "txt_baseSalary";
            this.txt_baseSalary.Size = new System.Drawing.Size(132, 29);
            this.txt_baseSalary.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "基本工资：";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_mobile.Location = new System.Drawing.Point(97, 50);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(132, 29);
            this.txt_mobile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "手机号码：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(62, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "新增员工";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_gender
            // 
            this.cb_gender.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_gender.Location = new System.Drawing.Point(97, 78);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(132, 30);
            this.cb_gender.TabIndex = 3;
            this.cb_gender.Text = "--请选择--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "性    别：";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_name.Location = new System.Drawing.Point(97, 22);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 29);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名：";
            // 
            // EmployeeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 560);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeManagerForm";
            this.Text = "EmployeeManagerForm";
            this.Load += new System.EventHandler(this.EmployeeManagerForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lv_employee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CommissionRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_baseSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}