using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Diagnostics;
using ScreenDemo1;
using Microvast.Common.Utils;
using Microvast.Model;
using Sunny.UI;
using Microvast.Common.Vuex;
using Microvast.Service;
namespace Test
{
    public partial class 登录 : UIForm
    {
        public 登录()
        {
            InitializeComponent();
            login = this;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        IniReadWrite Setting = new IniReadWrite();
        public static 登录 login;
        public string LoginUserName = "";
        private Thread tp5 = null;
        private void 登录_Load(object sender, EventArgs e)
        {
            Setting.inipath = System.Windows.Forms.Application.StartupPath + "\\config.ini";
            Setting.ExistINIFile();
        }
        private void 登录按钮_Click(object sender, EventArgs e)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            #region 旧
            ////var 用户=sqlSugarServerHelper.db.Queryable<用户管理>().First(a => txtUser.Text == a.账号 && txtPassword.Text == a.密码);
            ////var 用户角色ID = sqlSugarServerHelper.db.Queryable<权限管理>().First(a =>a.角色ID== 用户.角色).角色ID;
            ////string 用户角色 = "";
            ////if (string.IsNullOrEmpty(用户角色ID))
            ////{
            ////    用户角色 = sqlSugarServerHelper.db.Queryable<角色管理>().First(a => a.角色编码 == 用户角色ID).角色名称;
            ////}
            ////用户角色先为""表示为管理员
            //bool isSuccess = false;
            //var 用户 = sqlSugarServerHelper.db.Queryable<用户管理>().First(a => txtUser.Text == a.账号 && txtPassword.Text == a.密码);
            //if (用户 != null)
            //{
            //    var 权限管理 = sqlSugarServerHelper.db.Queryable<权限管理>().First(a => a.角色ID == 用户.角色);
            //    if (权限管理 != null)
            //    {
            //        var 角色名称 = sqlSugarServerHelper.db.Queryable<角色管理>().First(a => a.角色编码 == 权限管理.角色ID).角色名称;
            //        isSuccess = true;
            //        this.Hide();
            //        Form1 frmMain = new Form1();
            //        frmMain.权限等级 = 2;
            //        frmMain.登录名 = txtUser.Text;
            //        frmMain.角色 = 角色名称;
            //        frmMain.Show();
            //    }
            //}
            //if (!isSuccess)
            //{
            //    MessageBox.Show("账号密码错误！");
            //}
            ////if (((txtUser.Text == "admin" || txtUser.Text == "Eysen") & txtPassword.Text == "123456"))
            ////{
            ////    this.Hide();
            ////    Form1 frmMain = new Form1();
            ////    if (txtUser.Text == "admin")
            ////    {
            ////        frmMain.权限等级 = 2;
            ////        frmMain.登录名 = txtUser.Text;
            ////        frmMain.角色 = txtUser.Text;
            ////    }
            ////    else
            ////    {
            ////        frmMain.权限等级 = 1;
            ////        frmMain.登录名 = txtUser.Text;
            ////        frmMain.角色 = txtUser.Text;
            ////    }
            ////    frmMain.Show();
            ////}
            ////else
            ////{
            ////    MessageBox.Show("密码错误！");
            ////} 
            #endregion
            var 用户 = sqlSugarServerHelper.db.Queryable<用户管理>().First(a => txtUser.Text == a.工号 && txtPassword.Text == a.密码 && a.状态 == "启用");
            if (用户 != null)
            {
                if (用户.工序 != Setting.IniReadValue("Setting", "当前工序") && 用户.角色 != "管理员")
                {
                    MessageBox.Show("用户角色无法登录此工序系统！");
                    return;
                }
                var 权限管理 = sqlSugarServerHelper.db.Queryable<权限管理>().First(a => a.角色ID == 用户.角色);
                if (权限管理 != null)
                {
                    Store.角色 = 权限管理.角色ID;
                    Store.名称 = 用户.姓名;
                    Store.工号 = 用户.工号;
                //    通用Service.记录生产报工($"{Store.名称}登录了系统");
                    通用Service.记录生产报工($"{Store.名称}登录了系统", Setting.IniReadValue("Setting", "当前工序"));
                    this.Hide();
                    Form1 frmMain = new Form1();
                    frmMain.当前允许菜单项 = 权限管理.菜单项ID;
                    frmMain.登录名 = 用户.姓名;
                    frmMain.角色 = 权限管理.角色ID;
                    frmMain.工号 = 用户.工号;
                    ///
                    /// 
                    /// 
                    /// 生产报工，将人员的登录登出写入数据库！！！
                    /// 
                    /// 工号、角色、名称、日期
                    /// 
                    ///
                    // sqlSugarServerHelper.db.
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("该用户的角色错误！");
                }
            }
            else
            {
                MessageBox.Show("该工序不存在此用户或密码错误！");
            }
        }
        private void 取消_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            System.Environment.Exit(0);
        }
        private void 登录_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("请通过取消按钮关闭界面");
        }
    }
}
