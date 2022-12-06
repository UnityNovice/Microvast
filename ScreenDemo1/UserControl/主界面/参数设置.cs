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
namespace Test.NewFolder1
{
    public partial class 参数设置 : UserControl
    {
        public 参数设置()
        {
            InitializeComponent();
            #region log数据源绑定
            #endregion
        }
        IniReadWrite Setting = new IniReadWrite();
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
        private void 读取_Click(object sender, EventArgs e)
        {
            ReadSetting();
            MessageBox.Show("已读取！");
        }
        private void 参数设置_Load(object sender, EventArgs e)
        {
            Setting.inipath = System.Windows.Forms.Application.StartupPath + "\\config.ini";
            Setting.ExistINIFile();
            ReadSetting();
        }
        private void 确认_Click(object sender, EventArgs e)
        {
            if (!IsRightIP(PLC_IPtxt.Text))
            {
                MessageBox.Show("PLC_IP校验错误：格式错误,请重新输入！");
                PLC_IPtxt.Text = Setting.IniReadValue("Setting", "PLC_IP");
                return;
            }
            if (!IsRightIP(本地数据库地址txt.Text))
            {
                MessageBox.Show("本地数据库地址_IP校验错误：格式错误,请重新输入！");
                本地数据库地址txt.Text = Setting.IniReadValue("Setting", "本地数据库地址");
                return;
            }
            if (!IsRightIP(中间数据库地址txt.Text))
            {
                MessageBox.Show("中间数据库地址_IP校验错误：格式错误,请重新输入！");
                本地数据库地址txt.Text = Setting.IniReadValue("Setting", "中间数据库地址");
                return;
            }
            if (ProcessNotxt.Text == "")
            {
                MessageBox.Show("工序错误：不可为空！");
                ProcessNotxt.Text = Setting.IniReadValue("Setting", "当前工序");
                return;
            }
            DialogResult dr = MessageBox.Show("请确认是否写入？", "修改参数", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Setting.IniWriteValue("Setting", "PLC_IP", PLC_IPtxt.Text.Trim());
                Setting.IniWriteValue("Setting", "当前工序", ProcessNotxt.Text.Trim());
                Setting.IniWriteValue("Setting", "本地数据库地址", 本地数据库地址txt.Text.Trim());
                Setting.IniWriteValue("Setting", "本地数据库名", 本地数据库名txt.Text.Trim());
                Setting.IniWriteValue("Setting", "本地数据库用户名", 本地数据库用户名txt.Text.Trim());
                Setting.IniWriteValue("Setting", "本地数据库密码", 本地数据库密码txt.Text.Trim());
                Setting.IniWriteValue("Setting", "中间数据库地址", 中间数据库地址txt.Text.Trim());
                Setting.IniWriteValue("Setting", "中间数据库名", 中间数据库名txt.Text.Trim());
                Setting.IniWriteValue("Setting", "中间数据库用户名", 中间数据库用户名txt.Text.Trim());
                Setting.IniWriteValue("Setting", "中间数据库密码", 中间数据库密码txt.Text.Trim());
                MessageBox.Show("写入完成");
            }
            else
            {
                MessageBox.Show("已取消！");
                //点取消的代码        
            }
        }
        /*
        /// <summary>
        /// 验证IP地址是否合法
        /// </summary>
        /// <param name="ip">要验证的IP地址</param>
        public static bool IsIP(string ip)
        {
            //如果为空，认为验证合格
            if (IsNullOrEmpty(ip))
            {
                return true;
            }
            //清除要验证字符串中的空格
            ip = ip.Trim();
            //模式字符串
            string pattern = @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$";
            //验证
            return RegexHelper.IsMatch(ip, pattern);
        }
        */
        #region  判断IP地址格式是否正确
        /// <summary>
        /// 判断ip地址是否正确，正确返回true 错误false
        /// </summary>
        /// <param name="strLocalIP">需要判断的字符串(IP地址)</param>
        /// <returns>TRUE OR FALSE</returns>
        private bool IsRightIP(string strLocalIP)
        {
            bool bFlag = false;
            bool Result = true;
            Regex regex = new Regex("^[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}$");
            bFlag = regex.IsMatch(strLocalIP);
            if (bFlag == true)
            {
                string[] strTemp = strLocalIP.Split(new char[] { '.' });
                int nDotCount = strTemp.Length - 1; //字符串中.的数量，若.的数量小于3，则是非法的ip地址
                if (3 == nDotCount)//判断 .的数量
                {
                    for (int i = 0; i < strTemp.Length; i++)
                    {
                        if (Convert.ToInt32(strTemp[i]) > 255)   //大于255不符合返回false
                        {
                            Result = false;
                        }
                    }
                }
                else
                {
                    Result = false;
                }
            }
            else
            {
                //输入非数字则提示，不符合IP格式
                //MessageBox.Show("不符合IP格式");
                Result = false;
            }
            return Result;
        }
        #endregion
        private void ReadSetting()
        {
            //PLC_IPtxt.Text = "";
            //ProcessNotxt.Text = "";
            //本地数据库地址txt.Text = "";
            //本地数据库名txt.Text = "";
            //本地数据库用户名txt.Text = "";
            //本地数据库密码txt.Text = "";
            //中间数据库地址txt.Text = "";
            //中间数据库名txt.Text = "";
            //中间数据库用户名txt.Text = "";
            //中间数据库密码txt.Text = "";
            PLC_IPtxt.Text = Setting.IniReadValue("Setting", "PLC_IP");
            ProcessNotxt.Text = Setting.IniReadValue("Setting", "当前工序");
            PLCType.Text = Setting.IniReadValue("Setting", "PLC类型");
            本地数据库地址txt.Text = Setting.IniReadValue("Setting", "本地数据库地址");
            本地数据库名txt.Text = Setting.IniReadValue("Setting", "本地数据库名");
            本地数据库用户名txt.Text = Setting.IniReadValue("Setting", "本地数据库用户名");
            本地数据库密码txt.Text = Setting.IniReadValue("Setting", "本地数据库密码");
            中间数据库地址txt.Text = Setting.IniReadValue("Setting", "中间数据库地址");
            中间数据库名txt.Text = Setting.IniReadValue("Setting", "中间数据库名");
            中间数据库用户名txt.Text = Setting.IniReadValue("Setting", "中间数据库用户名");
            中间数据库密码txt.Text = Setting.IniReadValue("Setting", "中间数据库密码");
        }
    }
}
