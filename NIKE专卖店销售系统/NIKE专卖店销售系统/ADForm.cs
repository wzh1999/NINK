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
    public partial class ADForm : Form
    {
        public ADForm()
        {
            InitializeComponent();
        }

        private void ADForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Settings.AdImagePath);
        }
    }
}
