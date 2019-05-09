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
    public partial class SalaryInfoForm : Form
    {
        public SalaryInfoForm()
        {
            InitializeComponent();
        }

        private void cb_timeRang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int dayOfMonth = now.Day;
            switch (this.cb_timeRang.Text)
            {
                case "当前月":
                    //当前月第1天日期
                    this.dtp_start.Value = now.AddDays(1 - dayOfMonth);
                    //当前月最后一天日期 = 下月第一天-1天
                    this.dtp_end.Value = now.AddDays(1 - dayOfMonth).AddMonths(1).AddDays(-1);
                    break;
                case "上一月":
                    //上一月第1天日期 = 当前月第1天日期-1月
                    this.dtp_start.Value = now.AddDays(1 - dayOfMonth).AddMonths(-1);
                    //上一月最后一天日期 = 当前月第1天日期-1天
                    this.dtp_end.Value = now.AddDays(1 - dayOfMonth - 1);
                    break;
                default:
                    break;
            }
        }

        private void SalaryInfoForm_Load(object sender, EventArgs e)
        {
            //默认显示当前月日期
            DateTime now = DateTime.Now;
            int dayOfMonth = now.Day;
            this.dtp_start.Value = now.AddDays(1 - dayOfMonth);
            this.dtp_end.Value = now.AddDays(1 - dayOfMonth).AddMonths(1).AddDays(-1);

        }

        //核算按钮
        private void button1_Click(object sender, EventArgs e)
        {
            this.lv_salary.Items.Clear();

            DateTime startDate = this.dtp_start.Value;
            DateTime endDate = this.dtp_end.Value;
            if (startDate > endDate)
            {
                MessageBox.Show("开始日期必须小于结束日期!");
                return;
            }
            DataTable dt_salesman = DBHelper.GetDataTable("select *from Salesman");
            foreach (DataRow row in dt_salesman.Rows)
            {
                ListViewItem item = new ListViewItem(row["SalesmanName"].ToString());
                item.SubItems.Add(row["Role"].ToString());
                item.SubItems.Add(row["Mobile"].ToString());
                //基本工资
                float baseSalary = Convert.ToSingle(row["BaseSalary"]);
                item.SubItems.Add(baseSalary.ToString("f2"));
                //提成比例
                float CommissionRate = Convert.ToSingle(row["CommissionRate"]);
                if (CommissionRate == 0)
                    item.SubItems.Add("无");
                else
                    item.SubItems.Add((CommissionRate * 100).ToString() + "%");
                //根据员工类型不同,分别计算月销售额
                float saleData = 0; //销售额
                if (row["Role"].ToString() == "导购员")
                {
                    saleData = getSaleData_saler(row["SalesmanID"].ToString(), startDate, endDate);
                    item.SubItems.Add(saleData.ToString("f2"));
                }
                if (row["Role"].ToString() == "店长")
                {
                    //店长月度销售额 = 店内所有导购员月度销售总和-当月销售额保底
                    saleData = getSaleData_manager(startDate, endDate);
                    item.SubItems.Add(saleData.ToString("f2"));
                }
                if (row["Role"].ToString() == "收银员")
                {
                    item.SubItems.Add("无");
                }
                //应发工资 = 基本工资+月度销售额*提成比例
                float totalSalary = baseSalary + saleData * CommissionRate;
                item.SubItems.Add(totalSalary.ToString("f2"));

                this.lv_salary.Items.Add(item);
            }

        }

        //统计导购员某月的销售额
        private float getSaleData_saler(string SalesmanID, DateTime startDate, DateTime endDate)
        {
            //导购员月度销售额 = 本月度销售金额总和
            string sqlStr = string.Format("select sum(Sales.Amount) from Sales,salesman where Sales.SalesmanID=Salesman.SalesmanID and salesDate between '{0}' and '{1}'  and Sales.SalesmanID={2}", startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"), SalesmanID);
            object obj = DBHelper.ExecuteScalar(sqlStr);
            if (obj is DBNull)  //如果数据库中没有查询到数据,返回0
                return 0;
            else
                return Convert.ToSingle(obj); ;
        }

        //统计店长某月的销售额
        private float getSaleData_manager(DateTime startDate, DateTime endDate)
        {
            //店长月度销售额 = 店内所有导购员月度销售总和-当月销售额考核保底
            string sqlStr = string.Format("select sum(Sales.Amount) from Sales,salesman where Sales.SalesmanID=Salesman.SalesmanID and salesDate between '{0}' and '{1}' ", startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
            object obj = DBHelper.ExecuteScalar(sqlStr);
            if (obj is DBNull)
                return 0;
            else
                return Convert.ToSingle(obj) - Settings.BaseSaleroom; ;
        }

    }
}
