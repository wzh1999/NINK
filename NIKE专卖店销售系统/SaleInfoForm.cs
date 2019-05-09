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
    public partial class SaleInfoForm : Form
    {
        public SaleInfoForm()
        {
            InitializeComponent();
        }

        private void SaleInfoForm_Load(object sender, EventArgs e)
        {
            //加载导购员
            LoadGuider();
            //加载当天销售记录
            this.cb_timeRang.Text = "本日";
            LoadSaleInfo("全部", DateTime.Now, DateTime.Now);
        }

        //加载导购员
        private void LoadGuider()
        {
            string sqlStr = "select * from salesman where role='导购员'";
            DataTable dt_guider = DBHelper.GetDataTable(sqlStr);
            foreach (DataRow row in dt_guider.Rows)
            {
                this.cb_guider.Items.Add(row["SalesmanName"].ToString());
            }
            this.cb_guider.Items.Insert(0, "全部");
            this.cb_guider.Text = "全部";
        }

        private void cb_timeRang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            switch (this.cb_timeRang.Text)
            {
                case "全部":
                    this.dtp_start.Enabled = false;
                    this.dtp_end.Enabled = false;
                    break;
                case "本日":
                    this.dtp_start.Enabled = true;
                    this.dtp_end.Enabled = true;
                    this.dtp_start.Value = now;
                    this.dtp_end.Value = now;
                    break;
                case "本周":
                    this.dtp_start.Enabled = true;
                    this.dtp_end.Enabled = true;
                    int week = (int)now.DayOfWeek;
                    //周日时week值为0，代表一周的第一天。
                    //由于中国人的习惯是周日为一周的最后一天，因此需要判断和转换
                    if (week == 0) week = 7;

                    this.dtp_start.Value = now.AddDays(1 - week);
                    this.dtp_end.Value = now.AddDays(7 - week);
                    break;
                case "本月":
                    this.dtp_start.Enabled = true;
                    this.dtp_end.Enabled = true;
                    int dayOfMonth = now.Day;
                    //当前月第1天日期
                    this.dtp_start.Value = now.AddDays(1 - dayOfMonth);
                    //当前月最后一天日期 = 下月第一天-1天
                    this.dtp_end.Value = now.AddDays(1 - dayOfMonth).AddMonths(1).AddDays(-1);
                    break;
                case "本年":
                    this.dtp_start.Enabled = true;
                    this.dtp_end.Enabled = true;
                    int dayOfYear = now.DayOfYear;
                    this.dtp_start.Value = now.AddDays(1 - dayOfYear);
                    this.dtp_end.Value = now.AddDays(1 - dayOfYear).AddYears(1).AddDays(-1);
                    break;
                default:
                    break;
            }
        }

        //查询按钮单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            LoadSaleInfo(this.cb_guider.Text, this.dtp_start.Value, this.dtp_end.Value);
        }

        //多条件组合查询销售记录
        private void LoadSaleInfo(string guider, DateTime startDate, DateTime endDate)
        {
            //清空ListView
            this.lv_saleInfo.Items.Clear();

            string sqlStr = "select * from Sales, Salesman where Sales.SalesmanID=Salesman.SalesmanID";
            if (this.cb_guider.Text != "全部")
            {
                sqlStr += " and SalesmanName='" + guider + "' ";
            }
            if (this.cb_timeRang.Text != "全部")
            {
                sqlStr += " and SalesDate between '" + startDate.ToString("yyyy-MM-dd 00:00:00") + "' and '" + endDate.ToString("yyyy-MM-dd 23:59:59") + "'";
            }
            DataTable dt = DBHelper.GetDataTable(sqlStr);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["ReceiptsCode"].ToString());
                item.SubItems.Add(((DateTime)row["SalesDate"]).ToString("yyyy-MM-dd"));
                item.SubItems.Add(row["Amount"].ToString());
                //计算单笔订单的利润
                float profit = GetProfit(row["SalesID"].ToString());
                item.SubItems.Add(profit.ToString("f2"));
                item.SubItems.Add(row["SalesmanName"].ToString());
                //获取收银员姓名
                string CashierName = GetCashierName(row["CashierID"].ToString());
                item.SubItems.Add(CashierName);

                this.lv_saleInfo.Items.Add(item);
            }

            this.lbl_rows.Text = "销售记录" + dt.Rows.Count + "条";
            this.lbl_info.Text = getSaleInfo();
        }

        //计算单笔利润
        private float GetProfit(string salesID)
        {
            //商品利润 = (折后价格-进货价格)*销售数量
           //单笔利润 = 该笔订单所有商品利润总和
            string sqlStr = "select  单笔利润 = sum((SalesDetail.AloneAmount-Goods.StorePrice)*SalesDetail.Quantity) from SalesDetail,Goods where SalesDetail.GoodsID=Goods.GoodsID and SalesID=" + salesID;
            //执行sql  
            return Convert.ToSingle(DBHelper.ExecuteScalar(sqlStr)); 
        }

        //获取收银员姓名
        private string GetCashierName(string CashierID)
        {
            return DBHelper.ExecuteScalar("select SalesmanName from Salesman where SalesmanID=" + CashierID).ToString();
        }

        //计算总销售额和总利润
        private string getSaleInfo()
        {
            float amount = 0;
            float profit = 0;
            foreach  (ListViewItem item in this.lv_saleInfo.Items)
            {
                amount += float.Parse(item.SubItems[2].Text);
                profit += float.Parse(item.SubItems[3].Text);
            }
            return string.Format("销售金额￥{0}元，利润￥{1}元", amount.ToString("f2"), profit.ToString("f2"));
        }
    }
}
