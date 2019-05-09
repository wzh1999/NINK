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
    public partial class ReturnOfGoodsForm : Form
    {
        public ReturnOfGoodsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        //绑定销售明细列表
        private void BindGrid()
        {
            string ReceiptsCode = this.txt_ReceiptsCode.Text;
            if (ReceiptsCode == "")
            {
                MessageBox.Show("请输入购物小票流水号!");
                return;
            }
            //多表联合查询(Sales,SalesDetail,Goods,Salesman)
            string sqlStr = "select * from Sales,SalesDetail,Goods,Salesman where Sales.SalesID=SalesDetail.SalesID and SalesDetail.GoodsID=Goods.GoodsID and Sales.SalesmanID=Salesman.SalesmanID and Sales.ReceiptsCode='" + ReceiptsCode + "'";
            this.dgv_goodDetail.AutoGenerateColumns = false;
            DataTable dt = DBHelper.GetDataTable(sqlStr);
            this.dgv_goodDetail.DataSource = dt;
            //显示交易金额
            if (dt.Rows.Count > 0)
                this.lbl_totalMoney.Text = dt.Rows[0]["Amount"].ToString();
        }

        //选中销售明细记录,计算退款金额
        private void dgv_goodDetail_SelectionChanged(object sender, EventArgs e)
        {
            float returnMoney = 0;
            foreach (DataGridViewRow row in this.dgv_goodDetail.SelectedRows)
            {
                returnMoney += Convert.ToSingle(row.Cells[2].Value) * Convert.ToInt32(row.Cells[3].Value);
            }

            this.lbl_returnMoney.Text = returnMoney.ToString("f2");
        }

        //取消按钮
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //退货按钮
        private void button2_Click(object sender, EventArgs e)
        {
            //退货有两种情况,1,全退;2,部分退

            //退货金额
            float returnMoney = float.Parse(this.lbl_returnMoney.Text);
            //订单交易金额
            float totalMoney = float.Parse(this.lbl_totalMoney.Text);
            if (returnMoney == 0)
            {
                MessageBox.Show("请选择需要退货的商品!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlStr = "";
            string SalesID = this.dgv_goodDetail.SelectedRows[0].Cells["col_SalesID"].Value.ToString();
            //判断是"全退"还是"部分退"
            if (returnMoney == totalMoney)
            {
                //全退,删除销售记录和销售明细
                sqlStr = string.Format("delete SalesDetail where SalesID={0} delete Sales where SalesID={0}", SalesID);
            }
            else
            {
                //部分退,删除退货商品的销售明细,修改销售记录中的交易金额
                foreach (DataGridViewRow row in this.dgv_goodDetail.SelectedRows)
                {
                    //获取当前销售明细ID
                    string SDID = row.Cells["col_SDID"].Value.ToString();
                    sqlStr += "delete SalesDetail where SDID=" + SDID + " ";
                }
                sqlStr += string.Format("update Sales set Amount=Amount-{0} where SalesID={1}", returnMoney, SalesID);
            }
            //执行SQL
            if (DBHelper.ExecuteNonQuery(sqlStr))
            {
                MessageBox.Show("退货成功!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //重新绑定DataGridView
                BindGrid();
            }
            else
            {
                MessageBox.Show("退货失败,请重试!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
