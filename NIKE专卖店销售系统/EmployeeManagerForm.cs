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
    public partial class EmployeeManagerForm : Form
    {
        public EmployeeManagerForm()
        {
            InitializeComponent();
        }

        private void EmployeeManagerForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        //加载员工
        private void LoadEmployees()
        {
            this.lv_employee.Items.Clear();

            DataTable dt_employee = DBHelper.GetDataTable("select * from salesman");
            foreach (DataRow row in dt_employee.Rows)
            {
                ListViewItem item = new ListViewItem(row["SalesmanID"].ToString());
                item.SubItems.Add(row["SalesmanName"].ToString());
                item.SubItems.Add(row["Mobile"].ToString());
                item.SubItems.Add(row["Gender"].ToString());
                item.SubItems.Add(Convert.ToSingle(row["BaseSalary"]).ToString("f2"));
                item.SubItems.Add(row["CommissionRate"].ToString());
                item.SubItems.Add(row["Role"].ToString());

                this.lv_employee.Items.Add(item);
            }
        }

        private void lv_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lv_employee.SelectedItems.Count == 0)
            {
                this.txt_name.Text = "";
                this.cb_gender.Text = "--请选择--";
                this.txt_mobile.Text = "";
                this.txt_baseSalary.Text = "";
                this.txt_CommissionRate.Text = "";
                this.cb_role.Text = "--请选择--";
                this.button1.Text = "新增员工";
            }
            else
            {
                this.txt_name.Text = this.lv_employee.SelectedItems[0].SubItems[1].Text;
                this.txt_mobile.Text = this.lv_employee.SelectedItems[0].SubItems[2].Text;
                this.cb_gender.Text = this.lv_employee.SelectedItems[0].SubItems[3].Text;
                this.txt_baseSalary.Text = this.lv_employee.SelectedItems[0].SubItems[4].Text;
                this.txt_CommissionRate.Text = this.lv_employee.SelectedItems[0].SubItems[5].Text;
                this.cb_role.Text = this.lv_employee.SelectedItems[0].SubItems[6].Text;
                this.button1.Text = "修改员工";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string salesmanName = this.txt_name.Text;
            string mobile = this.txt_mobile.Text;
            string gender = this.cb_gender.Text;
            string baseSalary = this.txt_baseSalary.Text;
            string CommissionRate = this.txt_CommissionRate.Text;
            string role = this.cb_role.Text;
            if (salesmanName == "" || mobile=="" || gender=="--请选择--" || baseSalary=="" || CommissionRate=="" || role=="")
            {
                MessageBox.Show("员工信息填写不完整！");
                return;
            }
            string sqlStr = "";
            string flag = "";
            if (this.lv_employee.SelectedItems.Count == 0)
            {
                sqlStr = string.Format("insert salesman(SalesmanName,Mobile,[Pwd],Gender,BaseSalary,CommissionRate,Role) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", salesmanName, mobile, "123456", gender, baseSalary, CommissionRate, role);
                flag = "新增";
            }
            else
            {
                string salesmanID = this.lv_employee.SelectedItems[0].SubItems[0].Text;
                sqlStr = string.Format("update salesman set SalesmanName='{0}',Mobile='{1}',Gender='{2}',BaseSalary='{3}',CommissionRate='{4}',Role='{5}' where SalesmanID={6}", salesmanName, mobile, gender, baseSalary, CommissionRate, role, salesmanID);
                flag = "修改";
            }

            if (DBHelper.ExecuteNonQuery(sqlStr))
            {
                MessageBox.Show("员工" + flag + "成功！");

                LoadEmployees();

                this.txt_name.Text = "";
                this.cb_gender.Text = "--请选择--";
                this.txt_mobile.Text = "";
                this.txt_baseSalary.Text = "";
                this.txt_CommissionRate.Text = "";
                this.cb_role.Text = "--请选择--";
                this.button1.Text = "新增员工";
            }
            else
            {
                MessageBox.Show("员工" + flag + "失败,请重试！");
            }
                
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv_employee.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的员工！");
                return;
            }
            string salesmanID = this.lv_employee.SelectedItems[0].SubItems[0].Text;
            bool result = DBHelper.ExecuteNonQuery("delete Salesman where SalesmanID=" + salesmanID);
            if (result)
            {
                MessageBox.Show("员工删除成功！");
                LoadEmployees();
            }
            else
                MessageBox.Show("员工删除失败！");
        }
    }
}
