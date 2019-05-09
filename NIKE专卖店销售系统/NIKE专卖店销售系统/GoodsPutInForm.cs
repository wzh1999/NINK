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
    public partial class GoodsPutInForm : Form
    {
        public GoodsPutInForm()
        {
            InitializeComponent();
        }

        private void GoodsPutInForm_Load(object sender, EventArgs e)
        {
            LoadType1();
        }
        //加载一级分类
        private void LoadType1()
        {
            this.cb_type1.Items.Clear();

            string sqlStr = "select * from type where parentID=0";
            DataTable dt = DBHelper.GetDataTable(sqlStr);
           
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
         
            //根据一级分类的名称，获取一级分类的ID
            string parentID = GetTypeID(this.cb_type1.Text);
            string sqlStr = "select * from type where parentID=" + parentID;
            DataTable dt = DBHelper.GetDataTable(sqlStr);
           
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
        //根据TypeID查询TypeName
        private string GetTypeName(string TypeID)
        {
            string sqlStr = "select TypeName from type where TypeID='" + TypeID + "'";
            return DBHelper.ExecuteScalar(sqlStr).ToString();
        }

        //读取信息按钮单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            string goodsCode = this.txt_goodsCode.Text;
            if (goodsCode == "")
            {
                MessageBox.Show("请输入商品货号/条形码！");
            }
            else
            {
                string SqlStr = "select * from goods,Type where goods.TypeId=Type.TypeID and BarCode='" + goodsCode + "'";
                DataTable dt_goods = DBHelper.GetDataTable(SqlStr);
                if (dt_goods.Rows.Count == 0)
                    MessageBox.Show("未找到该商品信息！");
                else
                {
                    this.txt_goodsName.Text = dt_goods.Rows[0]["GoodsName"].ToString();
                    this.cb_type1.Text = GetTypeName(dt_goods.Rows[0]["ParentID"].ToString());
                    this.cb_type2.Text = dt_goods.Rows[0]["TypeName"].ToString();
                    this.txt_storePrice.Text = dt_goods.Rows[0]["StorePrice"].ToString();
                    this.txt_salePrice.Text = dt_goods.Rows[0]["SalePrice"].ToString();
                    this.txt_discount.Text = dt_goods.Rows[0]["Discount"].ToString();
                    this.lbl_storeNum.Text = "当前库存数量:" + dt_goods.Rows[0]["StockNum"].ToString();
                }
            }
        }

        //入库按钮单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            //获取用户输入的信息
            string goodsCode = this.txt_goodsCode.Text;
            string goodsName = this.txt_goodsName.Text;
            string typeName = this.cb_type2.Text;
            string storePrice = this.txt_storePrice.Text;
            string SalePrice = this.txt_salePrice.Text;
            string discount = this.txt_discount.Text;
            string stockNum = this.txt_stockNum.Text;

            #region 输入验证
            if (goodsCode == "")
            {
                MessageBox.Show("请输入货号/条形码!");
                return;
            }
            if (goodsName == "")
            {
                MessageBox.Show("请输入商品名称!");
                return;
            }
            if (typeName == "--请选择--")
            {
                MessageBox.Show("请选择商品分类!");
                return;
            }
            float result;
            if (storePrice == "")
            {
                MessageBox.Show("请输入进货价格!");
                return;
            }
            else
            {
                //验证输入的文本是否是单精度数字
                if (!float.TryParse(storePrice, out result))
                {
                    MessageBox.Show("进货价格必须是数字!");
                    return;
                }
            }
            if (SalePrice == "")
            {
                MessageBox.Show("请输入零售价格!");
                return;
            }
            else
            {
                //验证输入的文本是否是单精度数字
                if (!float.TryParse(SalePrice, out result))
                {
                    MessageBox.Show("零售价格必须是数字!");
                    return;
                }
            }
            if (discount == "")
            {
                MessageBox.Show("请输入折扣!");
                return;
            }
            else
            {
                //验证输入的文本是否是单精度数字
                if (!float.TryParse(discount, out result))
                {
                    MessageBox.Show("折扣必须是数字!");
                    return;
                }
                else if (result < 0 || result > 1)//验证折扣是否为0~1之间的数字
                {
                    MessageBox.Show("折扣必须是0~1的数字!");
                    return;
                }
            }
            int outResult;
            if (stockNum == "")
            {
                MessageBox.Show("请输入本次入库数量!");
                return;
            }
            else
            {
                //验证输入的文本是否是整数
                if (!Int32.TryParse(stockNum, out outResult))
                {
                    MessageBox.Show("本次入库数量必须是整数!");
                    return;
                }
            }
            #endregion

            //判断该商品是否存在
            string SqlStr = "select * from goods,Type where goods.TypeId=Type.TypeID and BarCode='" + goodsCode + "'";
            DataTable dt_goods = DBHelper.GetDataTable(SqlStr);
            string sqlStr = ""; 
            if (dt_goods.Rows.Count == 0)
            {
                //不存在则执行新增操作
                sqlStr = string.Format("insert goods(BarCode, TypeID, GoodsName, StorePrice,SalePrice,Discount,StockNum) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", goodsCode, GetTypeID(typeName), goodsName, storePrice, SalePrice, discount, stockNum);
            }
            else
            {
                //存在则执行修改操作
                string goodsID = dt_goods.Rows[0]["GoodsID"].ToString();    //查询到的商品ID
                sqlStr = string.Format("update goods set TypeID={0},GoodsName='{1}',StorePrice={2},SalePrice={3},Discount={4},StockNum=StockNum +{5} where GoodsID ={6}", GetTypeID(typeName), goodsName, storePrice, SalePrice, discount, stockNum, goodsID);
            }
            bool success = DBHelper.ExecuteNonQuery(sqlStr);
            if (success)
            {
                MessageBox.Show("入库成功!");
                //清空表单
                this.txt_goodsCode.Text = "";
                this.txt_goodsName.Text = "";
                this.txt_discount.Text = "1";
                this.txt_salePrice.Text = "";
                this.txt_stockNum.Text = "";
                this.txt_storePrice.Text = "";
                this.cb_type1.Text = "--请选择--";
                this.cb_type2.Text = "--请选择--";
                this.lbl_storeNum.Text = "";
            }
            else
                MessageBox.Show("入库失败,请重试!");
        }

        //取消按钮单击事件
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
