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
    public partial class GoodsViewForm : Form
    {
        public GoodsViewForm()
        {
            InitializeComponent();
        }


        private void GoodsViewForm_Load(object sender, EventArgs e)
        {
            LoadType1();
            LoadAllGoods();
        }

        //加载一级分类
        private void LoadType1()
        {
            this.cb_type1.Items.Clear();

            string sqlStr = "select * from type where parentID=0";
            DataTable dt = DBHelper.GetDataTable(sqlStr);
            this.cb_type1.Items.Add("全部");
            foreach (DataRow row in dt.Rows)
            {
                this.cb_type1.Items.Add(row["TypeName"]);
            }
        }

        //联动效果：一级分类改变时，自动加载二级分类
        private void cb_type1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清除所有项
            this.cb_type2.Items.Clear();
            if (this.cb_type1.Text == "全部")
            {
                this.cb_type2.Text = "全部";
                return;
            }
            //根据一级分类的名称，获取一级分类的ID
            string parentID = GetTypeID(this.cb_type1.Text);
            string sqlStr = "select * from type where parentID=" + parentID;
            DataTable dt = DBHelper.GetDataTable(sqlStr);
            this.cb_type2.Items.Add("全部");
            foreach (DataRow row in dt.Rows)
            {
                this.cb_type2.Items.Add(row["TypeName"]);
            }
        }

        //根据TypeName查询TypeID
        private string GetTypeID(string TypeName)
        {
            string sqlStr = "select TypeID from type where TypeName='" + TypeName + "'";
            return DBHelper.ExecuteScalar(sqlStr).ToString();
        }

        //加载所有的商品
        private void LoadAllGoods()
        {
            this.cb_timeRang.Text = "全部";
            QueryGoods("","","全部",DateTime.Now,DateTime.Now);
        }

        //多条件组合查询商品
        private void QueryGoods(string goodsCode, string goodsName, string typeName, DateTime startTime, DateTime endTime)
        {
            //定义查询所有商品的SQL
            string sqlStr = "select * from goods,Type where goods.TypeId=Type.TypeID ";
            //根据用户的选择，拼接不同的条件
            if (goodsCode != "")
                sqlStr += " and BarCode like '" + goodsCode + "%'";
            if (goodsName != "")
                sqlStr += " and GoodsName like '%" + goodsName + "%'";
            if (typeName != "全部")
            {
                //用户选择了二级分类，按二级分类查询
                sqlStr += " and TypeName = '" + typeName + "'";
            }
            else if (this.cb_type1.Text != "全部")
            {
                //用户只选择了一级分类，按一级分类进行查询
                string parentID = GetTypeID(this.cb_type1.Text);
                sqlStr += " and parentID = " + parentID;
            }
            if (this.cb_timeRang.Text != "全部")
                sqlStr += "and StockDate between '" + startTime.ToString("yyyy-MM-dd 00:00:00") + "' and '" + endTime.ToString("yyyy-MM-dd 23:59:59") + "'";
           //按入库时间降序排序
            sqlStr += " order by StockDate desc";
            //执行SQL
            DataTable dt_goods = DBHelper.GetDataTable(sqlStr);
            //绑定到DataGridView
            this.dgv_goods.AutoGenerateColumns = false;
            this.dgv_goods.DataSource = dt_goods;

            this.lbl_rowCount.Text = "当前共" + dt_goods.Rows.Count + "条商品信息!" ;
        }

        //根据选择的时间区间，设置起始时间和结束时间
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
                    this.dtp_start.Value = now.AddDays(1-week);
                    this.dtp_end.Value = now.AddDays(7-week);
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
            string goodsCode = this.txt_goodsCode.Text;
            string goodsName = this.txt_goodsName.Text;
            string type1 = this.cb_type1.Text;
            string type2 = this.cb_type2.Text;
            DateTime startTime = dtp_start.Value;
            DateTime endTime = dtp_end.Value;

            QueryGoods(goodsCode, goodsName,type2, startTime, endTime);

        }

      
    }
}
