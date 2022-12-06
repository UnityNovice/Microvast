using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microvast.Common.Utils;
using Microvast.Model;
using Sunny.UI;
using Sunny.UI.Win32;
using Test;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ScreenDemo1.SmallForm
{
    public partial class 拆批 : UIForm
    {
        public 拆批报表 拆批记录变量 = null;
        public 拆批()
        {
            InitializeComponent();
        }
        public 拆批(拆批报表 拆批)
        {
            拆批记录变量 = 拆批;
            InitializeComponent();
        }
        public event Action<List<string>> ByValueEvent;
        #region 双缓冲
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;//用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        #endregion
        private void 确认_Click(object sender, EventArgs e)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            拆批记录变量.拆批后批次1 = this.拆批批次号.Text.ToString();
            拆批记录变量.拆批后批次1重量 = this.拆批后该批重量.Text.ToString();
            sqlSugarServerHelper.db.Insertable(拆批记录变量).ExecuteCommand();
            this.Close();
        }
        private void NoCn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }
        private void OnlyNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = e.KeyChar;
            if ((key < '0' || key > '9') && (key != 8 && key != 46))
            {
                e.Handled = true;
            }
        }
    }
}
