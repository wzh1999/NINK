namespace NIKE专卖店销售系统
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_LoginPwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_loginID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_LoginPwd
            // 
            this.txt_LoginPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LoginPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LoginPwd.Location = new System.Drawing.Point(413, 262);
            this.txt_LoginPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_LoginPwd.Name = "txt_LoginPwd";
            this.txt_LoginPwd.Size = new System.Drawing.Size(249, 24);
            this.txt_LoginPwd.TabIndex = 1;
            this.txt_LoginPwd.Text = "123456";
            this.txt_LoginPwd.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(413, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 41);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_loginID
            // 
            this.txt_loginID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_loginID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_loginID.Location = new System.Drawing.Point(413, 210);
            this.txt_loginID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_loginID.MaxLength = 11;
            this.txt_loginID.Name = "txt_loginID";
            this.txt_loginID.Size = new System.Drawing.Size(249, 24);
            this.txt_loginID.TabIndex = 0;
            this.txt_loginID.Text = "13812345678";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1293, 576);
            this.Controls.Add(this.txt_loginID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_LoginPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NIKE专卖店销售系统-登录窗体";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_LoginPwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_loginID;

    }
}