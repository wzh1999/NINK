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
    public partial class CashForm : Form
    {
        //皮肤引擎对象
        Sunisoft.IrisSkin.SkinEngine se = null;

        public CashForm()
        {
            InitializeComponent();
            //加载皮肤
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;
            se.SkinFile = "skin/" + Settings.SkinName + ".ssk";
        }

        private void CashForm_Load(object sender, EventArgs e)
        {
            //加载导购员
            LoadGuider();
            //生成小票流水号
            CreateReceiptsCode();
            //显示当前收银员
            this.lbl_Cashier.Text = "收银员：" +  LoginInfo.UserName;
        }

        //加载导购员
        private void LoadGuider()
        {
            string sqlStr = "select * from salesman where role='导购员'";
            this.cb_guider.DisplayMember = "SalesmanName";
            this.cb_guider.ValueMember = "SalesmanID";
            this.cb_guider.DataSource = DBHelper.GetDataTable(sqlStr);
            this.cb_guider.Text = "--请选择--";
        }

        //根据当前时间,生成小票流水号
        private void CreateReceiptsCode()
        {
            this.lbl_ReceiptsCode.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        //在条形码文本框获得焦点时,按下键盘某键并释放时触发的事件
        private void txt_barCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果按的是"回车(ASCII值为13)",添加商品至购物车列表
            if (e.KeyChar == 13)
            {
                //根据条形码查询商品信息
                string barCode = this.txt_barCode.Text;

                //判断商品是否已经在购物车中存在,存在则更新数量,不存在则添加购物车项
                if (!IsExist(barCode))
                {
                    //根据输入的条形码，查询商品信息
                    string sqlStr = "select * from Goods,Type where Goods.TypeID=Type.TypeID and Goods.BarCode='" + barCode + "'";
                    DataTable dt_goods = DBHelper.GetDataTable(sqlStr);
                    //未查询到商品,弹出提示
                    if (dt_goods.Rows.Count == 0)
                    {
                        MessageBox.Show("商品未找到,请检查条形码是否正确!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //创建购物车项
                    ListViewItem item = new ListViewItem(dt_goods.Rows[0]["BarCode"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["GoodsName"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["TypeName"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["SalePrice"].ToString());
                    item.SubItems.Add(dt_goods.Rows[0]["Discount"].ToString());
                    //记录商品ID,结算时需要用到该值
                    item.Tag = dt_goods.Rows[0]["GoodsID"].ToString();
                    //折后价=零售价*折扣
                    float salePrice = Convert.ToSingle(dt_goods.Rows[0]["SalePrice"]);
                    float discount = Convert.ToSingle(dt_goods.Rows[0]["Discount"]);
                    item.SubItems.Add((salePrice * discount).ToString("f2"));
                    item.SubItems.Add("1");
                    //添加至购物车列表
                    this.lv_cart.Items.Add(item);

                    //计算总价
                    ShowTotalPrice();
                }
            } 
            
        }

        //判断当前商品在购物车中是否已经存在
        private bool IsExist(string barCode)
        {
            bool result = false;
            foreach (ListViewItem item in this.lv_cart.Items)
            {
                if (item.Text == barCode)
                {
                    //商品在购物车中存在
                    result = true;
                    //存在,修改商品数量
                    item.SubItems[6].Text = (int.Parse(item.SubItems[6].Text)+1).ToString();
                    break;
                }
            }
            return result;
        }

        private void lv_cart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lv_cart.SelectedItems.Count == 0) return;
            this.txt_barCode.Text = this.lv_cart.SelectedItems[0].Text;
        }

        //购物车获得焦点时,按下键盘某键后释放触发的事件
        private void lv_cart_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果没有选中任何行,直接退出事件
            if (this.lv_cart.SelectedItems.Count == 0) return;
            //获取选中行的当前数量
            int count = int.Parse(this.lv_cart.SelectedItems[0].SubItems[6].Text);
            //如果选中了行,并且按下了"+(ASCII值为61)",增加数量  
            if (e.KeyChar == 61)
            {
                this.lv_cart.SelectedItems[0].SubItems[6].Text = (count + 1).ToString();
            }
            //如果选中了行,并且按下了"-(ASCII值为45)",减少数量
            if (e.KeyChar == 45)
            {
                if (count == 1) return;
                this.lv_cart.SelectedItems[0].SubItems[6].Text = (count - 1).ToString();
            }
            //如果选中了行,并且按下了"Backspace(ASCII值8)",从购物车中删除商品
            if (e.KeyChar == 8)
            {
                //删除前进行确认
                DialogResult result = MessageBox.Show("确定要从购物车中删除商品【" + this.lv_cart.SelectedItems[0].SubItems[1] + "】?", "删除确认:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == System.Windows.Forms.DialogResult.Yes)
                    this.lv_cart.Items.Remove(this.lv_cart.SelectedItems[0]);
            }
            //计算总价
            ShowTotalPrice();
        }

        //计算总价
        private void ShowTotalPrice()
        {
            //计算总价和总数量
            int totalCount = 0;
            float totalPrice = 0;
            foreach (ListViewItem item in this.lv_cart.Items)
            {
                totalCount += int.Parse(item.SubItems[6].Text);
                totalPrice +=  int.Parse(item.SubItems[6].Text)* float.Parse(item.SubItems[5].Text);
            }
            this.lbl_totalPrice.Text = "共：￥" + totalPrice.ToString("f2") + "元";
            this.lbl_count.Text = "商品数量：" + totalCount;
            this.txt_money.Text = totalPrice.ToString("f2");

            //计算找零
            float money = float.Parse(this.txt_money.Text);
            float pay = float.Parse(this.txt_pay.Text);
            this.txt_zhao.Text = (pay - money).ToString("f2");
            
        }

        //输入实收金额后,按键盘"回车",计算找零
        private void txt_pay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                float money = float.Parse(this.txt_money.Text);
                float pay = float.Parse(this.txt_pay.Text);
                this.txt_zhao.Text = (pay - money).ToString("f2");
            }
        }

        //结算按钮
        private void button1_Click(object sender, EventArgs e)
        {
            
            string ReceiptsCode = this.lbl_ReceiptsCode.Text;
            string Amount = this.txt_money.Text;
            float pay = float.Parse(this.txt_pay.Text);
            string SalesmanID = this.cb_guider.SelectedValue.ToString();
            if (Amount == "0.00")
            {
                MessageBox.Show("购物车中没有商品,无法进行结算操作!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //实收金额小于应收金额
            if (pay < float.Parse(Amount))
            {
                MessageBox.Show("付款金额不足!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.cb_guider.Text == "--请选择--")
            {
                MessageBox.Show("请选择该笔销售记录的导购员!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }  
            //向销售表中添加一条记录,并获取新增记录的标识列的值
            string sqlStr_sale = string.Format("insert Sales(ReceiptsCode,Amount,SalesmanID, CashierID) values('{0}',{1},{2},{3}) select @@identity", ReceiptsCode, Amount, SalesmanID, LoginInfo.UserID);
            string SaleID = DBHelper.ExecuteScalar(sqlStr_sale).ToString();

            //添加销售明细记录,遍历购物车中的每一项,将其添加到销售明细表中,并更新库存
            string sqlStr_detail = "";
            foreach (ListViewItem item in this.lv_cart.Items)
            {
                //拼接多条SQL语句,注意每条语句需要使用空格或换行等符号分隔开,先Insert销售明细,然后Update商品库存
                sqlStr_detail += string.Format("insert SalesDetail(SalesID,GoodsID,Quantity,AloneAmount) values({0},{1},{2},{3})\n update Goods set StockNum=StockNum-{2} where GoodsID={1}\n", SaleID, item.Tag, item.SubItems[6].Text, item.SubItems[5].Text);
            }
            if (DBHelper.ExecuteNonQuery(sqlStr_detail))
            {
                MessageBox.Show("结算成功!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //清空控件,初始化小票流水号
                this.txt_barCode.Text = "";
                this.cb_guider.Text = "--请选择--";
                CreateReceiptsCode();//重新创建小票流水号
                this.lv_cart.Items.Clear();
                this.lbl_totalPrice.Text = "共：￥0.00";
                this.lbl_count.Text = "商品数量：0";
                this.txt_money.Text = "0.00";
                this.txt_pay.Text = "0.00";
                this.txt_zhao.Text = "0.00";
            }
            else
            {
                MessageBox.Show("结算失败,请重试!", "提示:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CashForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
