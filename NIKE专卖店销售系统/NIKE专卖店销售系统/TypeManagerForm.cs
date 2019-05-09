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
    public partial class TypeManagerForm : Form
    {
        public TypeManagerForm()
        {
            InitializeComponent();
        }

        private void TypeManagerForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
            LoadParentTypeList();
        }

        //加载商品分类
        private void LoadTypes()
        {
            this.lv_type.Items.Clear();

            DataTable dt_type = DBHelper.GetDataTable("select * from Type");
            foreach (DataRow row in dt_type.Rows)
            {
                ListViewItem item = new ListViewItem(row["TypeID"].ToString());
                item.SubItems.Add(row["TypeName"].ToString());
                string parentTypeName = GetTypeName(row["ParentID"].ToString());
                item.SubItems.Add(parentTypeName);
                item.Tag = row["ParentID"].ToString();  //Tag中保存ParentID
                this.lv_type.Items.Add(item);
            }
        }

        //根据TypeID获取TypeName
        private string GetTypeName(string typeID)
        {
            if (typeID == "0")
                return "无";
            else
                return DBHelper.ExecuteScalar("select TypeName from Type where typeID=" + typeID).ToString();
        }

        //加载父级分类列表
        private void LoadParentTypeList()
        {
            this.cb_parentType.ValueMember = "TypeID";
            this.cb_parentType.DisplayMember = "TypeName";
            DataTable dt_parent = DBHelper.GetDataTable("select * from type where parentID=0");
            //在DataTable中新增一行
            DataRow newRow = dt_parent.NewRow();
            newRow["TypeID"] = 0;
            newRow["TypeName"] = "无";
            dt_parent.Rows.Add(newRow);
            this.cb_parentType.DataSource = dt_parent;
            this.cb_parentType.Text = "--请选择--";
        }

        //按钮单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            string typeName = this.txt_typeName.Text;
            string parentTypeID = this.cb_parentType.SelectedValue.ToString();
            if (typeName == "")
            {
                MessageBox.Show("商品分类名称不能为空！");
                return;
            }
            if (this.cb_parentType.Text == "--请选择--")
            {
                MessageBox.Show("请选择父级分类！");
                return;
            }
            string sqlStr = "";
            string flagStr = "";
            if (this.lv_type.SelectedItems.Count == 0)
            {
                //未选中一行，新增商品分类
                sqlStr = string.Format("insert type(TypeName, ParentID) values('{0}',{1})", typeName, parentTypeID);
                flagStr = "新增";
            }
            else
            {
                //选中了一行，编辑该商品分类
                string typeID = this.lv_type.SelectedItems[0].SubItems[0].Text;
                sqlStr = string.Format("update type set TypeName='{0}',ParentID={1} where TypeID={2}", typeName, parentTypeID, typeID);
                flagStr = "修改";
            }
            if (DBHelper.ExecuteNonQuery(sqlStr))
            {
                MessageBox.Show("商品分类" + flagStr + "成功！");
                LoadTypes();
                this.txt_typeName.Text = "";
                this.cb_parentType.Text = "--请选择--";
            }
            else
            {
                MessageBox.Show("商品分类" + flagStr + "失败，请重试！");
            }
           
        }

        //如果选中了一行，填充分类信息，否则清空输入
        private void lv_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lv_type.SelectedItems.Count == 0)
            {
                //未选中一行， 清空输入
                this.button1.Text = "新增分类";
                this.txt_typeName.Text = "";
                this.cb_parentType.Text = "--请选择--";
            }
            else
            {
               //如果选中了一行，填充分类信息
                this.button1.Text = "修改分类";
                this.txt_typeName.Text = this.lv_type.SelectedItems[0].SubItems[1].Text;
                this.cb_parentType.Text = "";
                this.cb_parentType.SelectedText = this.lv_type.SelectedItems[0].SubItems[2].Text;
                this.cb_parentType.SelectedValue = this.lv_type.SelectedItems[0].Tag.ToString();
            }     
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv_type.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的商品分类！");
                return;
            }
            string typeID = this.lv_type.SelectedItems[0].SubItems[0].Text;
            bool result = DBHelper.ExecuteNonQuery("delete type where TypeID=" + typeID);
            if (result)
            {
                MessageBox.Show("商品分类删除成功！");
                LoadTypes();
            }
            else
                MessageBox.Show("商品分类删除失败！");
        }


    }
}
