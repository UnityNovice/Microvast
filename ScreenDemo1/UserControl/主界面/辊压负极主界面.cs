using System.Drawing;
using System.Windows.Forms;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Sunny.UI;
using System.ComponentModel;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using ScreenDemo1.SmallForm;
using Microvast.Model;
using ScreenDemo1;
namespace Test.NewFolder1
{
    public partial class 辊压负极主界面 : UserControl
    {
        public 辊压负极主界面()
        {
            InitializeComponent();
            #region log数据源绑定
            textLogExceptions = new BindingList<LogListSingle>();//绑定相关数据来源
            textLogOpc = new BindingList<LogListSingle>();
            textLogSendNum = new BindingList<LogListSingle>();
            #endregion
        }
        #region 定义
        BindingList<LogListSingle> textLogExceptions; //异常信息log列表
        BindingList<LogListSingle> textLogOpc; //OPC交互信息log列表log
        BindingList<LogListSingle> textLogSendNum;//发送浆料批次号log
        public string ChooseWorkOrder = string.Empty;
        public string ChooseSlurrybatchnumber = string.Empty;
        IniReadWrite Setting = new IniReadWrite();
        #endregion
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
        #region log运行
        public void updateLogs(string logString, int logType = 1)
        {
            DataGridView dgvloglist = null;
            logString = string.Format("{0} {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), logString);
            BindingList<LogListSingle> bindloglist = null;
            BeginInvoke(new Action(delegate
            {
                if (logType == 1)//OPC交互信息
                {
                    bindloglist = textLogExceptions;
                    dgvloglist = dgvDoInfo;
                }
                else if (logType == 2)//OPC异常信息
                {
                    bindloglist = textLogOpc;
                    dgvloglist = dgvExInfo;
                }
                else if (logType == 3)
                {
                    bindloglist = textLogSendNum;
                    //dgvloglist = dgSendNumInfo;
                }
                //if (bindloglist.Count > Global.logsLimit)
                //    bindloglist.RemoveAt(0);
                bindloglist.Add(new LogListSingle(logString, logType));
                dgvloglist.DataSource = bindloglist;
                dgvloglist.Columns[1].Visible = false; //隐藏第二列（logtype）
                dgvloglist.ClearSelection(); //禁止自动选中第一行
                dgvloglist.FirstDisplayedScrollingRowIndex = dgvloglist.Rows[dgvloglist.Rows.Count - 1].Index; //滚动条保持在最后一行
            }));
        }
        #endregion
        #region 控件事件
        private void 主界面_Load(object sender, EventArgs e)
        {
            Setting.inipath = System.Windows.Forms.Application.StartupPath + "\\config.ini";
            Setting.ExistINIFile();
        }
        private void labelResult_Click(object sender, EventArgs e)
        {
            updateLogs("M校验成功：批次号" + Guid.NewGuid().ToString("N").Substring(0, 20) + "\r\n");
        }
        private void labelTitle_Click(object sender, EventArgs e)
        {
            updateLogs("异常:错误码-" + Guid.NewGuid().ToString("N") + "\r\n", 2);
        }
        private void 拆批_Click(object sender, EventArgs e)
        {
            拆批报表 拆批类 = new 拆批报表();
            拆批类.拆批源批次 = "拆批源批次";
            拆批类.拆批后批次1 = "拆批后批次1";
            拆批类.拆批后批次1重量 = "拆批后批次1重量";
            拆批类.拆批后批次2 = "拆批后批次2";
            拆批类.拆批后批次2重量 = "拆批后批次2重量";
            拆批类.拆批操作者 = Form1.mainForm.登录名;
            拆批类.时间 = DateTime.Now;
            拆批类.工序 = Form1.mainForm.当前工序;
            拆批 拆批 = new 拆批(拆批类);
            拆批.Show();
        }
        private void 合批_Click(object sender, EventArgs e)
        {
            合批报表 合批类 = new 合批报表();
            合批类.合批前批次1 = "合批前批次1";
            合批类.合批前批次1重量 = "合批前批次1重量";
            合批类.合批前批次2 = "合批前批次2";
            合批类.合批前批次2重量 = "合批前批次2重量";
            合批类.合批后批次 = "合批后批次";
            合批类.合批后批次重量 = "合批后批次重量";
            合批类.合批操作者 = Form1.mainForm.登录名;
            合批类.时间 = DateTime.Now;
            合批类.工序 = Form1.mainForm.当前工序;
            合批 合批 = new 合批(合批类);
            合批.Show();
        }
        private void 报废_Click(object sender, EventArgs e)
        {
            报废报表 报废类 = new 报废报表();
            报废类.工序 = Form1.mainForm.当前工序;
            报废类.时间 = DateTime.Now;
            报废 报废 = new 报废(报废类);
            报废.Show();
        }
        private void 运行记录_Click_1(object sender, EventArgs e)
        {
            if (dgvDoInfoGroupBox.Visible == false)
            {
                dgvDoInfoGroupBox.Visible = true;
                dgvExInfogroupBox.Visible = true;
                运行记录label.Visible = true;
                异常结果labelTitle.Visible = true;
            }
            else
            {
                dgvDoInfoGroupBox.Visible = false;
                dgvExInfogroupBox.Visible = false;
                运行记录label.Visible = false;
                异常结果labelTitle.Visible = false;
            }
        }
        private void PaintBox(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.GroupBox gbx = (System.Windows.Forms.GroupBox)sender;
            //Pen pen = new Pen(Color.Black, 3);
            //e.Graphics.DrawLine(pen, 1, 12, 8, 12);
            //e.Graphics.DrawLine(pen, e.Graphics.MeasureString(gbx.Text, gbx.Font).Width + 8, 12, gbx.Width - 2, 12);
            //e.Graphics.DrawLine(pen, 1, 12, 1, gbx.Height - 2);
            //e.Graphics.DrawLine(pen, 1, gbx.Height - 2, gbx.Width - 2, gbx.Height - 2);
            //e.Graphics.DrawLine(pen, gbx.Width - 2, 12, gbx.Width - 2, gbx.Height - 2);
            Pen pen = new Pen(Color.White, 5);
            Pen pen1 = new Pen(Color.Silver, 5);
            int topline = 17;
            e.Graphics.DrawLine(pen, 1, topline, 8, topline);
            e.Graphics.DrawLine(pen, e.Graphics.MeasureString(gbx.Text, gbx.Font).Width + 8, topline, gbx.Width - 2, topline);
            e.Graphics.DrawLine(pen, 1, topline, 1, gbx.Height - 2);
            e.Graphics.DrawLine(pen1, 1, gbx.Height - 2, gbx.Width - 2, gbx.Height - 2);
            e.Graphics.DrawLine(pen1, gbx.Width - 2, topline, gbx.Width - 2, gbx.Height - 2);
            /*
            System.Windows.Forms.GroupBox gbx = (System.Windows.Forms.GroupBox)sender;
            Pen pen = new Pen(Color.Black,3);
            e.Graphics.DrawLine(pen, 1, 12, 8, 12);
            e.Graphics.DrawLine(pen, e.Graphics.MeasureString(gbx.Text, gbx.Font).Width + 8, 12, gbx.Width - 2, 12);
            e.Graphics.DrawLine(pen, 1, 12, 1, gbx.Height - 2);
            e.Graphics.DrawLine(pen, 1, gbx.Height - 2, gbx.Width - 2, gbx.Height - 2);
            e.Graphics.DrawLine(pen, gbx.Width - 2, 12, gbx.Width - 2, gbx.Height - 2);
            //e.Graphics.DrawLine(Pens.Black, 1, 12, 8, 12);
            //e.Graphics.DrawLine(Pens.Black, e.Graphics.MeasureString(gbx.Text, gbx.Font).Width + 8, 12, gbx.Width - 2, 12);
            //e.Graphics.DrawLine(Pens.Black, 1, 12, 1, gbx.Height - 2);
            //e.Graphics.DrawLine(Pens.Black, 1, gbx.Height - 2, gbx.Width - 2, gbx.Height - 2);
            //e.Graphics.DrawLine(Pens.Black, gbx.Width - 2, 12, gbx.Width - 2, gbx.Height - 2);
            */
        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel gbx = (System.Windows.Forms.Panel)sender;
            //Pen pen = new Pen(Color.Black, 3);
            //e.Graphics.DrawLine(pen, 1, 12, 8, 12);
            //e.Graphics.DrawLine(pen, e.Graphics.MeasureString(gbx.Text, gbx.Font).Width + 8, 12, gbx.Width - 2, 12);
            //e.Graphics.DrawLine(pen, 1, 12, 1, gbx.Height - 2);
            //e.Graphics.DrawLine(pen, 1, gbx.Height - 2, gbx.Width - 2, gbx.Height - 2);
            //e.Graphics.DrawLine(pen, gbx.Width - 2, 12, gbx.Width - 2, gbx.Height - 2);
            Pen pen = new Pen(Color.White, 3);
            Pen pen1 = new Pen(Color.Silver, 3);
            int topline = 0;
            e.Graphics.DrawLine(pen, 1, topline, 8, topline);
            e.Graphics.DrawLine(pen, e.Graphics.MeasureString(gbx.Text, gbx.Font).Width + 8, topline, gbx.Width - 2, topline);
            e.Graphics.DrawLine(pen, 1, topline, 1, gbx.Height - 2);
            e.Graphics.DrawLine(pen1, 1, gbx.Height - 2, gbx.Width - 2, gbx.Height - 2);
            e.Graphics.DrawLine(pen1, gbx.Width - 2, topline, gbx.Width - 2, gbx.Height - 2);
        }
        #endregion
        public class LogListSingle
        {
            public string singleLog { get; set; }
            public int logtype { get; set; }
            public LogListSingle(string s, int type = 1)
            {
                // TODO: Complete member initialization
                this.singleLog = s;
                this.logtype = type;
            }
        }
    }
}
