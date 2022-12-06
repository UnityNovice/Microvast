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
using Microvast.Service;
using Microvast.ViewModel;
using Microvast.Common.Utils;
using Microvast.Model;
using ScreenDemo1;
namespace Test.NewFolder1
{
    public partial class 涂布正极主界面 : UserControl
    {
        public 涂布正极主界面()
        {
            InitializeComponent();
            #region log数据源绑定
            textLogExceptions = new BindingList<LogListSingle>();//绑定相关数据来源
            textLogOpc = new BindingList<LogListSingle>();
            textLogSendNum = new BindingList<LogListSingle>();
            #endregion
            加载工单();
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
        private void 订单结束_Click(object sender, EventArgs e)
        {
            if (当前选择工单.Text == "")
            {
                MessageBox.Show("当前无工单！");
                return;
            }
            DialogResult dr = MessageBox.Show("请确认是否结束工单？", "工单", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
                string sql = $"Update  生产工单 SET " + " [状态] = " + "'已完成'" + " WHERE [工单编号]= '" + ChooseWorkOrder + "' AND " + "[工序]='" + 当前配置工序 + "'";
                int res = sqlSugarServerHelper.db.Ado.ExecuteCommand(sql.ToString());
                if (res != 0)
                {
                    MessageBox.Show("已完成该工单！");
                    加载工单();
                }
                else
                {
                    MessageBox.Show("工单结束错误！");
                }
            }
            else
            {
                //点取消的代码        }
            }
        }
        private void 上料_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("请确认是否投入？", "投料", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("投入完成");
            }
            else
            {
                //点取消的代码        
            }
        }
        string 当前配置工序 = "";
        private void 主界面_Load(object sender, EventArgs e)
        {
            Setting.inipath = System.Windows.Forms.Application.StartupPath + "\\config.ini";
            Setting.ExistINIFile();
            当前配置工序 = Setting.IniReadValue("Setting", "当前工序");
        }
        private void labelResult_Click(object sender, EventArgs e)
        {
            updateLogs("M校验成功：批次号" + Guid.NewGuid().ToString("N").Substring(0, 20) + "\r\n");
        }
        private void labelTitle_Click(object sender, EventArgs e)
        {
            updateLogs("异常:错误码-" + Guid.NewGuid().ToString("N") + "\r\n", 2);
        }
        private void 读取工单_Click(object sender, EventArgs e)
        {
            //List<WorkOrder> workOrders = new List<WorkOrder>();
            //for (int i = 0; i < 4; i++)
            //{
            //    WorkOrder workOrder = new WorkOrder();
            //    workOrder.workordernum = "MV32022092900" + i.ToString();
            //    workOrder.Status = "未生产";
            //    workOrder.Priority = "一般";
            //    if (i == 3)
            //    {
            //        workOrder.Priority = "紧急";
            //    }
            //    workOrders.Add(workOrder);
            //}
            //AddWorkOrderPanel(workOrders);
            加载工单();
        }
        private void 工单确认_Click(object sender, EventArgs e)
        {
            if (当前选择工单.Text != "")
            {
                MessageBox.Show("当前已有工单！");
                return;
            }
            if (ChooseWorkOrder == "")
            {
                MessageBox.Show("未选择工单！");
                return;
            }
            DialogResult dr = MessageBox.Show("工单号为：" + ChooseWorkOrder + "\r\n请确认选择该工单？", "工单", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Setting.IniWriteValue("Setting", "搅拌正极工单", ChooseWorkOrder);
                当前选择工单.Text = ChooseWorkOrder;
                SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
                string sql = $"Update  生产工单 SET " + " [状态] = " + "'生产中'" + " WHERE [工单编号]= '" + ChooseWorkOrder + "' AND " + "[工序]='" + 当前配置工序 + "'";
                int res = sqlSugarServerHelper.db.Ado.ExecuteCommand(sql.ToString());
                if (res != 0)
                {
                    MessageBox.Show("已启动工单！");
                    加载工单();
                }
                else
                {
                    MessageBox.Show("工单启动错误！");
                }
                //MessageBox.Show("工单已选择");
                //List<SlurrybatchNumber> list = new List<SlurrybatchNumber>();
                //for (int a = 0; a < 4; a++)
                //{
                //    SlurrybatchNumber slurrybatchNumberpanel = new SlurrybatchNumber();
                //    slurrybatchNumberpanel.Status = "未使用";
                //    slurrybatchNumberpanel.slurrybatchnumber = "MV9sdsdwa00" + a.ToString();
                //    if (a == 3) slurrybatchNumberpanel.Status = "已使用";
                //    list.Add(slurrybatchNumberpanel);
                //}
                //AddSlurrybatchNumber(list);
            }
            else
            {
                //点取消的代码        }
            }
        }
        private void 工单暂停_Click(object sender, EventArgs e)
        {
            if (当前选择工单.Text == "")
            {
                MessageBox.Show("当前无工单！");
                return;
            }
            DialogResult dr = MessageBox.Show("请确认是否暂停工单？", "工单暂停", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
                string sql = $"Update  生产工单 SET " + " [状态] = " + "'暂停中'" + " WHERE [工单编号]= '" + ChooseWorkOrder + "' AND " + "[工序]='" + 当前配置工序 + "'";
                int res = sqlSugarServerHelper.db.Ado.ExecuteCommand(sql.ToString());
                if (res != 0)
                {
                    MessageBox.Show("已暂停该工单！");
                    加载工单();
                }
                else
                {
                    MessageBox.Show("工单暂停错误！");
                }
            }
            else
            {
                //点取消的代码        }
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton radioButtonClick = sender as System.Windows.Forms.RadioButton;
            ChooseWorkOrder = radioButtonClick.Text.ToString();
        }
        private void 读取批次号_Click(object sender, EventArgs e)
        {
            if (当前选择工单.Text == "" || ChooseWorkOrder == "")
            {
                MessageBox.Show("请先选择工单!");
                return;
            }
            List<SlurrybatchNumber> list = new List<SlurrybatchNumber>();
            for (int a = 0; a < 4; a++)
            {
                SlurrybatchNumber slurrybatchNumberpanel = new SlurrybatchNumber();
                slurrybatchNumberpanel.Status = "未使用";
                slurrybatchNumberpanel.slurrybatchnumber = "MV9sdsdwa00" + a.ToString();
                if (a == 3) slurrybatchNumberpanel.Status = "已使用";
                list.Add(slurrybatchNumberpanel);
            }
            AddSlurrybatchNumber(list);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton radioButtonClick = sender as System.Windows.Forms.RadioButton;
            ChooseSlurrybatchnumber = radioButtonClick.Text.ToString();
        }
        private void 批次号确认_Click(object sender, EventArgs e)
        {
            if (ChooseSlurrybatchnumber == "")
            {
                MessageBox.Show("未选择批次号！");
                return;
            }
            DialogResult dr = MessageBox.Show("工单号为：" + ChooseSlurrybatchnumber + "\r\n请确认选择该工单？", "工单", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Setting.IniWriteValue("Setting", "搅拌正极浆料批次号", ChooseSlurrybatchnumber);
                当前选择批次号.Text = ChooseSlurrybatchnumber;
                MessageBox.Show("批次号已选择");
            }
            else
            {
                //点取消的代码        }
            }
        }
        private void 确认浆料罐号_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("浆料罐号为：0000000" + "\r\n浆料批次号为：MV9sdsdwa001;MV9sdsdwa002; " + "\r\n请确认选择该罐号？", "浆料选择", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                // Setting.IniWriteValue("Setting", "搅拌正极浆料批次号", ChooseSlurrybatchnumber);
                当前选择批次号.Text = ChooseSlurrybatchnumber;
                MessageBox.Show("浆料罐号已选择");
            }
            else
            {
                //点取消的代码        }
            }
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
        private void 运行记录_Click(object sender, EventArgs e)
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
        private void AGV叫料_Click(object sender, EventArgs e)
        {
            AGV叫料 aGV = new AGV叫料();
            aGV.Show();
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
            Pen pen = new Pen(Color.White, 3);
            Pen pen1 = new Pen(Color.Silver, 3);
            int topline = 12;
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
        #region AddPanel
        private void AddWorkOrderPanel(List<WorkOrder> workOrders)
        {
            WorkOrderPanel.Controls.Clear();
            #region workorderPanelHead
            Label Headlabel1 = new Label();
            Headlabel1.AutoSize = true;
            Headlabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            Headlabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            Headlabel1.Location = new System.Drawing.Point(53, 4);
            Headlabel1.Name = "WorkOrderHeadlabel1";
            Headlabel1.Size = new System.Drawing.Size(82, 30);
            Headlabel1.TabIndex = 15;
            Headlabel1.Text = "工单号";
            Label Headlabel2 = new Label();
            Headlabel2.AutoSize = true;
            Headlabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            Headlabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            Headlabel2.Location = new System.Drawing.Point(398, 4);
            Headlabel2.Name = "label8";
            Headlabel2.Size = new System.Drawing.Size(82, 30);
            Headlabel2.TabIndex = 16;
            Headlabel2.Text = "优先级";
            Label Headlabel3 = new Label();
            Headlabel3.AutoSize = true;
            Headlabel3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            Headlabel3.ForeColor = System.Drawing.SystemColors.Desktop;
            Headlabel3.Location = new System.Drawing.Point(498, 4);
            Headlabel3.Name = "label9";
            Headlabel3.Size = new System.Drawing.Size(59, 30);
            Headlabel3.TabIndex = 17;
            Headlabel3.Text = "状态";
            WorkOrderPanel.Controls.Add(Headlabel1);
            WorkOrderPanel.Controls.Add(Headlabel2);
            WorkOrderPanel.Controls.Add(Headlabel3);
            #endregion
            for (int i = 0; i < workOrders.Count; i++)
            {
                System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton();
                radioButton.Name = workOrders[i].workordernum;
                radioButton.Text = workOrders[i].workordernum;
                radioButton.AutoSize = true;
                radioButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
                radioButton.Location = new System.Drawing.Point(23, 42 + i * 37);
                radioButton.Size = new System.Drawing.Size(220, 31);
                radioButton.TabIndex = 0;
                radioButton.TabStop = true;
                radioButton.UseVisualStyleBackColor = true;
                radioButton.CheckedChanged += new System.EventHandler(radioButton_CheckedChanged);
                if (i == 0) radioButton.Checked = true;
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
                label.ForeColor = System.Drawing.SystemColors.Desktop;
                label.Location = new System.Drawing.Point(398, 44 + i * 37);
                label.Name = workOrders[i].Priority;
                label.Size = new System.Drawing.Size(52, 27);
                label.TabIndex = 18;
                label.Text = workOrders[i].Priority;
                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
                label2.ForeColor = System.Drawing.SystemColors.Desktop;
                label2.Location = new System.Drawing.Point(498, 44 + i * 37);
                label2.Name = workOrders[i].Status;
                label2.Size = new System.Drawing.Size(52, 27);
                label2.TabIndex = 18;
                label2.Text = workOrders[i].Status;
                if (workOrders[i].Priority == "紧急")
                {
                    radioButton.ForeColor = Color.Red;
                    label.ForeColor = Color.Red;
                    label2.ForeColor = Color.Red;
                }
                WorkOrderPanel.Controls.Add(radioButton);
                WorkOrderPanel.Controls.Add(label);
                WorkOrderPanel.Controls.Add(label2);
            }
        }
        private void AddSlurrybatchNumber(List<SlurrybatchNumber> slurrybatchNumber)
        {
            SlurrybatchNumberpanel.Controls.Clear();
            #region workorderPanelHead
            Label Headlabel = new Label();
            Headlabel.AutoSize = true;
            Headlabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            Headlabel.ForeColor = System.Drawing.SystemColors.Desktop;
            Headlabel.Location = new System.Drawing.Point(30, 4);
            Headlabel.Name = "浆料批次号label1";
            Headlabel.Size = new System.Drawing.Size(128, 30);
            Headlabel.TabIndex = 15;
            Headlabel.Text = "浆料批次号";
            Label Headlabel1 = new Label();
            Headlabel1.AutoSize = true;
            Headlabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            Headlabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            Headlabel1.Location = new System.Drawing.Point(280, 4);
            Headlabel1.Name = "浆料批次号状态label1";
            Headlabel1.Size = new System.Drawing.Size(128, 30);
            Headlabel1.TabIndex = 15;
            Headlabel1.Text = "状态";
            SlurrybatchNumberpanel.Controls.Add(Headlabel);
            SlurrybatchNumberpanel.Controls.Add(Headlabel1);
            #endregion
            for (int i = 0; i < slurrybatchNumber.Count; i++)
            {
                System.Windows.Forms.RadioButton radioButton = new System.Windows.Forms.RadioButton();
                radioButton.Name = slurrybatchNumber[i].slurrybatchnumber.ToString();
                radioButton.Text = slurrybatchNumber[i].slurrybatchnumber.ToString();
                radioButton.AutoSize = true;
                radioButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
                radioButton.Location = new System.Drawing.Point(10, 42 + i * 37);
                radioButton.Size = new System.Drawing.Size(220, 31);
                radioButton.TabIndex = 0;
                radioButton.TabStop = true;
                radioButton.UseVisualStyleBackColor = true;
                radioButton.CheckedChanged += new System.EventHandler(radioButton1_CheckedChanged);
                if (i == 0) radioButton.Checked = true;
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
                label.ForeColor = System.Drawing.SystemColors.Desktop;
                label.Location = new System.Drawing.Point(280, 44 + i * 37);
                label.Name = slurrybatchNumber[i].Status;
                label.Size = new System.Drawing.Size(52, 27);
                label.TabIndex = 18;
                label.Text = slurrybatchNumber[i].Status;
                if (slurrybatchNumber[i].Status == "已使用")
                {
                    radioButton.ForeColor = Color.Green;
                    label.ForeColor = Color.Green;
                }
                SlurrybatchNumberpanel.Controls.Add(radioButton);
                SlurrybatchNumberpanel.Controls.Add(label);
            }
        }
        #endregion
        //public class WorkOrder
        //{
        //    public string workordernum { get; set; }
        //    public string Priority { get; set; }
        //    public string Status { get; set; }
        //}
        public class SlurrybatchNumber
        {
            public string slurrybatchnumber { get; set; }
            public string Status { get; set; }
        }
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
        #region 方法
        public void 加载工单()
        {
            // var workOrders = 涂布Service.正极加载工单();
            var workOrders = 通用Service.加载工单(当前配置工序);
            AddWorkOrderPanel(workOrders);
        }
        #endregion
        private void uiButton1_Click(object sender, EventArgs e)
        {
            string scanStr = 当前物料二维码txt.Text;
            var 扫描解析 = 扫描Service.GetScan(scanStr);
            if (!string.IsNullOrEmpty(扫描解析.数量))
            {
                当前物料生产日期label.Text = 扫描解析.生产日期;
                当前物料批次号label.Text = 扫描解析.批次号;
            }
            else
            {
                MessageBox.Show("非法扫描码");
            }
        }
    }
}
