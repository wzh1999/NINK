using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIKE专卖店销售系统
{
    public partial class LoginForm : Form
    {
      
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginID = this.txt_loginID.Text;
            string loginPwd = this.txt_LoginPwd.Text;
            if (loginID == "")
            {
                MessageBox.Show("用户名不能为空!","验证错误:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loginPwd == "")
            {
                MessageBox.Show("密码不能为空!", "验证错误:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //根据用户名(手机号)查询用户信息
            string sqlStr = string.Format("select * from Salesman where Mobile='{0}'", loginID);
            DataTable dt_userInfo = DBHelper.GetDataTable(sqlStr);
            if (dt_userInfo.Rows.Count == 0)
            {
                MessageBox.Show("用户不存在!", "登录失败:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt_userInfo.Rows[0]["Pwd"].ToString() != loginPwd)
            {
                MessageBox.Show("密码错误!", "登录失败:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //登录成功保存登录信息
                LoginInfo.UserID = dt_userInfo.Rows[0]["SalesmanID"].ToString();
                LoginInfo.LoginID = dt_userInfo.Rows[0]["Mobile"].ToString();
                LoginInfo.UserName = dt_userInfo.Rows[0]["SalesmanName"].ToString();
                LoginInfo.RoleName = dt_userInfo.Rows[0]["Role"].ToString();

                //根据不同角色,打开不同界面
                if (dt_userInfo.Rows[0]["Role"].ToString() == "收银员")
                    new CashForm().Show();
                else
                    new MainForm().Show();

                //隐藏登录窗体
                this.Hide();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
