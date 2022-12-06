using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Sunny.UI.Win32;
using Test;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ScreenDemo1.SmallForm
{
    public partial class AGV叫料 : UIForm
    {
        public AGV叫料()
        {
            InitializeComponent();
        }
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
            List<string> list = new List<string>();
            foreach (string a in Transfer.ItemsRight)
            {
                list.Add(a);
            }
            string str = "确定叫料：\r\n";
            for(int a = 0; a < list.Count; a++)
            {
                str = str+list[a]+ ";\r\n";
            }
            MessageBox.Show(str);
            this.Close();
        }
    }
}
