using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microvast.Common.Utils;
using Microvast.Common.Vuex;
using Microvast.Model;
using Microvast.Service;
using S7.Net;
using ScreenDemo1.Pages.基础信息;
using Sunny.UI;
using Test;
using Test.NewFolder1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace ScreenDemo1
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
            mainForm = this;
        }
        #region 参数
        public static Form1 mainForm;
        private 搅拌正极主界面 搅拌正极主界面 = new 搅拌正极主界面();
        private 搅拌负极主界面 搅拌负极主界面 = new 搅拌负极主界面();
        private 涂布正极主界面 涂布正极主界面 = new 涂布正极主界面();
        private 涂布负极主界面 涂布负极主界面 = new 涂布负极主界面();
        private 辊压正极主界面 辊压正极主界面 = new 辊压正极主界面();
        private 辊压负极主界面 辊压负极主界面 = new 辊压负极主界面();
        private 参数设置 参数设置 = new 参数设置();
        private 数采报表 数采报表 = new 数采报表();
        public string 当前工序 = string.Empty;
        IniReadWrite Setting = new IniReadWrite();
        public int 权限等级 = 0;
        public string 当前允许菜单项 = "";
        public string 角色 = "";
        public string 登录名 = "";
        public string 工号 = "";
        public List<DataRefence> dataRefenceList = new List<DataRefence>();
        public Dictionary<string, LimitData> limitDatas = new Dictionary<string, LimitData>();
        public string PLC类型 = "";
        S7HelperNew plc = new S7HelperNew();
        #endregion
        private void InitMenu()
        {
            #region 菜单栏数据
            #region 当前工序
            ;
            // Aside.CreateNode("控件", 61451, 24, pageIndex);
            //System.Windows.Forms.TreeNode 当前工序treeNode = Menu1.CreateNode(当前工序, 61451, 24, pageIndex);
            //Menu1.CreateChildNode(当前工序treeNode, AddPage("", ++pageIndex));
            // Aside.CreateChildNode(parent, AddPage(new FAvatar(), ++pageIndex));
            System.Windows.Forms.TreeNode 正极搅拌treeNode = new System.Windows.Forms.TreeNode("正极搅拌");
            System.Windows.Forms.TreeNode 负极搅拌treeNode = new System.Windows.Forms.TreeNode("负极搅拌");
            System.Windows.Forms.TreeNode 搅拌管理treeNode = new System.Windows.Forms.TreeNode("▼搅拌管理",
                new System.Windows.Forms.TreeNode[] { 正极搅拌treeNode, 负极搅拌treeNode });
            System.Windows.Forms.TreeNode 正极涂布treeNode = new System.Windows.Forms.TreeNode("正极涂布");
            System.Windows.Forms.TreeNode 负极涂布treeNode = new System.Windows.Forms.TreeNode("负极涂布");
            System.Windows.Forms.TreeNode 涂布管理treeNode = new System.Windows.Forms.TreeNode("▼涂布管理",
                new System.Windows.Forms.TreeNode[] { 正极涂布treeNode, 负极涂布treeNode });
            System.Windows.Forms.TreeNode 正极辊压treeNode = new System.Windows.Forms.TreeNode("正极辊压");
            System.Windows.Forms.TreeNode 负极辊压treeNode = new System.Windows.Forms.TreeNode("负极辊压");
            System.Windows.Forms.TreeNode 辊压管理treeNode = new System.Windows.Forms.TreeNode("▼辊压管理",
                new System.Windows.Forms.TreeNode[] { 正极辊压treeNode, 负极辊压treeNode });
            System.Windows.Forms.TreeNode 数采配置treeNode = new System.Windows.Forms.TreeNode("数采配置");
            System.Windows.Forms.TreeNode 数采报表treeNode = new System.Windows.Forms.TreeNode("数采报表");
            System.Windows.Forms.TreeNode 数采管理treeNode = new System.Windows.Forms.TreeNode("▼数采管理",
                 new System.Windows.Forms.TreeNode[] { 数采配置treeNode, 数采报表treeNode });
            数采管理treeNode.Name = "数采管理";
            System.Windows.Forms.TreeNode 参数设置treeNode = new System.Windows.Forms.TreeNode("▼参数设置");
            参数设置treeNode.Name = "参数设置";
            #endregion
            #region 报表管理
            System.Windows.Forms.TreeNode 过站数据报表treeNode = new System.Windows.Forms.TreeNode("过站数据报表");
            System.Windows.Forms.TreeNode 产品数据报表treeNode = new System.Windows.Forms.TreeNode("产品数据报表");
            System.Windows.Forms.TreeNode 物料绑定报表treeNode = new System.Windows.Forms.TreeNode("物料绑定报表");
            System.Windows.Forms.TreeNode 异常管理报表treeNode = new System.Windows.Forms.TreeNode("异常管理报表");
            System.Windows.Forms.TreeNode 工单过站监控报表treeNode = new System.Windows.Forms.TreeNode("工单过站监控报表");
            System.Windows.Forms.TreeNode 工单报表treeNode = new System.Windows.Forms.TreeNode("工单报表");
            System.Windows.Forms.TreeNode 设备状态报表treeNode = new System.Windows.Forms.TreeNode("设备状态报表");
            System.Windows.Forms.TreeNode 生产报工treeNode = new System.Windows.Forms.TreeNode("生产报工");
            System.Windows.Forms.TreeNode 拆批treeNode = new System.Windows.Forms.TreeNode("拆批报表");
            System.Windows.Forms.TreeNode 合批treeNode = new System.Windows.Forms.TreeNode("合批报表");
            System.Windows.Forms.TreeNode 报废treeNode = new System.Windows.Forms.TreeNode("报废报表");
            System.Windows.Forms.TreeNode 报表管理treeNode = new System.Windows.Forms.TreeNode("▼报表管理", new System.Windows.Forms.TreeNode[] {
            过站数据报表treeNode,
            产品数据报表treeNode,
            物料绑定报表treeNode,
            异常管理报表treeNode,
            工单过站监控报表treeNode,
            工单报表treeNode,
            设备状态报表treeNode,
            生产报工treeNode,
            拆批treeNode,
            合批treeNode,
            报废treeNode
            });
            #endregion
            #region 基础数据
            System.Windows.Forms.TreeNode 用户管理treeNode = new System.Windows.Forms.TreeNode("用户管理");
            System.Windows.Forms.TreeNode 角色管理treeNode = new System.Windows.Forms.TreeNode("角色管理");
            System.Windows.Forms.TreeNode 权限管理treeNode = new System.Windows.Forms.TreeNode("权限管理");
            // System.Windows.Forms.TreeNode 异常日志treeNode = new System.Windows.Forms.TreeNode("异常日志");
            // System.Windows.Forms.TreeNode 操作日志treeNode = new System.Windows.Forms.TreeNode("操作日志");
            System.Windows.Forms.TreeNode 基础数据treeNode = new System.Windows.Forms.TreeNode("▼基础数据", new System.Windows.Forms.TreeNode[] {
            用户管理treeNode,
            角色管理treeNode,
            权限管理treeNode,
           // 异常日志treeNode,
           // 操作日志treeNode
            });
            #endregion
            #region 业务主数据
            // System.Windows.Forms.TreeNode 产品基础数据treeNode = new System.Windows.Forms.TreeNode("产品基础数据");
            // System.Windows.Forms.TreeNode 工序基础数据treeNode = new System.Windows.Forms.TreeNode("工序基础数据");
            System.Windows.Forms.TreeNode 基础物料信息表treeNode = new System.Windows.Forms.TreeNode("物料基础数据");
            // System.Windows.Forms.TreeNode 料架物料信息treeNode = new System.Windows.Forms.TreeNode("料架物料信息");
            System.Windows.Forms.TreeNode 设备台账treeNode = new System.Windows.Forms.TreeNode("设备基础数据");
            System.Windows.Forms.TreeNode 产线基础数据treeNode = new System.Windows.Forms.TreeNode("产线基础数据");
            System.Windows.Forms.TreeNode 班次基础数据treeNode = new System.Windows.Forms.TreeNode("班次基础数据");
            System.Windows.Forms.TreeNode 载具基础数据treeNode = new System.Windows.Forms.TreeNode("载具基础数据");
            System.Windows.Forms.TreeNode 生产工单treeNode = new System.Windows.Forms.TreeNode("工单基础数据");
            //System.Windows.Forms.TreeNode 批次管理treeNode = new System.Windows.Forms.TreeNode("批次管理");
            //System.Windows.Forms.TreeNode 单位基础数据treeNode = new System.Windows.Forms.TreeNode("单位基础数据");
            System.Windows.Forms.TreeNode 投料口基础数据treeNode = new System.Windows.Forms.TreeNode("BOM基础数据");
            System.Windows.Forms.TreeNode 工艺配方treeNode = new System.Windows.Forms.TreeNode("工艺配方");
            System.Windows.Forms.TreeNode 工艺路线treeNode = new System.Windows.Forms.TreeNode("工艺路线");
            System.Windows.Forms.TreeNode 业务主数据treeNode = new System.Windows.Forms.TreeNode("▼业务主数据", new System.Windows.Forms.TreeNode[] {
            生产工单treeNode,
            基础物料信息表treeNode,

            投料口基础数据treeNode,
       
                //产品基础数据treeNode,
            //工序基础数据treeNode,
            // 料架物料信息treeNode,
            设备台账treeNode,
            产线基础数据treeNode,
            班次基础数据treeNode,
            载具基础数据treeNode,
            //批次管理treeNode,
            //单位基础数据treeNode,
            工艺配方treeNode,
            工艺路线treeNode,
            });
            #endregion
            #endregion
            UserName.Text = 登录名;
            Permissions.Text = 角色;
            UserNum.Text = 工号;
            this.Menu1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { 搅拌管理treeNode, 涂布管理treeNode, 辊压管理treeNode, 报表管理treeNode, 基础数据treeNode, 业务主数据treeNode, 数采管理treeNode, 参数设置treeNode });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Setting.inipath = System.Windows.Forms.Application.StartupPath + "\\config.ini";
            Setting.ExistINIFile();
            //TreeNode parent = Menu.CreateNode("配料", 61451, 24, 1);
            当前工序 = Setting.IniReadValue("Setting", "当前工序");
            当前允许菜单项 = 当前允许菜单项.Replace("当前工序", 当前工序);
            PLC类型 = Setting.IniReadValue("Setting", "PLC类型");
            InitMenu();
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            dataRefenceList = sqlSugarServerHelper.db.Queryable<DataRefence>().Where(a => a.工序 == 当前工序).ToList();
            foreach (DataRefence dataRefence in dataRefenceList)
            {
                if (dataRefence.数据号 != "" && dataRefence.数据号 != null)
                {
                    LimitData limitData = new LimitData();
                    limitData.process_no = dataRefence.工序;
                    limitData.data_no = dataRefence.数据号;
                    if (dataRefence.数据类型.ToString() != null && dataRefence.数据类型.ToString() != "")
                        limitData.data_type = int.Parse(dataRefence.数据类型.ToString());
                    limitData.data_name = dataRefence.数据名称;
                    limitData.PLC地址 = dataRefence.PLC地址;
                    limitData.length_check = "";
                    limitDatas.Add(limitData.data_no, limitData);
                }
            }
            //if (!plc.PLCCon(Setting.IniReadValue("Setting", "PLC_IP"))) MessageBox.Show("plc未链接！");
            switch (当前工序)
            {
                case "正极搅拌": this.uiPanel1.Controls.Add(搅拌正极主界面); break;
                case "负极搅拌": this.uiPanel1.Controls.Add(搅拌负极主界面); break;
                case "正极涂布": this.uiPanel1.Controls.Add(涂布正极主界面); break;
                case "负极涂布": this.uiPanel1.Controls.Add(涂布负极主界面); break;
                case "正极辊压": this.uiPanel1.Controls.Add(辊压正极主界面); break;
                case "负极辊压": this.uiPanel1.Controls.Add(辊压负极主界面); break;
                default:
                    MessageBox.Show("无当前配置界面！");
                    break;
            }
        }
        private void uiNavMenu1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Text.ToString().Replace("▼", ""))
            {
                case "正极搅拌": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(搅拌正极主界面); break;
                case "负极搅拌": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(搅拌负极主界面); break;
                case "正极涂布": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(涂布正极主界面); break;
                case "负极涂布": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(涂布负极主界面); break;
                case "正极辊压": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(辊压正极主界面); break;
                case "负极辊压": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(辊压负极主界面); break;
                case "用户管理": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("用户管理", "", "")); break;
                case "角色管理": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("角色管理", "", "")); break;
                case "异常日志": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("异常日志", "", "")); break;
                case "操作日志": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("操作日志", "", "")); break;
                case "权限管理": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("权限管理", "", "")); break;

                #region 
                //case "产品基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("产品型号", "", "")); break;
                //case "工序基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("工序管理", "", "")); break;
                case "设备基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("设备台账", "", "")); break;
                case "产线基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("产线基础数据", "", "")); break;
                case "班次基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("班次基础数据", "", "")); break;
                case "载具基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("载具基础数据", "", "")); break;
                case "工单基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("工单基础数据", "", "")); break;
              //  case "批次管理": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("批次管理", "", "")); break;
              //  case "单位基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("单位基础数据", "", "")); break;
                case "BOM基础数据": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("投料口基础数据", "", "")); break;
                case "工艺路线": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("工艺参数信息", "", "")); break;
                case "工艺配方": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("工艺配方信息", "", "")); break;
                #endregion

                case "拆批报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("拆批报表", "", "")); break;
                case "合批报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("合批报表", "", "")); break;
                case "过站数据报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("过站数据报表", "工单号", "日期")); break;
                case "产品数据报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("产品数据报表", "", "")); break;
                case "物料绑定报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("物料绑定报表", "", "")); break;
                case "异常管理报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("异常管理报表", "", "")); break;
                case "工单过站监控报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("工单过站监控报表", "", "")); break;
                case "工单报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("工单报表", "", "")); break;
                case "设备状态报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("设备状态报表", "", "")); break;
                case "生产报工": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("生产报工报表", "", "")); break;
                case "报废报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("报废报表", "", "")); break;
                case "生产工单": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("生产工单", "", "")); break;
                case "基础物料信息表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("基础物料信息表", "", "")); break;
                case "料架物料信息": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("料架物料信息", "", "")); break;
                case "参数设置": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(参数设置); break;
                case "数采配置": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(new 通用模板("DataRefence", "", "")); break;
                case "数采报表": if (PermissionsDo(e.Node.FullPath.ToString())) this.uiPanel1.Controls.Add(数采报表); break;
                default:; break;
            }
            //MessageBox.Show(e.Node.Text);
        }
        private bool PermissionsDo(string ChooseFullPath)
        {
            string[] NowMenu = ChooseFullPath.Replace("▼", "").Split("\\");
            string[] MenuPermissionsDo = 当前允许菜单项.Split(",");
            foreach (string n in NowMenu)
            {
                foreach (string n2 in MenuPermissionsDo)
                {
                    if (n == n2)
                    {
                        uiPanel1.Controls.Clear();
                        return true;
                    }
                }
            }
            MessageBox.Show("当前角色无法使用该界面!");
            return false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///
            /// 生产报工，登出信息
            ///
            通用Service.记录生产报工($"{Store.名称}退出了系统", 当前工序);
            Thread.Sleep(200);
            //DisConnect_OPC();
            System.Environment.Exit(0);
        }
    }
}
